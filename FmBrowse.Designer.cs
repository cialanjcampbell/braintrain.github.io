namespace QuizNea
{
    partial class FmBrowse
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.currentTopicLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RbAddCard = new QuizNea.RoundedButton();
            this.RbCreateTopic = new QuizNea.RoundedButton();
            this.topicListBox = new System.Windows.Forms.ListBox();
            this.topicContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startRevisingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.renameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.topicContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.currentTopicLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.topicListBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // currentTopicLabel
            // 
            this.currentTopicLabel.AutoSize = true;
            this.currentTopicLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentTopicLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.currentTopicLabel.Location = new System.Drawing.Point(140, 0);
            this.currentTopicLabel.Name = "currentTopicLabel";
            this.currentTopicLabel.Size = new System.Drawing.Size(406, 85);
            this.currentTopicLabel.TabIndex = 1;
            this.currentTopicLabel.Text = "Current Topic";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.RbAddCard, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.RbCreateTopic, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(140, 317);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(406, 130);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // RbAddCard
            // 
            this.RbAddCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RbAddCard.BorderColor = System.Drawing.Color.Gray;
            this.RbAddCard.BorderDownColor = System.Drawing.Color.Blue;
            this.RbAddCard.BorderDownWidth = 5F;
            this.RbAddCard.BorderOverColor = System.Drawing.Color.Empty;
            this.RbAddCard.BorderOverWidth = 5F;
            this.RbAddCard.BorderRadius = 50;
            this.RbAddCard.BorderWidth = 3.5F;
            this.RbAddCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RbAddCard.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            this.RbAddCard.Location = new System.Drawing.Point(206, 61);
            this.RbAddCard.Name = "RbAddCard";
            this.RbAddCard.Size = new System.Drawing.Size(197, 66);
            this.RbAddCard.TabIndex = 4;
            this.RbAddCard.Text = "Add Card";
            this.RbAddCard.UseVisualStyleBackColor = false;
            this.RbAddCard.Click += new System.EventHandler(this.RbAddCard_Click);
            // 
            // RbCreateTopic
            // 
            this.RbCreateTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RbCreateTopic.BorderColor = System.Drawing.Color.Gray;
            this.RbCreateTopic.BorderDownColor = System.Drawing.Color.Blue;
            this.RbCreateTopic.BorderDownWidth = 5F;
            this.RbCreateTopic.BorderOverColor = System.Drawing.Color.Empty;
            this.RbCreateTopic.BorderOverWidth = 5F;
            this.RbCreateTopic.BorderRadius = 50;
            this.RbCreateTopic.BorderWidth = 3.5F;
            this.RbCreateTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RbCreateTopic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RbCreateTopic.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            this.RbCreateTopic.Location = new System.Drawing.Point(3, 61);
            this.RbCreateTopic.Name = "RbCreateTopic";
            this.RbCreateTopic.Size = new System.Drawing.Size(197, 66);
            this.RbCreateTopic.TabIndex = 5;
            this.RbCreateTopic.Text = "Create Topic";
            this.RbCreateTopic.UseVisualStyleBackColor = false;
            this.RbCreateTopic.Click += new System.EventHandler(this.RbCreateTopic_Click);
            // 
            // topicListBox
            // 
            this.topicListBox.ContextMenuStrip = this.topicContextMenuStrip;
            this.topicListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicListBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicListBox.FormattingEnabled = true;
            this.topicListBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.topicListBox.ItemHeight = 21;
            this.topicListBox.Location = new System.Drawing.Point(140, 88);
            this.topicListBox.Name = "topicListBox";
            this.topicListBox.Size = new System.Drawing.Size(406, 223);
            this.topicListBox.TabIndex = 0;
            this.topicListBox.SelectedIndexChanged += new System.EventHandler(this.TopicList_SelectedIndexChanged);
            // 
            // topicContextMenuStrip
            // 
            this.topicContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startRevisingMenuItem,
            this.statisticsMenuItem,
            this.toolStripSeparator1,
            this.renameMenuItem,
            this.deleteMenuItem,
            this.toolStripSeparator2,
            this.optionsMenuItem});
            this.topicContextMenuStrip.Name = "topicContextMenuStrip";
            this.topicContextMenuStrip.Size = new System.Drawing.Size(181, 148);
            // 
            // startRevisingMenuItem
            // 
            this.startRevisingMenuItem.Name = "startRevisingMenuItem";
            this.startRevisingMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startRevisingMenuItem.Text = "Start Revising";
            this.startRevisingMenuItem.Click += new System.EventHandler(this.startRevisingMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // renameMenuItem
            // 
            this.renameMenuItem.Name = "renameMenuItem";
            this.renameMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renameMenuItem.Text = "Rename";
            this.renameMenuItem.Click += new System.EventHandler(this.renameMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsMenuItem.Text = "Options";
            this.optionsMenuItem.Click += new System.EventHandler(this.optionsMenuItem_Click);
            // 
            // statisticsMenuItem
            // 
            this.statisticsMenuItem.Name = "statisticsMenuItem";
            this.statisticsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statisticsMenuItem.Text = "View Statistics";
            this.statisticsMenuItem.Click += new System.EventHandler(this.statisticsMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // FmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmBrowse";
            this.Text = "FmBrowse";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.topicContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox topicListBox;
        private System.Windows.Forms.ContextMenuStrip topicContextMenuStrip;
        private System.Windows.Forms.Label currentTopicLabel;
        private System.Windows.Forms.ToolStripMenuItem renameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem startRevisingMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private RoundedButton RbAddCard;
        private RoundedButton RbCreateTopic;
        private System.Windows.Forms.ToolStripMenuItem statisticsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}