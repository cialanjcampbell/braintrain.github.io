namespace QuizNea
{
    partial class FmEditTopic
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
            this.TopicListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtBack = new System.Windows.Forms.Button();
            this.BtRename = new System.Windows.Forms.Button();
            this.newNameTxtBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopicListBox
            // 
            this.TopicListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopicListBox.FormattingEnabled = true;
            this.TopicListBox.Location = new System.Drawing.Point(68, 3);
            this.TopicListBox.Name = "TopicListBox";
            this.TopicListBox.Size = new System.Drawing.Size(297, 133);
            this.TopicListBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.TopicListBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.newNameTxtBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 311);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.BtBack, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtRename, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(68, 173);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(297, 135);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // BtBack
            // 
            this.BtBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtBack.Location = new System.Drawing.Point(3, 70);
            this.BtBack.Name = "BtBack";
            this.BtBack.Size = new System.Drawing.Size(291, 62);
            this.BtBack.TabIndex = 2;
            this.BtBack.Text = "Cancel/Go Back";
            this.BtBack.UseVisualStyleBackColor = true;
            this.BtBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // BtRename
            // 
            this.BtRename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRename.ForeColor = System.Drawing.Color.Black;
            this.BtRename.Location = new System.Drawing.Point(3, 3);
            this.BtRename.Name = "BtRename";
            this.BtRename.Size = new System.Drawing.Size(291, 61);
            this.BtRename.TabIndex = 4;
            this.BtRename.Text = "Update";
            this.BtRename.UseVisualStyleBackColor = true;
            this.BtRename.Click += new System.EventHandler(this.BtRename_Click);
            // 
            // newNameTxtBox
            // 
            this.newNameTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNameTxtBox.Location = new System.Drawing.Point(68, 142);
            this.newNameTxtBox.Name = "newNameTxtBox";
            this.newNameTxtBox.Size = new System.Drawing.Size(297, 20);
            this.newNameTxtBox.TabIndex = 3;
            // 
            // FmEditTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmEditTopic";
            this.Text = "Edit Topic";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TopicListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtBack;
        private System.Windows.Forms.TextBox newNameTxtBox;
        private System.Windows.Forms.Button BtRename;
    }
}