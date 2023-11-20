namespace QuizNea
{
    partial class FmOptions
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
            this.BtBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TopicList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtEditCards = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentTopicLabel = new System.Windows.Forms.Label();
            this.optionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateTopicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTopicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFlashcardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFlashcardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.optionsContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtBack
            // 
            this.BtBack.BackColor = System.Drawing.Color.Lavender;
            this.BtBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtBack.Location = new System.Drawing.Point(425, 3);
            this.BtBack.Name = "BtBack";
            this.BtBack.Size = new System.Drawing.Size(65, 52);
            this.BtBack.TabIndex = 7;
            this.BtBack.Text = "Back";
            this.BtBack.UseVisualStyleBackColor = false;
            this.BtBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.TopicList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 411);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // TopicList
            // 
            this.TopicList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopicList.FormattingEnabled = true;
            this.TopicList.ItemHeight = 20;
            this.TopicList.Location = new System.Drawing.Point(3, 67);
            this.TopicList.Name = "TopicList";
            this.TopicList.Size = new System.Drawing.Size(493, 227);
            this.TopicList.TabIndex = 8;
            this.TopicList.SelectedIndexChanged += new System.EventHandler(this.TopicList_SelectedIndexChanged);
            this.TopicList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopicList_MouseDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.BtEditCards, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 300);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(493, 108);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // BtEditCards
            // 
            this.BtEditCards.BackColor = System.Drawing.Color.Lavender;
            this.BtEditCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtEditCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEditCards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtEditCards.Location = new System.Drawing.Point(372, 3);
            this.BtEditCards.Name = "BtEditCards";
            this.BtEditCards.Size = new System.Drawing.Size(118, 102);
            this.BtEditCards.TabIndex = 10;
            this.BtEditCards.Text = "Edit Cards";
            this.BtEditCards.UseVisualStyleBackColor = false;
            this.BtEditCards.Click += new System.EventHandler(this.BtEditCards_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.59838F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.40162F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtBack, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(493, 58);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentTopicLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 52);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Topic:";
            // 
            // currentTopicLabel
            // 
            this.currentTopicLabel.AutoSize = true;
            this.currentTopicLabel.BackColor = System.Drawing.Color.White;
            this.currentTopicLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentTopicLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentTopicLabel.Location = new System.Drawing.Point(3, 18);
            this.currentTopicLabel.Name = "currentTopicLabel";
            this.currentTopicLabel.Size = new System.Drawing.Size(44, 16);
            this.currentTopicLabel.TabIndex = 11;
            this.currentTopicLabel.Text = "None";
            // 
            // optionsContextMenuStrip
            // 
            this.optionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTopicMenuItem,
            this.DeleteTopicMenuItem,
            this.AddFlashcardMenuItem,
            this.EditFlashcardMenuItem});
            this.optionsContextMenuStrip.Name = "optionsContextMenuStrip";
            this.optionsContextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // CreateTopicMenuItem
            // 
            this.CreateTopicMenuItem.Name = "CreateTopicMenuItem";
            this.CreateTopicMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CreateTopicMenuItem.Text = "CreateTopic";
            this.CreateTopicMenuItem.Click += new System.EventHandler(this.BtCreateTopic_Click);
            // 
            // DeleteTopicMenuItem
            // 
            this.DeleteTopicMenuItem.Name = "DeleteTopicMenuItem";
            this.DeleteTopicMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteTopicMenuItem.Text = "Delete";
            this.DeleteTopicMenuItem.Click += new System.EventHandler(this.BtEditTopic_Click);
            // 
            // AddFlashcardMenuItem
            // 
            this.AddFlashcardMenuItem.Name = "AddFlashcardMenuItem";
            this.AddFlashcardMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddFlashcardMenuItem.Text = "Add Flashcard";
            this.AddFlashcardMenuItem.Click += new System.EventHandler(this.BtAddCards_Click);
            // 
            // EditFlashcardMenuItem
            // 
            this.EditFlashcardMenuItem.Name = "EditFlashcardMenuItem";
            this.EditFlashcardMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EditFlashcardMenuItem.Text = "Edit Flashcards";
            this.EditFlashcardMenuItem.Click += new System.EventHandler(this.BtEditCards_Click);
            // 
            // FmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(499, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmOptions";
            this.Text = "FmOptions";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.optionsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox TopicList;
        private System.Windows.Forms.Button BtEditCards;
        private System.Windows.Forms.Label currentTopicLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ContextMenuStrip optionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CreateTopicMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteTopicMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddFlashcardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditFlashcardMenuItem;
    }
}