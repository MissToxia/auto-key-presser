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

namespace Auto_Key_Presser
{
    public partial class MainFrm : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private KeyHandler ghk;

        private float Interval = 10000;
        private int Offset = 0;

        private Random r = new Random();

        public MainFrm()
        {
            InitializeComponent();
            ghk = new KeyHandler(Constants.CTRL, Keys.O, this);
            ghk.Register();
            MaxProgressLbl.Text = (Interval / 1000).ToString() + "s";
        }
        public void DoLeftMouseClick()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)X, (uint)Y, 0, 0);
        }

        public void DoRightMouseClick()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)X, (uint)Y, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(Interval);
            IntervalProgressBar.Maximum = Convert.ToInt32(Interval) / 100;
            IntervalProgressBar.Minimum = 0;
            if (Offset > 0)
            {
                Offset = r.Next(0, Convert.ToInt32(OffsetTxtBox.Text));
                timer1.Interval = Convert.ToInt32(Interval) + Offset;
                MaxProgressLbl.Text = ((Interval + Offset) / 1000).ToString() + "s";
                IntervalProgressBar.Maximum = (Convert.ToInt32(Interval + Offset) / 100);
            }
            timer1.Start();
            timer2.Start();
            button1.Enabled = false;
            button2.Enabled = true;
            IntervalPanel.Enabled = false;
            PressTypePanel.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (KeyRdBtn.Checked)
            {
                SendKeys.Send(KeyTxtBox.Text);
            }
            if (LeftMouseRdBtn.Checked)
            {
                DoLeftMouseClick();
            }
            if (RightMouseRdBtn.Checked)
            {
                DoRightMouseClick();
            }
            IntervalProgressBar.Value = 0;

            if (Offset > 0)
            {
                Offset = r.Next(0, Convert.ToInt32(OffsetTxtBox.Text));
                timer1.Interval = Convert.ToInt32(Interval) + Offset;
                MaxProgressLbl.Text = ((Interval + Offset) / 1000).ToString() + "s";
                IntervalProgressBar.Maximum = (Convert.ToInt32(Interval + Offset) / 100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            IntervalProgressBar.Value = 0;
            button1.Enabled = true;
            button2.Enabled = false;
            IntervalPanel.Enabled = true;
            PressTypePanel.Enabled = true;
        }

        private void IntervalSaveBtn_Click(object sender, EventArgs e)
        {
            Interval = Convert.ToInt32(IntervalTxtBox.Text);
            Offset = r.Next(0, Convert.ToInt32(OffsetTxtBox.Text));
            MaxProgressLbl.Text = ((Interval + Offset) / 1000).ToString() + "s";
        }

        private void KeyRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (KeyRdBtn.Checked == true)
            {
                KeyTxtBox.Enabled = true;
            }
            else
            {
                KeyTxtBox.Enabled = false;
            }
        }

        private void LeftMouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (KeyRdBtn.Checked == true)
            {
                KeyTxtBox.Enabled = true;
            }
            else
            {
                KeyTxtBox.Enabled = false;
            }
        }

        private void RightMouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (KeyRdBtn.Checked == true)
            {
                KeyTxtBox.Enabled = true;
            }
            else
            {
                KeyTxtBox.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            IntervalProgressBar.Increment(10);
            
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            KeyTxtBox.Text = "{ENTER}";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void HandleHotkey()
        {
            if (button1.Enabled)
            {
                button1_Click(this, null);
            }
            else
            {
                button2_Click(this, null);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AboutFrm aboutForm = new AboutFrm();

            aboutForm.Show();
        }
    }
}
