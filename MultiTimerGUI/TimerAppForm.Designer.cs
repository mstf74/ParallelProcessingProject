using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;
using MultiTimer;
namespace MultiTimerGUI
{
    partial class TimerAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridView = new DataGridView();
            newButton = new Button();
            removeButton = new Button();
            delayLabel = new Label();
            hoursNumeric = new NumericUpDown();
            minutesNumeric = new NumericUpDown();
            secondsNumeric = new NumericUpDown();
            loopCheckBox = new CheckBox();
            instanceCheckBox = new CheckBox();
            stateGroupBox = new GroupBox();
            progressBar = new ProgressBar();
            PercentageBox = new TextBox();
            playButton = new Button();
            pauseButton = new Button();
            stopButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoursNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutesNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondsNumeric).BeginInit();
            stateGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "FormattedCounter";
            dataGridViewTextBoxColumn1.HeaderText = "Counter";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            dataGridViewTextBoxColumn3.HeaderText = "State";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.LightGray;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(511, 529);
            dataGridView.TabIndex = 0;
            // 
            // newButton
            // 
            newButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            newButton.Location = new Point(595, 12);
            newButton.Name = "newButton";
            newButton.Size = new Size(139, 60);
            newButton.TabIndex = 1;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            removeButton.Location = new Point(595, 96);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(136, 60);
            removeButton.TabIndex = 2;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // delayLabel
            // 
            delayLabel.AutoSize = true;
            delayLabel.Location = new Point(17, 40);
            delayLabel.Name = "delayLabel";
            delayLabel.Size = new Size(50, 20);
            delayLabel.TabIndex = 0;
            delayLabel.Text = "Delay:";
            // 
            // hoursNumeric
            // 
            hoursNumeric.Location = new Point(88, 40);
            hoursNumeric.Name = "hoursNumeric";
            hoursNumeric.Size = new Size(81, 27);
            hoursNumeric.TabIndex = 1;
            // 
            // minutesNumeric
            // 
            minutesNumeric.Location = new Point(175, 38);
            minutesNumeric.Name = "minutesNumeric";
            minutesNumeric.Size = new Size(85, 27);
            minutesNumeric.TabIndex = 2;
            // 
            // secondsNumeric
            // 
            secondsNumeric.Location = new Point(293, 33);
            secondsNumeric.Name = "secondsNumeric";
            secondsNumeric.Size = new Size(111, 27);
            secondsNumeric.TabIndex = 3;
            // 
            // loopCheckBox
            // 
            loopCheckBox.AutoSize = true;
            loopCheckBox.Location = new Point(25, 107);
            loopCheckBox.Name = "loopCheckBox";
            loopCheckBox.Size = new Size(65, 24);
            loopCheckBox.TabIndex = 4;
            loopCheckBox.Text = "Loop";
            // 
            // instanceCheckBox
            // 
            instanceCheckBox.AutoSize = true;
            instanceCheckBox.Location = new Point(25, 130);
            instanceCheckBox.Name = "instanceCheckBox";
            instanceCheckBox.Size = new Size(181, 24);
            instanceCheckBox.TabIndex = 5;
            instanceCheckBox.Text = "Start only one instance";
            // 
            // stateGroupBox
            // 
            stateGroupBox.Anchor = AnchorStyles.Bottom;
            stateGroupBox.Controls.Add(progressBar);
            stateGroupBox.Controls.Add(PercentageBox);
            stateGroupBox.Controls.Add(playButton);
            stateGroupBox.Controls.Add(pauseButton);
            stateGroupBox.Controls.Add(stopButton);
            stateGroupBox.Location = new Point(546, 190);
            stateGroupBox.Name = "stateGroupBox";
            stateGroupBox.Size = new Size(245, 351);
            stateGroupBox.TabIndex = 5;
            stateGroupBox.TabStop = false;
            stateGroupBox.Text = "State";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(17, 290);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(222, 29);
            progressBar.TabIndex = 4;
            // 
            // PercentageBox
            // 
            PercentageBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PercentageBox.Font = new Font("Kristen ITC", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PercentageBox.Location = new Point(40, 99);
            PercentageBox.Multiline = true;
            PercentageBox.Name = "PercentageBox";
            PercentageBox.Size = new Size(169, 170);
            PercentageBox.TabIndex = 3;
            PercentageBox.Text = "0%";
            PercentageBox.TextAlign = HorizontalAlignment.Center;
            PercentageBox.UseSystemPasswordChar = true;
            // 
            // playButton
            // 
            playButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playButton.Location = new Point(17, 38);
            playButton.Name = "playButton";
            playButton.Size = new Size(60, 43);
            playButton.TabIndex = 0;
            playButton.Text = "▶";
            playButton.Click += playButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pauseButton.Location = new Point(96, 37);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(58, 44);
            pauseButton.TabIndex = 1;
            pauseButton.Text = "⏸";
            pauseButton.Click += pauseButton_Click;
            // 
            // stopButton
            // 
            stopButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stopButton.Location = new Point(173, 37);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(53, 44);
            stopButton.TabIndex = 2;
            stopButton.Text = "⏹";
            stopButton.Click += stopButton_Click;
            // 
            // TimerAppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 591);
            Controls.Add(stateGroupBox);
            Controls.Add(removeButton);
            Controls.Add(newButton);
            Controls.Add(dataGridView);
            MaximumSize = new Size(900, 700);
            MinimumSize = new Size(800, 600);
            Name = "TimerAppForm";
            Text = "Timer App";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoursNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutesNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondsNumeric).EndInit();
            stateGroupBox.ResumeLayout(false);
            stateGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public DataGridView dataGridView;
        private GroupBox stateGroupBox;
        private NumericUpDown hoursNumeric, minutesNumeric, secondsNumeric;
        private CheckBox loopCheckBox, instanceCheckBox;
        private Label delayLabel;
        private Button playButton, pauseButton, stopButton, removeButton, newButton;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private TextBox PercentageBox;
        private ProgressBar progressBar;
    }
}
