namespace QuizNea
{
    partial class FmRevision
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
            this.BtRecalled = new System.Windows.Forms.Button();
            this.BtNotRecalled = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtShowAnswer = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtBack = new System.Windows.Forms.Button();
            this.BtQuit = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.TxtBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtRecalled
            // 
            this.BtRecalled.BackColor = System.Drawing.Color.Lime;
            this.BtRecalled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtRecalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRecalled.Location = new System.Drawing.Point(80, 9);
            this.BtRecalled.Name = "BtRecalled";
            this.BtRecalled.Size = new System.Drawing.Size(265, 46);
            this.BtRecalled.TabIndex = 0;
            this.BtRecalled.Text = "Recalled";
            this.BtRecalled.UseVisualStyleBackColor = false;
            this.BtRecalled.Click += new System.EventHandler(this.BtRecalled_Click);
            // 
            // BtNotRecalled
            // 
            this.BtNotRecalled.BackColor = System.Drawing.Color.Red;
            this.BtNotRecalled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtNotRecalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNotRecalled.Location = new System.Drawing.Point(428, 9);
            this.BtNotRecalled.Name = "BtNotRecalled";
            this.BtNotRecalled.Size = new System.Drawing.Size(265, 46);
            this.BtNotRecalled.TabIndex = 2;
            this.BtNotRecalled.Text = "Not Recalled";
            this.BtNotRecalled.UseVisualStyleBackColor = false;
            this.BtNotRecalled.Click += new System.EventHandler(this.BtNotRecalled_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxQuestion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxAnswer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.89575F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.10425F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 459);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.BtNotRecalled, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtRecalled, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 285);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(777, 65);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // TxtBoxQuestion
            // 
            this.TxtBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxQuestion.Location = new System.Drawing.Point(3, 3);
            this.TxtBoxQuestion.Name = "TxtBoxQuestion";
            this.TxtBoxQuestion.ReadOnly = true;
            this.TxtBoxQuestion.Size = new System.Drawing.Size(777, 143);
            this.TxtBoxQuestion.TabIndex = 3;
            this.TxtBoxQuestion.Text = "";
            this.TxtBoxQuestion.Click += new System.EventHandler(this.TxtBox_EditAttempt);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.BtShowAnswer, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 356);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(777, 55);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // BtShowAnswer
            // 
            this.BtShowAnswer.BackColor = System.Drawing.Color.Lavender;
            this.BtShowAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtShowAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtShowAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtShowAnswer.Location = new System.Drawing.Point(262, 3);
            this.BtShowAnswer.Name = "BtShowAnswer";
            this.BtShowAnswer.Size = new System.Drawing.Size(253, 49);
            this.BtShowAnswer.TabIndex = 9;
            this.BtShowAnswer.Text = "Show Answer";
            this.BtShowAnswer.UseVisualStyleBackColor = false;
            this.BtShowAnswer.Click += new System.EventHandler(this.BtShowAnswer_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.BtBack, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtQuit, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.progressBar, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 417);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(777, 39);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // BtBack
            // 
            this.BtBack.BackColor = System.Drawing.Color.Lavender;
            this.BtBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtBack.Location = new System.Drawing.Point(3, 3);
            this.BtBack.Name = "BtBack";
            this.BtBack.Size = new System.Drawing.Size(71, 33);
            this.BtBack.TabIndex = 7;
            this.BtBack.Text = "Back ";
            this.BtBack.UseVisualStyleBackColor = false;
            this.BtBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // BtQuit
            // 
            this.BtQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtQuit.ForeColor = System.Drawing.Color.Red;
            this.BtQuit.Location = new System.Drawing.Point(701, 3);
            this.BtQuit.Name = "BtQuit";
            this.BtQuit.Size = new System.Drawing.Size(73, 33);
            this.BtQuit.TabIndex = 8;
            this.BtQuit.Text = "Quit";
            this.BtQuit.UseVisualStyleBackColor = true;
            this.BtQuit.Click += new System.EventHandler(this.BtQuit_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(80, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(615, 33);
            this.progressBar.TabIndex = 9;
            // 
            // TxtBoxAnswer
            // 
            this.TxtBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxAnswer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtBoxAnswer.Location = new System.Drawing.Point(3, 152);
            this.TxtBoxAnswer.Name = "TxtBoxAnswer";
            this.TxtBoxAnswer.ReadOnly = true;
            this.TxtBoxAnswer.Size = new System.Drawing.Size(777, 127);
            this.TxtBoxAnswer.TabIndex = 2;
            this.TxtBoxAnswer.Text = "";
            this.TxtBoxAnswer.Click += new System.EventHandler(this.TxtBox_EditAttempt);
            // 
            // FmLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(783, 459);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmLearn";
            this.Text = "Review";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtRecalled;
        private System.Windows.Forms.Button BtNotRecalled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox TxtBoxAnswer;
        private System.Windows.Forms.RichTextBox TxtBoxQuestion;
        private System.Windows.Forms.Button BtBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BtShowAnswer;
        private System.Windows.Forms.Button BtQuit;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}