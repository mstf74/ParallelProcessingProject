namespace MultiTimerGUI
{
    partial class Error
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
            ErrorLable = new Label();
            SuspendLayout();
            // 
            // ErrorLable
            // 
            ErrorLable.AutoSize = true;
            ErrorLable.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorLable.Location = new Point(63, 50);
            ErrorLable.Name = "ErrorLable";
            ErrorLable.Size = new Size(48, 20);
            ErrorLable.TabIndex = 0;
            ErrorLable.Text = "Error";
            // 
            // Error
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 153);
            Controls.Add(ErrorLable);
            MaximumSize = new Size(300, 200);
            MinimumSize = new Size(300, 200);
            Name = "Error";
            Text = "Error";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label ErrorLable;
    }
}