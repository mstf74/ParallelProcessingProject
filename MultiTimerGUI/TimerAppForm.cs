using MultiTimer;
using System.ComponentModel;

namespace MultiTimerGUI
{
    public partial class TimerAppForm : Form
    {
        public BindingList<Multitimer> timersList = new BindingList<Multitimer>();
        private System.Windows.Forms.Timer uiUpdateTimer;
        public TimerAppForm()
        {
            InitializeComponent();
            uiUpdateTimer = new System.Windows.Forms.Timer();
            uiUpdateTimer.Interval = 1000; // Update every second
            uiUpdateTimer.Tick += UiUpdateTimer_Tick;
            uiUpdateTimer.Start();

            dataGridView.DataSource = timersList;

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            var newTimerForm = new AddTimerForm(this);
            newTimerForm.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < timersList.Count)
                {
                    timersList.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedTimer = GetTimer();
                if (selectedTimer.Status == "paused")
                {
                    selectedTimer.Resume();
                }
                else if (selectedTimer.Status == "running")
                {
                    MessageBox.Show("Timer is already running.");
                    return;
                }
                else
                {
                    var runningTimer = selectedTimer.Start(); // Run timer asynchronously
                    //var awaiter = runningTimer.GetAwaiter();
                    //if (awaiter.GetResult())
                    //    awaiter.OnCompleted(() => MessageBox.Show("Timer is finished."));
                }


                //dataGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a row to start the timer.");
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            var selectedTimer = GetTimer();
            if (selectedTimer is not null)
            {


                selectedTimer.Pause();

                // Update DataGridView after timer ends
                //dataGridView.Refresh();

            }
            else
            {
                MessageBox.Show("Please select a row to start the timer.");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            var selectedTimer = GetTimer();
            if (selectedTimer is not null)
            {


                selectedTimer.Reset();

                // Update DataGridView after timer ends
                //dataGridView.Refresh();

            }
            else
            {
                MessageBox.Show("Please select a row to start the timer.");
            }
        }
        private Multitimer GetTimer()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedIndex = dataGridView.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < timersList.Count)
                {
                    return timersList[selectedIndex];
                }
            }
            return null;
        }
        private void UiUpdateTimer_Tick(object sender, EventArgs e)
        {
            // Refresh DataGridView to reflect updated timer counters
            dataGridView.Refresh();
        }
    }
}



