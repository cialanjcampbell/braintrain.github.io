namespace QuizNea
{
    partial class FmAddCard
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.BtAddCard = new System.Windows.Forms.Button();
            this.BtBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtSwitchMode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.topicListBox = new System.Windows.Forms.ListBox();
            this.toolTipFmAddCard = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(142, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(554, 113);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(142, 122);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(554, 93);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox2_KeyDown);
            // 
            // BtAddCard
            // 
            this.BtAddCard.BackColor = System.Drawing.Color.Silver;
            this.BtAddCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtAddCard.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtAddCard.ForeColor = System.Drawing.Color.Black;
            this.BtAddCard.Location = new System.Drawing.Point(187, 25);
            this.BtAddCard.Name = "BtAddCard";
            this.BtAddCard.Size = new System.Drawing.Size(178, 27);
            this.BtAddCard.TabIndex = 2;
            this.BtAddCard.Text = "Add Card";
            this.toolTipFmAddCard.SetToolTip(this.BtAddCard, "Adds card to the currently selected Topic\r\n");
            this.BtAddCard.UseVisualStyleBackColor = false;
            this.BtAddCard.Click += new System.EventHandler(this.BtAddCard_Click);
            // 
            // BtBack
            // 
            this.BtBack.BackColor = System.Drawing.Color.Silver;
            this.BtBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBack.ForeColor = System.Drawing.Color.Black;
            this.BtBack.Location = new System.Drawing.Point(3, 274);
            this.BtBack.Name = "BtBack";
            this.BtBack.Size = new System.Drawing.Size(133, 42);
            this.BtBack.TabIndex = 3;
            this.BtBack.Text = "Back to Menu";
            this.BtBack.UseVisualStyleBackColor = false;
            this.BtBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtBack, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtSwitchMode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.34266F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.32867F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.32867F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 319);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.BtAddCard, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(142, 221);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.58333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.41667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(554, 95);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // BtSwitchMode
            // 
            this.BtSwitchMode.BackColor = System.Drawing.Color.Silver;
            this.BtSwitchMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtSwitchMode.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.BtSwitchMode.ForeColor = System.Drawing.Color.Black;
            this.BtSwitchMode.Location = new System.Drawing.Point(3, 122);
            this.BtSwitchMode.Name = "BtSwitchMode";
            this.BtSwitchMode.Size = new System.Drawing.Size(133, 93);
            this.BtSwitchMode.TabIndex = 5;
            this.BtSwitchMode.Text = "Switch Type";
            this.BtSwitchMode.UseVisualStyleBackColor = false;
            this.BtSwitchMode.Click += new System.EventHandler(this.BtSwitchMode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.topicListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a Topic";
            // 
            // topicListBox
            // 
            this.topicListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topicListBox.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicListBox.FormattingEnabled = true;
            this.topicListBox.ItemHeight = 21;
            this.topicListBox.Location = new System.Drawing.Point(3, 16);
            this.topicListBox.Name = "topicListBox";
            this.topicListBox.Size = new System.Drawing.Size(127, 94);
            this.topicListBox.TabIndex = 0;
            // 
            // FmAddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 319);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmAddCard";
            this.Text = "FmAddCard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button BtAddCard;
        private System.Windows.Forms.Button BtBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolTip toolTipFmAddCard;
        private System.Windows.Forms.Button BtSwitchMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox topicListBox;
    }
}