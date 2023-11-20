namespace QuizNea
{
    partial class FmCreateTopic
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
            this.txtBoxTopicName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RbConfirm = new QuizNea.RoundedButton();
            this.RbCancel = new QuizNea.RoundedButton();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxTopicName
            // 
            this.txtBoxTopicName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxTopicName.Location = new System.Drawing.Point(75, 43);
            this.txtBoxTopicName.Name = "txtBoxTopicName";
            this.txtBoxTopicName.Size = new System.Drawing.Size(332, 20);
            this.txtBoxTopicName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Topic Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.Controls.Add(this.txtBoxTopicName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(484, 161);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RbConfirm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RbCancel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 55);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // RbConfirm
            // 
            this.RbConfirm.BorderColor = System.Drawing.Color.Gray;
            this.RbConfirm.BorderDownColor = System.Drawing.Color.Blue;
            this.RbConfirm.BorderDownWidth = 4F;
            this.RbConfirm.BorderOverColor = System.Drawing.Color.Empty;
            this.RbConfirm.BorderOverWidth = 0F;
            this.RbConfirm.BorderRadius = 50;
            this.RbConfirm.BorderWidth = 2F;
            this.RbConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RbConfirm.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.RbConfirm.Location = new System.Drawing.Point(3, 3);
            this.RbConfirm.Name = "RbConfirm";
            this.RbConfirm.Size = new System.Drawing.Size(326, 21);
            this.RbConfirm.TabIndex = 0;
            this.RbConfirm.Text = "Confirm";
            this.RbConfirm.UseVisualStyleBackColor = true;
            this.RbConfirm.Click += new System.EventHandler(this.RbConfirm_Click);
            // 
            // RbCancel
            // 
            this.RbCancel.BorderColor = System.Drawing.Color.Gray;
            this.RbCancel.BorderDownColor = System.Drawing.Color.Blue;
            this.RbCancel.BorderDownWidth = 4F;
            this.RbCancel.BorderOverColor = System.Drawing.Color.Empty;
            this.RbCancel.BorderOverWidth = 0F;
            this.RbCancel.BorderRadius = 50;
            this.RbCancel.BorderWidth = 2F;
            this.RbCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RbCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.RbCancel.Location = new System.Drawing.Point(3, 30);
            this.RbCancel.Name = "RbCancel";
            this.RbCancel.Size = new System.Drawing.Size(326, 22);
            this.RbCancel.TabIndex = 1;
            this.RbCancel.Text = "Cancel";
            this.RbCancel.UseVisualStyleBackColor = true;
            this.RbCancel.Click += new System.EventHandler(this.RbBack_Click);
            // 
            // FmCreateTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FmCreateTopic";
            this.Text = "FmCreateTopic";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTopicName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedButton RbConfirm;
        private RoundedButton RbCancel;
    }
}