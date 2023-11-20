namespace QuizNea
{
    partial class FmMainMenu
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
            this.BtStart = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.BtOptions = new System.Windows.Forms.Button();
            this.BtStatistics = new System.Windows.Forms.Button();
            this.BtQuit = new System.Windows.Forms.Button();
            this.BtInfo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtStart
            // 
            this.BtStart.AutoSize = true;
            this.BtStart.BackColor = System.Drawing.Color.Lavender;
            this.BtStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtStart.Location = new System.Drawing.Point(297, 139);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(190, 62);
            this.BtStart.TabIndex = 0;
            this.BtStart.Text = "Start Learning";
            this.BtStart.UseVisualStyleBackColor = false;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.welcomeLabel.Location = new System.Drawing.Point(297, 68);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(190, 68);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to BrainTrain!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtOptions
            // 
            this.BtOptions.AutoSize = true;
            this.BtOptions.BackColor = System.Drawing.Color.Lavender;
            this.BtOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtOptions.Location = new System.Drawing.Point(297, 207);
            this.BtOptions.Name = "BtOptions";
            this.BtOptions.Size = new System.Drawing.Size(190, 62);
            this.BtOptions.TabIndex = 3;
            this.BtOptions.Text = "Options";
            this.BtOptions.UseVisualStyleBackColor = false;
            this.BtOptions.Click += new System.EventHandler(this.BtOptions_Click);
            // 
            // BtStatistics
            // 
            this.BtStatistics.AutoSize = true;
            this.BtStatistics.BackColor = System.Drawing.Color.Lavender;
            this.BtStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtStatistics.Location = new System.Drawing.Point(297, 275);
            this.BtStatistics.Name = "BtStatistics";
            this.BtStatistics.Size = new System.Drawing.Size(190, 62);
            this.BtStatistics.TabIndex = 4;
            this.BtStatistics.Text = "Statistics";
            this.BtStatistics.UseVisualStyleBackColor = false;
            this.BtStatistics.Click += new System.EventHandler(this.BtStatistics_Click);
            // 
            // BtQuit
            // 
            this.BtQuit.AutoSize = true;
            this.BtQuit.BackColor = System.Drawing.Color.Lavender;
            this.BtQuit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtQuit.ForeColor = System.Drawing.Color.Red;
            this.BtQuit.Location = new System.Drawing.Point(689, 343);
            this.BtQuit.Name = "BtQuit";
            this.BtQuit.Size = new System.Drawing.Size(92, 40);
            this.BtQuit.TabIndex = 5;
            this.BtQuit.Text = "Quit";
            this.BtQuit.UseVisualStyleBackColor = false;
            this.BtQuit.Click += new System.EventHandler(this.BtQuit_Click);
            // 
            // BtInfo
            // 
            this.BtInfo.BackColor = System.Drawing.Color.Lavender;
            this.BtInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtInfo.Location = new System.Drawing.Point(689, 296);
            this.BtInfo.Name = "BtInfo";
            this.BtInfo.Size = new System.Drawing.Size(92, 41);
            this.BtInfo.TabIndex = 6;
            this.BtInfo.Text = "Info";
            this.BtInfo.UseVisualStyleBackColor = false;
            this.BtInfo.Click += new System.EventHandler(this.BtInfo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.BtOptions, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtStatistics, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtQuit, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtInfo, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtStart, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.welcomeLabel, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 411);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // FmMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmMainMenu";
            this.Text = "Main Menu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button BtOptions;
        private System.Windows.Forms.Button BtStatistics;
        private System.Windows.Forms.Button BtQuit;
        private System.Windows.Forms.Button BtInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

