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
            uiUpdateTimer.Interval = 500; // Update every second
            uiUpdateTimer.Tick += UiUpdateTimer_Tick;
            uiUpdateTimer.Start();
            this.dataGridView.AutoGenerateColumns = false;
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

        private async void playButton_Click(object sender, EventArgs e)
        {
            var selectedTimer = GetTimer();
            if (selectedTimer is not null)
            {
                if (selectedTimer.Status == "Paused")
                {
                    selectedTimer.Resume();
                }
                else if (selectedTimer.Status == "Running")
                {
                    MessageBox.Show("Timer is already running.");
                    return;
                }
                else
                {
                    var runningTimer = await Task.Run(() => selectedTimer.Start());
                    if (runningTimer) 
                        MessageBox.Show($"Timer {selectedTimer.Name} is finished.");

                }

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
        private void updateProgressBar()
        {
            var selectedTimer = GetTimer();
            if (selectedTimer is not null)
            {
                progressBar.Value = selectedTimer.ProgressPercentage;
                PercentageBox.Text = selectedTimer.ProgressPercentage.ToString()+"%";
            }
            else
                progressBar.Value = 0;


        }
        private void UiUpdateTimer_Tick(object sender, EventArgs e)
        {
            dataGridView.Refresh();
            updateProgressBar();
        }
    }
}



