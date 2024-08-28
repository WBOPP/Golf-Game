namespace footballGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.parAmount = new System.Windows.Forms.Label();
            this.hit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.finishHoleButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.holeN = new System.Windows.Forms.TextBox();
            this.distance = new System.Windows.Forms.TextBox();
            this.hazard = new System.Windows.Forms.TextBox();
            this.overallScore = new System.Windows.Forms.TextBox();
            this.shotResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.clubType = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.parAmount);
            this.panel1.Controls.Add(this.hit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 76);
            this.panel1.TabIndex = 0;
            // 
            // parAmount
            // 
            this.parAmount.AutoSize = true;
            this.parAmount.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parAmount.Location = new System.Drawing.Point(12, 16);
            this.parAmount.Name = "parAmount";
            this.parAmount.Size = new System.Drawing.Size(163, 50);
            this.parAmount.TabIndex = 11;
            this.parAmount.Text = "Par - 5";
            // 
            // hit
            // 
            this.hit.Location = new System.Drawing.Point(487, 16);
            this.hit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(140, 49);
            this.hit.TabIndex = 2;
            this.hit.Text = "Hit Ball (Continue)";
            this.hit.UseVisualStyleBackColor = true;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Golf Simulator";
            this.label1.UseMnemonic = false;
            // 
            // finishHoleButton
            // 
            this.finishHoleButton.Location = new System.Drawing.Point(24, 240);
            this.finishHoleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finishHoleButton.Name = "finishHoleButton";
            this.finishHoleButton.Size = new System.Drawing.Size(140, 103);
            this.finishHoleButton.TabIndex = 3;
            this.finishHoleButton.Text = "Finish Hole";
            this.finishHoleButton.UseVisualStyleBackColor = true;
            this.finishHoleButton.Click += new System.EventHandler(this.finishHole_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Score, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.holeN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.distance, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.hazard, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.overallScore, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 71);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 164);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hole Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Distance To Hole";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "Any Hazard on Hole";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Score.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(326, 81);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(312, 39);
            this.Score.TabIndex = 3;
            this.Score.Text = "Score Par-72";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // holeN
            // 
            this.holeN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holeN.Location = new System.Drawing.Point(5, 45);
            this.holeN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.holeN.Name = "holeN";
            this.holeN.Size = new System.Drawing.Size(312, 22);
            this.holeN.TabIndex = 4;
            this.holeN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // distance
            // 
            this.distance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.distance.Location = new System.Drawing.Point(326, 45);
            this.distance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(312, 22);
            this.distance.TabIndex = 5;
            this.distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hazard
            // 
            this.hazard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hazard.Location = new System.Drawing.Point(5, 125);
            this.hazard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hazard.Name = "hazard";
            this.hazard.Size = new System.Drawing.Size(312, 22);
            this.hazard.TabIndex = 6;
            this.hazard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // overallScore
            // 
            this.overallScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overallScore.Location = new System.Drawing.Point(326, 125);
            this.overallScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.overallScore.Name = "overallScore";
            this.overallScore.Size = new System.Drawing.Size(312, 22);
            this.overallScore.TabIndex = 7;
            this.overallScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shotResult
            // 
            this.shotResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shotResult.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shotResult.Location = new System.Drawing.Point(326, 145);
            this.shotResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shotResult.Multiline = true;
            this.shotResult.Name = "shotResult";
            this.shotResult.Size = new System.Drawing.Size(311, 57);
            this.shotResult.TabIndex = 3;
            this.shotResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 65);
            this.label6.TabIndex = 1;
            this.label6.Text = "Result of Shot:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 137);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose Club:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.shotResult, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.clubType, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 347);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.96117F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.03883F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(643, 208);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // clubType
            // 
            this.clubType.ColumnWidth = 1;
            this.clubType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clubType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clubType.FormattingEnabled = true;
            this.clubType.HorizontalExtent = 30;
            this.clubType.ItemHeight = 16;
            this.clubType.Items.AddRange(new object[] {
            "Driver",
            "Fairway Wood",
            "Long Iron",
            "Mid Iron",
            "Short Iron",
            "Pitching Wedge",
            "Sand Wedge",
            "Putter"});
            this.clubType.Location = new System.Drawing.Point(326, 6);
            this.clubType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clubType.Name = "clubType";
            this.clubType.Size = new System.Drawing.Size(311, 129);
            this.clubType.TabIndex = 4;
            this.clubType.SelectedIndexChanged += new System.EventHandler(this.clubType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Driver Goes 270 - 300 yards";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fairway Wood Goes 250 - 269 yards";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Long Iron Goes 220 - 249 yards";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Mid Iron Goes 155 - 219 yards";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Short Iron Goes 125 - 154 yards";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Pitching Wedge Goes 56 - 124 yards";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(484, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Putter Goes 1 - 14 yards";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(431, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Sand Wedge Goes 15 - 55 yards";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 542);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.finishHoleButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.TextBox holeN;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.TextBox hazard;
        private System.Windows.Forms.TextBox overallScore;
        private System.Windows.Forms.TextBox shotResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox clubType;
        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.Button finishHoleButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label parAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

