namespace QuizNea
{
    partial class FmEditCard
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
            this.components = new System.ComponentModel.Container();
            this.ViewCalenderTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ScheduledFlashcardsListBox = new System.Windows.Forms.ListBox();
            this.EditCardTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtEditCard = new System.Windows.Forms.Button();
            this.BtDeleteCard = new System.Windows.Forms.Button();
            this.BtBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BtResetMetrics = new System.Windows.Forms.Button();
            this.difficultyScoreTextBox = new System.Windows.Forms.TextBox();
            this.reviewIntervalTextBox = new System.Windows.Forms.TextBox();
            this.reviewDateLabel = new System.Windows.Forms.Label();
            this.repetitionHistoryLabel = new System.Windows.Forms.Label();
            this.avgRecallRateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FlashcardListBox = new System.Windows.Forms.ListBox();
            this.EditScheduleCalender = new System.Windows.Forms.MonthCalendar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.EditCardMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewCalenderTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.EditCardTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewCalenderTab
            // 
            this.ViewCalenderTab.Controls.Add(this.tableLayoutPanel3);
            this.ViewCalenderTab.Location = new System.Drawing.Point(4, 22);
            this.ViewCalenderTab.Name = "ViewCalenderTab";
            this.ViewCalenderTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewCalenderTab.Size = new System.Drawing.Size(792, 424);
            this.ViewCalenderTab.TabIndex = 1;
            this.ViewCalenderTab.Text = "ViewCalender";
            this.ViewCalenderTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.40713F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.59287F));
            this.tableLayoutPanel3.Controls.Add(this.monthCalendar1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ScheduledFlashcardsListBox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // ScheduledFlashcardsListBox
            // 
            this.ScheduledFlashcardsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduledFlashcardsListBox.FormattingEnabled = true;
            this.ScheduledFlashcardsListBox.Location = new System.Drawing.Point(242, 3);
            this.ScheduledFlashcardsListBox.Name = "ScheduledFlashcardsListBox";
            this.ScheduledFlashcardsListBox.Size = new System.Drawing.Size(541, 169);
            this.ScheduledFlashcardsListBox.TabIndex = 1;
            // 
            // EditCardTab
            // 
            this.EditCardTab.Controls.Add(this.tableLayoutPanel1);
            this.EditCardTab.Location = new System.Drawing.Point(4, 22);
            this.EditCardTab.Name = "EditCardTab";
            this.EditCardTab.Padding = new System.Windows.Forms.Padding(3);
            this.EditCardTab.Size = new System.Drawing.Size(792, 424);
            this.EditCardTab.TabIndex = 0;
            this.EditCardTab.Text = "Edit Card";
            this.EditCardTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.17048F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.82951F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditScheduleCalender, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(248, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(535, 140);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(248, 149);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(535, 140);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(248, 295);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.30159F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.69841F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(535, 120);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.BtEditCard, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtDeleteCard, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtBack, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(529, 70);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmEditCard_MouseDown);
            // 
            // BtEditCard
            // 
            this.BtEditCard.BackColor = System.Drawing.Color.Silver;
            this.BtEditCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtEditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEditCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtEditCard.Location = new System.Drawing.Point(135, 3);
            this.BtEditCard.Name = "BtEditCard";
            this.BtEditCard.Size = new System.Drawing.Size(126, 25);
            this.BtEditCard.TabIndex = 2;
            this.BtEditCard.Text = "Update Card";
            this.BtEditCard.UseVisualStyleBackColor = false;
            this.BtEditCard.Click += new System.EventHandler(this.BtEditCard_Click);
            // 
            // BtDeleteCard
            // 
            this.BtDeleteCard.BackColor = System.Drawing.Color.Silver;
            this.BtDeleteCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtDeleteCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDeleteCard.ForeColor = System.Drawing.Color.Red;
            this.BtDeleteCard.Location = new System.Drawing.Point(267, 3);
            this.BtDeleteCard.Name = "BtDeleteCard";
            this.BtDeleteCard.Size = new System.Drawing.Size(126, 25);
            this.BtDeleteCard.TabIndex = 4;
            this.BtDeleteCard.Text = "Delete Card";
            this.BtDeleteCard.UseVisualStyleBackColor = false;
            this.BtDeleteCard.Click += new System.EventHandler(this.BtDeleteCard_Click);
            // 
            // BtBack
            // 
            this.BtBack.BackColor = System.Drawing.Color.Silver;
            this.BtBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtBack.Location = new System.Drawing.Point(3, 34);
            this.BtBack.Name = "BtBack";
            this.BtBack.Size = new System.Drawing.Size(126, 33);
            this.BtBack.TabIndex = 3;
            this.BtBack.Text = "Back to Menu";
            this.BtBack.UseVisualStyleBackColor = false;
            this.BtBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.79268F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.20732F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel5.Controls.Add(this.BtResetMetrics, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.difficultyScoreTextBox, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.reviewIntervalTextBox, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.reviewDateLabel, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.repetitionHistoryLabel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.avgRecallRateLabel, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(529, 38);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // BtResetMetrics
            // 
            this.BtResetMetrics.BackColor = System.Drawing.Color.Silver;
            this.BtResetMetrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtResetMetrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtResetMetrics.Location = new System.Drawing.Point(418, 3);
            this.BtResetMetrics.Name = "BtResetMetrics";
            this.BtResetMetrics.Size = new System.Drawing.Size(68, 28);
            this.BtResetMetrics.TabIndex = 10;
            this.BtResetMetrics.Text = "Reset";
            this.BtResetMetrics.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtResetMetrics.UseVisualStyleBackColor = false;
            this.BtResetMetrics.Click += new System.EventHandler(this.BtResetMetrics_Click);
            // 
            // difficultyScoreTextBox
            // 
            this.difficultyScoreTextBox.Location = new System.Drawing.Point(358, 3);
            this.difficultyScoreTextBox.Name = "difficultyScoreTextBox";
            this.difficultyScoreTextBox.Size = new System.Drawing.Size(54, 20);
            this.difficultyScoreTextBox.TabIndex = 9;
            // 
            // reviewIntervalTextBox
            // 
            this.reviewIntervalTextBox.Location = new System.Drawing.Point(290, 3);
            this.reviewIntervalTextBox.Name = "reviewIntervalTextBox";
            this.reviewIntervalTextBox.Size = new System.Drawing.Size(62, 20);
            this.reviewIntervalTextBox.TabIndex = 8;
            // 
            // reviewDateLabel
            // 
            this.reviewDateLabel.AutoSize = true;
            this.reviewDateLabel.Location = new System.Drawing.Point(181, 0);
            this.reviewDateLabel.Name = "reviewDateLabel";
            this.reviewDateLabel.Size = new System.Drawing.Size(55, 13);
            this.reviewDateLabel.TabIndex = 6;
            this.reviewDateLabel.Text = "Next Date";
            // 
            // repetitionHistoryLabel
            // 
            this.repetitionHistoryLabel.AutoSize = true;
            this.repetitionHistoryLabel.Location = new System.Drawing.Point(92, 0);
            this.repetitionHistoryLabel.Name = "repetitionHistoryLabel";
            this.repetitionHistoryLabel.Size = new System.Drawing.Size(58, 26);
            this.repetitionHistoryLabel.TabIndex = 11;
            this.repetitionHistoryLabel.Text = "Repetition History";
            // 
            // avgRecallRateLabel
            // 
            this.avgRecallRateLabel.AutoSize = true;
            this.avgRecallRateLabel.Location = new System.Drawing.Point(3, 0);
            this.avgRecallRateLabel.Name = "avgRecallRateLabel";
            this.avgRecallRateLabel.Size = new System.Drawing.Size(63, 13);
            this.avgRecallRateLabel.TabIndex = 12;
            this.avgRecallRateLabel.Text = "Recall Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FlashcardListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 140);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flashcards List";
            // 
            // FlashcardListBox
            // 
            this.FlashcardListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlashcardListBox.FormattingEnabled = true;
            this.FlashcardListBox.ItemHeight = 20;
            this.FlashcardListBox.Location = new System.Drawing.Point(0, 19);
            this.FlashcardListBox.Name = "FlashcardListBox";
            this.FlashcardListBox.Size = new System.Drawing.Size(239, 124);
            this.FlashcardListBox.TabIndex = 5;
            this.FlashcardListBox.SelectedIndexChanged += new System.EventHandler(this.FlashcardListBox_SelectedIndexChanged);
            // 
            // EditScheduleCalender
            // 
            this.EditScheduleCalender.Location = new System.Drawing.Point(9, 155);
            this.EditScheduleCalender.Name = "EditScheduleCalender";
            this.EditScheduleCalender.ShowToday = false;
            this.EditScheduleCalender.ShowTodayCircle = false;
            this.EditScheduleCalender.TabIndex = 6;
            this.EditScheduleCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.EditScheduleCalender_DateChanged);
            this.EditScheduleCalender.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.EditScheduleCalender_DateChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.EditCardTab);
            this.tabControl.Controls.Add(this.ViewCalenderTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 3;
            // 
            // EditCardMenuStrip
            // 
            this.EditCardMenuStrip.Name = "EditCardMenuStrip";
            this.EditCardMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // FmEditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "FmEditCard";
            this.Text = "FmEditCard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmEditCard_MouseDown);
            this.ViewCalenderTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.EditCardTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ViewCalenderTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox ScheduledFlashcardsListBox;
        private System.Windows.Forms.TabPage EditCardTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtEditCard;
        private System.Windows.Forms.Button BtDeleteCard;
        private System.Windows.Forms.Button BtBack;
        private System.Windows.Forms.ListBox FlashcardListBox;
        private System.Windows.Forms.MonthCalendar EditScheduleCalender;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label reviewDateLabel;
        private System.Windows.Forms.TextBox reviewIntervalTextBox;
        private System.Windows.Forms.TextBox difficultyScoreTextBox;
        private System.Windows.Forms.Button BtResetMetrics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label repetitionHistoryLabel;
        private System.Windows.Forms.Label avgRecallRateLabel;
        private System.Windows.Forms.ContextMenuStrip EditCardMenuStrip;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}