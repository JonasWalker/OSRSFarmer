using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace OSRSFarmer
{
    public partial class MouseTracker : Form
    {
        public new System.Windows.Forms.Cursor Cursor { get; set; }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private int _ticks = 0;

        int startMousePositionX;
        int startMousePositionY;

        int bankBoothAtBankBoothX = 865;
        int bankBoothAtBankBoothY = 530;

        int willowTreeAtBankBoothX = 415;
        int willowTreeAtBankBoothY = 850;

        int willowTreeAtWillowTreeX = 925;
        int willowTreeAtWillowTreeY = 629;

        int bankBoothAtWillowTreeX = 1406;
        int bankBoothAtWillowTreeY = 317;

        int oakTreeAtOakTreeX = 1084;
        int oakTreeAtOakTreeY = 603;

        int bankBoothAtOakTreeX = 230;
        int bankBoothAtOakTreeY = 652;

        int oakTreeAtBankBoothX = 1646;
        int oakTreeAtBankBoothY = 488;

        int inventorySlot1X = 1697;
        int inventorySlot1Y = 764;


        //takes 12 second to walk from bankbooth to tree
        //while standing at bankbooth. the bankbooth is at x865y530
        //while standing at bankbooth. the tree is at x415y850
        //while standing at tree. tree is at x925y629
        //while standing at tree. bank booth is at x1406y317
        //inventory slot 1 is at x1697y764

        public MouseTracker()
        {
            InitializeComponent();

            startMousePositionX = MousePosition.X;
            startMousePositionY = MousePosition.Y;

            XCoord.Text = startMousePositionX.ToString();
            YCoord.Text = startMousePositionY.ToString();
        }

        private void MouseTracker_Load(object sender, EventArgs e)
        {
            //Tracker( sender, e);
        }

        //Left Clicks
        public static void DoMouseLeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }


        private void PlaceMouse(int x, int y)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(x,y);
            XCoord.Text = Cursor.Position.X.ToString();
            YCoord.Text = Cursor.Position.Y.ToString();
        }

        public void WaitSomeTime(int time)
        {
            System.Threading.Thread.Sleep(time);
        }

        

        private void willowTreeButton_Click(object sender, EventArgs e)
        {
            //start timer
            //timer1.Start();

            //Place character in a certain position (infront of bank booth)
            //Click start

            //put cursor on the tree. With the saved coordinates of tree
            PlaceMouse(willowTreeAtBankBoothX, willowTreeAtBankBoothY);
            //DoMouseLeftClick on tree (walks over and starts cutting)
            DoMouseLeftClick();
            //Wait 35 seconds
            WaitSomeTime(35000);

            //////while loop begins(waits for escape button)
            while (true)
            {
                //move cursor over tree
                PlaceMouse(willowTreeAtWillowTreeX, willowTreeAtWillowTreeY);
                //DoMouseLeftClick on tree again(assuming the tree was cut down and spawned again)
                DoMouseLeftClick();
                //Wait 20 seconds
                WaitSomeTime(20000);
                //DoMouseLeftClick on tree again(assuming the tree was cut down and spawned again)
                DoMouseLeftClick();
                //Wait 20 seconds
                WaitSomeTime(20000);
                //DoMouseLeftClick on tree again(assuming the tree was cut down and spawned again)
                DoMouseLeftClick();
                //Wait 20 seconds
                WaitSomeTime(20000);
                ///////////inventory should be full/////////
                //place cursor on bank booth
                PlaceMouse(bankBoothAtWillowTreeX, bankBoothAtWillowTreeY);
                //DoMouseLeftClick on bank booth(makes you walk towards booth and opens your bank)
                DoMouseLeftClick();
                //Wait 20 seconds
                WaitSomeTime(20000);
                //move cursor to inventory on slot 1
                PlaceMouse(inventorySlot1X, inventorySlot1Y);
                //DoMouseLeftClick on slot 1(to empty inventory)
                DoMouseLeftClick();
                //place cursor on tree
                PlaceMouse(willowTreeAtBankBoothX, willowTreeAtBankBoothY);
                //DoMouseLeftClick on tree (makes you walk to tree)
                DoMouseLeftClick();
                //Wait 35 seconds
                WaitSomeTime(35000);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            timerLabel.Text = _ticks.ToString();
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            /*if(timer1.Enabled == true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }*/
            WaitSomeTime(3000);
            XCoord.Text = Cursor.Position.X.ToString();
            YCoord.Text = Cursor.Position.Y.ToString();
        }

        private void oakTreeButton_Click(object sender, EventArgs e)
        {
            //start timer
            timer1.Start();

            //Place character in a certain position (infront of bank booth)
            //Click start

            //put cursor on the tree. With the saved coordinates of tree
            PlaceMouse(oakTreeAtBankBoothX, oakTreeAtBankBoothY);
            //DoMouseLeftClick on tree (walks over and starts cutting)
            DoMouseLeftClick();
            //Wait 35 seconds
            WaitSomeTime(35000);

            //////while loop begins(waits for escape button)
            while (true)
            {
                //move cursor over tree
                PlaceMouse(oakTreeAtOakTreeX, oakTreeAtOakTreeY);
                //DoMouseLeftClick on tree again(assuming the tree was cut down and spawned again)
                DoMouseLeftClick();
                //Wait 20 seconds
                WaitSomeTime(20000);
                //DoMouseLeftClick on tree again(assuming the tree was cut down and spawned again)
                DoMouseLeftClick();
                //Wait 20 seconds
                WaitSomeTime(20000);
                //DoMouseLeftClick on tree again(assuming the tree was cut down and spawned again)
                DoMouseLeftClick();
                //Wait 20 seconds
                WaitSomeTime(20000);
                ///////////inventory should be full/////////
                //place cursor on bank booth
                PlaceMouse(bankBoothAtOakTreeX, bankBoothAtOakTreeY);
                //DoMouseLeftClick on bank booth(makes you walk towards booth and opens your bank)
                DoMouseLeftClick();
                //Wait 20 seconds
                WaitSomeTime(20000);
                //move cursor to inventory on slot 1
                PlaceMouse(inventorySlot1X, inventorySlot1Y);
                //DoMouseLeftClick on slot 1(to empty inventory)
                DoMouseLeftClick();
                //place cursor on tree
                PlaceMouse(oakTreeAtBankBoothX, oakTreeAtBankBoothY);
                //DoMouseLeftClick on tree (makes you walk to tree)
                DoMouseLeftClick();
                //Wait 35 seconds
                WaitSomeTime(35000);
            }
        }
    }
}
