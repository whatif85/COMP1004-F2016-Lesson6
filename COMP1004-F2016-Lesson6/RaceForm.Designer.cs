namespace COMP1004_F2016_Lesson6
{
    partial class RaceForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.RaceListBox = new System.Windows.Forms.ListBox();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.RaceSelectedLabel = new System.Windows.Forms.Label();
            this.RaceSelectedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 473);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(198, 67);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(239, 473);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(198, 67);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // RaceListBox
            // 
            this.RaceListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RaceListBox.FormattingEnabled = true;
            this.RaceListBox.ItemHeight = 34;
            this.RaceListBox.Items.AddRange(new object[] {
            "Dragonborn",
            "Dwarf",
            "Elf",
            "Half-Elf",
            "Half-Ogre",
            "Half-Orc",
            "Halfling",
            "Human",
            "Tiefling"});
            this.RaceListBox.Location = new System.Drawing.Point(22, 82);
            this.RaceListBox.Name = "RaceListBox";
            this.RaceListBox.Size = new System.Drawing.Size(205, 172);
            this.RaceListBox.Sorted = true;
            this.RaceListBox.TabIndex = 6;
            this.RaceListBox.SelectedIndexChanged += new System.EventHandler(this.RaceListBox_SelectedIndexChanged);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(16, 36);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(211, 34);
            this.RaceLabel.TabIndex = 7;
            this.RaceLabel.Text = "Pick Your Race";
            // 
            // RaceSelectedLabel
            // 
            this.RaceSelectedLabel.AutoSize = true;
            this.RaceSelectedLabel.Location = new System.Drawing.Point(250, 122);
            this.RaceSelectedLabel.Name = "RaceSelectedLabel";
            this.RaceSelectedLabel.Size = new System.Drawing.Size(200, 34);
            this.RaceSelectedLabel.TabIndex = 8;
            this.RaceSelectedLabel.Text = "Race Selected";
            // 
            // RaceSelectedTextBox
            // 
            this.RaceSelectedTextBox.Location = new System.Drawing.Point(256, 173);
            this.RaceSelectedTextBox.Name = "RaceSelectedTextBox";
            this.RaceSelectedTextBox.Size = new System.Drawing.Size(235, 49);
            this.RaceSelectedTextBox.TabIndex = 9;
            // 
            // RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 552);
            this.Controls.Add(this.RaceSelectedTextBox);
            this.Controls.Add(this.RaceSelectedLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.RaceListBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RaceForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ListBox RaceListBox;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label RaceSelectedLabel;
        private System.Windows.Forms.TextBox RaceSelectedTextBox;
    }
}