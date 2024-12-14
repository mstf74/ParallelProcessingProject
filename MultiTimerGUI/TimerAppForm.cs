using MultiTimer;
using System.ComponentModel;

namespace MultiTimerGUI
{
    public partial class TimerAppForm : Form
    {
        public BindingList<Multitimer> timersList = new BindingList<Multitimer>();
        private System.Windows.Forms.Timer uiUpdateTimer;
        // inizialize a GUI timer object to refresh the DataGgridView periodically 
        public TimerAppForm()
        {
            InitializeComponent();
            uiUpdateTimer = new System.Windows.Forms.Timer();
            uiUpdateTimer.Interval = 500;
            uiUpdateTimer.Tick += UiUpdateTimer_Tick;
            uiUpdateTimer.Start();
            this.dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = timersList;

        }
        // new button to create a new MultiTimer object and add it to the timer object list 
        // opens add timer form
        private void newButton_Click(object sender, EventArgs e)
        {
            var newTimerForm = new AddTimerForm(this);
            newTimerForm.ShowDialog();
        }
        // delete button selects the row from the dataGridView table and deletes the object assigned to it
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
        // play button to start the selected timer asynchronously 
        // checks the status of the timer and invoke object functions based on it 
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
        // pause button to pause the selected timer 
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
        // stop button to reset the timer to its initial value 
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
        // a helper function to return the selected MultiTimer object from the DataGridView table  
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
        // the progress bar and box function to show the progress of the selected timer.
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
        // the guiTimer function to refresh the dataGridView table and the progress bar periodically.
        private void UiUpdateTimer_Tick(object sender, EventArgs e)
        {
            dataGridView.Refresh();
            updateProgressBar();
        }
    }
}