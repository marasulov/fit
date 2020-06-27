namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneNameLabel = new System.Windows.Forms.Label();
            this.teanOneScorelabel = new System.Windows.Forms.Label();
            this.teamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoNameLabel = new System.Windows.Forms.Label();
            this.teanTwoScorelabel = new System.Windows.Forms.Label();
            this.teamTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.roundDropdownComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Location = new System.Drawing.Point(13, 60);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(39, 13);
            this.roundLabel.TabIndex = 0;
            this.roundLabel.Text = "Round";
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(99, 79);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(92, 17);
            this.unplayedOnlyCheckBox.TabIndex = 2;
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.Location = new System.Drawing.Point(16, 134);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(183, 145);
            this.matchupListBox.TabIndex = 3;
            // 
            // teamOneNameLabel
            // 
            this.teamOneNameLabel.AutoSize = true;
            this.teamOneNameLabel.Location = new System.Drawing.Point(229, 134);
            this.teamOneNameLabel.Name = "teamOneNameLabel";
            this.teamOneNameLabel.Size = new System.Drawing.Size(63, 13);
            this.teamOneNameLabel.TabIndex = 0;
            this.teamOneNameLabel.Text = "<team one>";
            // 
            // teanOneScorelabel
            // 
            this.teanOneScorelabel.AutoSize = true;
            this.teanOneScorelabel.Location = new System.Drawing.Point(229, 164);
            this.teanOneScorelabel.Name = "teanOneScorelabel";
            this.teanOneScorelabel.Size = new System.Drawing.Size(35, 13);
            this.teanOneScorelabel.TabIndex = 0;
            this.teanOneScorelabel.Text = "Score";
            // 
            // teamOneScoreTextBox
            // 
            this.teamOneScoreTextBox.Location = new System.Drawing.Point(289, 164);
            this.teamOneScoreTextBox.Name = "teamOneScoreTextBox";
            this.teamOneScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.teamOneScoreTextBox.TabIndex = 1;
            // 
            // teamTwoNameLabel
            // 
            this.teamTwoNameLabel.AutoSize = true;
            this.teamTwoNameLabel.Location = new System.Drawing.Point(229, 222);
            this.teamTwoNameLabel.Name = "teamTwoNameLabel";
            this.teamTwoNameLabel.Size = new System.Drawing.Size(62, 13);
            this.teamTwoNameLabel.TabIndex = 0;
            this.teamTwoNameLabel.Text = "<team two>";
            // 
            // teanTwoScorelabel
            // 
            this.teanTwoScorelabel.AutoSize = true;
            this.teanTwoScorelabel.Location = new System.Drawing.Point(229, 252);
            this.teanTwoScorelabel.Name = "teanTwoScorelabel";
            this.teanTwoScorelabel.Size = new System.Drawing.Size(35, 13);
            this.teanTwoScorelabel.TabIndex = 0;
            this.teanTwoScorelabel.Text = "Score";
            // 
            // teamTwoScoreTextBox
            // 
            this.teamTwoScoreTextBox.Location = new System.Drawing.Point(289, 252);
            this.teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
            this.teamTwoScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.teamTwoScoreTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.Location = new System.Drawing.Point(444, 198);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(75, 23);
            this.scoreButton.TabIndex = 4;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // roundDropdownComboBox
            // 
            this.roundDropdownComboBox.FormattingEnabled = true;
            this.roundDropdownComboBox.Location = new System.Drawing.Point(99, 52);
            this.roundDropdownComboBox.Name = "roundDropdownComboBox";
            this.roundDropdownComboBox.Size = new System.Drawing.Size(121, 21);
            this.roundDropdownComboBox.TabIndex = 5;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 334);
            this.Controls.Add(this.roundDropdownComboBox);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.teamTwoScoreTextBox);
            this.Controls.Add(this.teamOneScoreTextBox);
            this.Controls.Add(this.teanTwoScorelabel);
            this.Controls.Add(this.teamTwoNameLabel);
            this.Controls.Add(this.teanOneScorelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teamOneNameLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TournamentViewerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneNameLabel;
        private System.Windows.Forms.Label teanOneScorelabel;
        private System.Windows.Forms.TextBox teamOneScoreTextBox;
        private System.Windows.Forms.Label teamTwoNameLabel;
        private System.Windows.Forms.Label teanTwoScorelabel;
        private System.Windows.Forms.TextBox teamTwoScoreTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.ComboBox roundDropdownComboBox;
    }
}

