namespace QuizNea
{
    partial class FmStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.totalCardsLabel = new System.Windows.Forms.Label();
            this.avgRecallRateLabel = new System.Windows.Forms.Label();
            this.avgDifficultyScoreLabel = new System.Windows.Forms.Label();
            this.avgReviewIntervalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AvgRepetitionsLabel = new System.Windows.Forms.Label();
            this.sucesfullRecallsLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.96954F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.03046F));
            this.tableLayoutPanel2.Controls.Add(this.totalCardsLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.avgRecallRateLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.avgDifficultyScoreLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.avgReviewIntervalLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.AvgRepetitionsLabel, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.sucesfullRecallsLabel, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 444);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // totalCardsLabel
            // 
            this.totalCardsLabel.AutoSize = true;
            this.totalCardsLabel.BackColor = System.Drawing.Color.White;
            this.totalCardsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCardsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalCardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCardsLabel.ForeColor = System.Drawing.Color.Black;
            this.totalCardsLabel.Location = new System.Drawing.Point(127, 0);
            this.totalCardsLabel.Name = "totalCardsLabel";
            this.totalCardsLabel.Size = new System.Drawing.Size(130, 74);
            this.totalCardsLabel.TabIndex = 0;
            this.totalCardsLabel.Text = "Total Cards";
            // 
            // avgRecallRateLabel
            // 
            this.avgRecallRateLabel.AutoSize = true;
            this.avgRecallRateLabel.BackColor = System.Drawing.SystemColors.Window;
            this.avgRecallRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgRecallRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avgRecallRateLabel.Location = new System.Drawing.Point(127, 74);
            this.avgRecallRateLabel.Name = "avgRecallRateLabel";
            this.avgRecallRateLabel.Size = new System.Drawing.Size(130, 74);
            this.avgRecallRateLabel.TabIndex = 1;
            this.avgRecallRateLabel.Text = "Recall Rate";
            // 
            // avgDifficultyScoreLabel
            // 
            this.avgDifficultyScoreLabel.AutoSize = true;
            this.avgDifficultyScoreLabel.BackColor = System.Drawing.SystemColors.Window;
            this.avgDifficultyScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgDifficultyScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avgDifficultyScoreLabel.Location = new System.Drawing.Point(127, 148);
            this.avgDifficultyScoreLabel.Name = "avgDifficultyScoreLabel";
            this.avgDifficultyScoreLabel.Size = new System.Drawing.Size(130, 74);
            this.avgDifficultyScoreLabel.TabIndex = 2;
            this.avgDifficultyScoreLabel.Text = "Diff Score";
            // 
            // avgReviewIntervalLabel
            // 
            this.avgReviewIntervalLabel.AutoSize = true;
            this.avgReviewIntervalLabel.BackColor = System.Drawing.SystemColors.Window;
            this.avgReviewIntervalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avgReviewIntervalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avgReviewIntervalLabel.Location = new System.Drawing.Point(127, 222);
            this.avgReviewIntervalLabel.Name = "avgReviewIntervalLabel";
            this.avgReviewIntervalLabel.Size = new System.Drawing.Size(130, 74);
            this.avgReviewIntervalLabel.TabIndex = 3;
            this.avgReviewIntervalLabel.Text = "Interval";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 74);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Cards:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 74);
            this.label2.TabIndex = 9;
            this.label2.Text = "Average Recall Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 74);
            this.label3.TabIndex = 10;
            this.label3.Text = "Average Difficulty Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 74);
            this.label4.TabIndex = 11;
            this.label4.Text = "Average Interval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 74);
            this.label5.TabIndex = 12;
            this.label5.Text = "Average Repetitions per Card";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 74);
            this.label6.TabIndex = 13;
            this.label6.Text = "Average Succesfull Recalls";
            // 
            // AvgRepetitionsLabel
            // 
            this.AvgRepetitionsLabel.AutoSize = true;
            this.AvgRepetitionsLabel.BackColor = System.Drawing.Color.White;
            this.AvgRepetitionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvgRepetitionsLabel.Location = new System.Drawing.Point(127, 296);
            this.AvgRepetitionsLabel.Name = "AvgRepetitionsLabel";
            this.AvgRepetitionsLabel.Size = new System.Drawing.Size(130, 74);
            this.AvgRepetitionsLabel.TabIndex = 14;
            this.AvgRepetitionsLabel.Text = "Repetition History";
            // 
            // sucesfullRecallsLabel
            // 
            this.sucesfullRecallsLabel.AutoSize = true;
            this.sucesfullRecallsLabel.BackColor = System.Drawing.Color.White;
            this.sucesfullRecallsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sucesfullRecallsLabel.Location = new System.Drawing.Point(127, 370);
            this.sucesfullRecallsLabel.Name = "sucesfullRecallsLabel";
            this.sucesfullRecallsLabel.Size = new System.Drawing.Size(130, 74);
            this.sucesfullRecallsLabel.TabIndex = 15;
            this.sucesfullRecallsLabel.Text = "Succesfull Recalls";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(269, 3);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Workload";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(528, 444);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            title1.Name = "TEST";
            this.chart1.Titles.Add(title1);
            // 
            // FmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "FmStatistics";
            this.Text = "FmStatistics";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label totalCardsLabel;
        private System.Windows.Forms.Label avgRecallRateLabel;
        private System.Windows.Forms.Label avgDifficultyScoreLabel;
        private System.Windows.Forms.Label avgReviewIntervalLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AvgRepetitionsLabel;
        private System.Windows.Forms.Label sucesfullRecallsLabel;
    }
}