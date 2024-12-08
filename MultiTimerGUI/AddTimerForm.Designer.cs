namespace MultiTimerGUI
{
    partial class AddTimerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddButton = new Button();
            CancelButton = new Button();
            SecondsBox = new TextBox();
            MinutesBox = new TextBox();
            HoursBox = new TextBox();
            HoursLable = new Label();
            MinutesLable = new Label();
            SecondsLable = new Label();
            Dot = new Label();
            label1 = new Label();
            NameBox = new TextBox();
            NameLable = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(55, 209);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(226, 209);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SecondsBox
            // 
            SecondsBox.Location = new Point(268, 132);
            SecondsBox.Name = "SecondsBox";
            SecondsBox.Size = new Size(74, 27);
            SecondsBox.TabIndex = 2;
            SecondsBox.Text = "0";
            SecondsBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MinutesBox
            // 
            MinutesBox.Location = new Point(155, 132);
            MinutesBox.Name = "MinutesBox";
            MinutesBox.Size = new Size(72, 27);
            MinutesBox.TabIndex = 3;
            MinutesBox.Text = "0";
            MinutesBox.TextAlign = HorizontalAlignment.Center;
            // 
            // HoursBox
            // 
            HoursBox.Location = new Point(43, 132);
            HoursBox.Name = "HoursBox";
            HoursBox.PlaceholderText = "0";
            HoursBox.RightToLeft = RightToLeft.Yes;
            HoursBox.Size = new Size(73, 27);
            HoursBox.TabIndex = 4;
            HoursBox.Text = "0";
            HoursBox.TextAlign = HorizontalAlignment.Center;
            // 
            // HoursLable
            // 
            HoursLable.AutoSize = true;
            HoursLable.Location = new Point(55, 92);
            HoursLable.Name = "HoursLable";
            HoursLable.Size = new Size(48, 20);
            HoursLable.TabIndex = 5;
            HoursLable.Text = "Hours";
            // 
            // MinutesLable
            // 
            MinutesLable.AutoSize = true;
            MinutesLable.Location = new Point(161, 92);
            MinutesLable.Name = "MinutesLable";
            MinutesLable.Size = new Size(61, 20);
            MinutesLable.TabIndex = 6;
            MinutesLable.Text = "Minutes";
            // 
            // SecondsLable
            // 
            SecondsLable.AutoSize = true;
            SecondsLable.Location = new Point(268, 92);
            SecondsLable.Name = "SecondsLable";
            SecondsLable.Size = new Size(64, 20);
            SecondsLable.TabIndex = 7;
            SecondsLable.Text = "Seconds";
            // 
            // Dot
            // 
            Dot.AutoSize = true;
            Dot.Location = new Point(233, 139);
            Dot.Name = "Dot";
            Dot.Size = new Size(12, 20);
            Dot.TabIndex = 8;
            Dot.Text = ":";
            Dot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 139);
            label1.Name = "label1";
            label1.Size = new Size(12, 20);
            label1.TabIndex = 9;
            label1.Text = ":";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(142, 32);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(125, 27);
            NameBox.TabIndex = 10;
            // 
            // NameLable
            // 
            NameLable.AutoSize = true;
            NameLable.Location = new Point(26, 39);
            NameLable.Name = "NameLable";
            NameLable.Size = new Size(94, 20);
            NameLable.TabIndex = 11;
            NameLable.Text = "Timer Name:";
            NameLable.Click += NameLable_Click;
            // 
            // AddTimerForm
            // 
            ClientSize = new Size(382, 253);
            Controls.Add(NameLable);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Controls.Add(Dot);
            Controls.Add(SecondsLable);
            Controls.Add(MinutesLable);
            Controls.Add(HoursLable);
            Controls.Add(HoursBox);
            Controls.Add(MinutesBox);
            Controls.Add(SecondsBox);
            Controls.Add(CancelButton);
            Controls.Add(AddButton);
            MaximumSize = new Size(400, 300);
            MinimumSize = new Size(400, 300);
            Name = "AddTimerForm";
            Text = "AddTimer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button CancelButton;
        private TextBox SecondsBox;
        private TextBox MinutesBox;
        private TextBox HoursBox;
        private Label HoursLable;
        private Label MinutesLable;
        private Label SecondsLable;
        private Label Dot;
        private Label label1;
        private TextBox NameBox;
        private Label NameLable;
    }
}