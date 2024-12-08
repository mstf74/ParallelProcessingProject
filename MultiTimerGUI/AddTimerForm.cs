using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiTimer;
namespace MultiTimerGUI
{
    public partial class AddTimerForm : Form
    {
        private TimerAppForm mainform;
        public AddTimerForm(TimerAppForm _Mainform)
        {
            InitializeComponent();
            this.mainform = _Mainform;

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            int hours = 0, minutes = 0, seconds = 0;
            try
            {
                string name = NameBox.Text;
                hours = int.Parse(HoursBox.Text);
                minutes = int.Parse(MinutesBox.Text);
                seconds = int.Parse(SecondsBox.Text);
                if ((hours < 0 || minutes < 0 || seconds < 0) || (hours == 0 && minutes == 0 && seconds == 0))
                    throw new Exception();
                mainform.timersList.Add(new Multitimer(hours, minutes, seconds,name));
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please Enter a valid Timer.", "Invalid Timer", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameLable_Click(object sender, EventArgs e)
        {

        }
    }
}
