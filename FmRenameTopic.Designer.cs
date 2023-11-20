namespace QuizNea
{
    partial class FmRenameTopic
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.newNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RbConfirm = new QuizNea.RoundedButton();
            this.RbCancel = new QuizNea.RoundedButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.newNameTxtBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // newNameTxtBox
            // 
            this.newNameTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNameTxtBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.newNameTxtBox.Location = new System.Drawing.Point(27, 43);
            this.newNameTxtBox.Name = "newNameTxtBox";
            this.newNameTxtBox.Size = new System.Drawing.Size(429, 26);
            this.newNameTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Topic Name:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.RbConfirm, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RbCancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(429, 55);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // RbConfirm
            // 
            this.RbConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RbConfirm.BorderColor = System.Drawing.Color.Gray;
            this.RbConfirm.BorderDownColor = System.Drawing.Color.Blue;
            this.RbConfirm.BorderDownWidth = 2.5F;
            this.RbConfirm.BorderOverColor = System.Drawing.Color.Empty;
            this.RbConfirm.BorderOverWidth = 2.5F;
            this.RbConfirm.BorderRadius = 50;
            this.RbConfirm.BorderWidth = 1.75F;
            this.RbConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RbConfirm.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.RbConfirm.Location = new System.Drawing.Point(3, 3);
            this.RbConfirm.Name = "RbConfirm";
            this.RbConfirm.Size = new System.Drawing.Size(208, 21);
            this.RbConfirm.TabIndex = 1;
            this.RbConfirm.Text = "Confirm";
            this.RbConfirm.UseVisualStyleBackColor = false;
            this.RbConfirm.Click += new System.EventHandler(this.RbConfirm_Click);
            // 
            // RbCancel
            // 
            this.RbCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RbCancel.BorderColor = System.Drawing.Color.Gray;
            this.RbCancel.BorderDownColor = System.Drawing.Color.Blue;
            this.RbCancel.BorderDownWidth = 2.5F;
            this.RbCancel.BorderOverColor = System.Drawing.Color.Empty;
            this.RbCancel.BorderOverWidth = 2.5F;
            this.RbCancel.BorderRadius = 50;
            this.RbCancel.BorderWidth = 1.75F;
            this.RbCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RbCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.RbCancel.Location = new System.Drawing.Point(217, 3);
            this.RbCancel.Name = "RbCancel";
            this.RbCancel.Size = new System.Drawing.Size(209, 21);
            this.RbCancel.TabIndex = 2;
            this.RbCancel.Text = "Cancel";
            this.RbCancel.UseVisualStyleBackColor = false;
            this.RbCancel.Click += new System.EventHandler(this.RbCancel_Click);
            // 
            // FmRenameTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmRenameTopic";
            this.Text = "FmRenameTopic";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox newNameTxtBox;
        private RoundedButton RbConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RoundedButton RbCancel;
    }
}