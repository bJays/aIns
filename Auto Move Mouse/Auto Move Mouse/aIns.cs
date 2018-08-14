#define RELEASE_MODE

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;


namespace Auto_Move_Mouse
{
    public partial class aIns : Form
    {
        private const int CONST_TIMER_INTERVAL = 1000 * 15;
        private const int CONST_FORM_OFFSET_X = 5;
        private const int CONST_FORM_OFFSET_Y = 5;
        private const int CONST_MOUSE_MOVE_OFFSET = 1;

        private System.Windows.Forms.Timer CheckTimer = null;

        private int TickCounter = 0;

        public aIns()
        {
            InitializeComponent();
        }

        private void aIns_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(CONST_FORM_OFFSET_X, CONST_FORM_OFFSET_Y);
#if RELEASE_MODE
                this.DebugLabel.Visible = false;
#else
                this.DebugLabel.Visible = true;
#endif
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox("aIns_Load", ex.Message);
            }
        }
        private void aIns_Shown(object sender, EventArgs e)
        {
            try
            {
                this.AlwaysCheckBox.Checked = false;
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox("aIns_Shown", ex.Message);
            }
        }

        private void aIns_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox("aIns_FormClosing", ex.Message);
            }
        }
        private void aIns_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox("aIns_FormClosed", ex.Message);
            }
        }

        private void AlwaysCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.AlwaysCheckBox.Checked)
                {
                    //this.OperatingTimer.Enabled = true;
                    //this.OperatingTimer.Start();

                    this.CheckTimer = new Timer();
                    this.CheckTimer.Interval = CONST_TIMER_INTERVAL;
                    this.CheckTimer.Tick += new System.EventHandler(this.OperatingTimer_Tick);

                    this.CheckTimer.Enabled = true;
                    this.CheckTimer.Start();
                }
                else
                {
                    //this.OperatingTimer.Stop();
                    //this.OperatingTimer.Enabled = false;    

                    this.CheckTimer.Stop();
                    this.CheckTimer.Enabled = false;

                    this.CheckTimer.Dispose();

                    GC.Collect();
                }
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox("AlwaysCheckBox_CheckedChanged", ex.Message);
            }
        }

        private void OperatingTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                switch(this.TickCounter % 4)
                {
                    // Left
                    case 0:
                        Cursor.Position = new Point(Cursor.Position.X - CONST_MOUSE_MOVE_OFFSET, Cursor.Position.Y);
                        break;

                    // Up
                    case 1:
                        Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - CONST_MOUSE_MOVE_OFFSET);
                        break;

                    // Right                                                
                    case 2:
                        Cursor.Position = new Point(Cursor.Position.X + CONST_MOUSE_MOVE_OFFSET, Cursor.Position.Y);
                        break;

                    // Down
                    case 3:
                        Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + CONST_MOUSE_MOVE_OFFSET);
                        break;

                    default:
                        break;
                }

                if ((int.MaxValue - this.TickCounter) >= 1)
                {
                    this.TickCounter += 1;
                }
                else
                {
                    this.TickCounter = 0;
                }

#if !RELEASE_MODE
                Point tPoint = Cursor.Position;
                this.DebugLabel.Text = string.Format("X:{0:#,0}, Y:{1:#,0}", tPoint.X, tPoint.Y);
#endif
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox("OperatingTimer_Tick", ex.Message);
            }
        }
    }
}


/*
            try
            {
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox("", ex.Message);
            }
*/
