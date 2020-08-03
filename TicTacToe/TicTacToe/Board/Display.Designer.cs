namespace Board
{
    partial class Display
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
            this.cell1 = new System.Windows.Forms.Button();
            this.cell2 = new System.Windows.Forms.Button();
            this.dispMain = new System.Windows.Forms.Label();
            this.dispTurn = new System.Windows.Forms.Label();
            this.dispVerdict = new System.Windows.Forms.Label();
            this.cell3 = new System.Windows.Forms.Button();
            this.cell4 = new System.Windows.Forms.Button();
            this.cell5 = new System.Windows.Forms.Button();
            this.cell6 = new System.Windows.Forms.Button();
            this.cell9 = new System.Windows.Forms.Button();
            this.cell8 = new System.Windows.Forms.Button();
            this.cell7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cell1
            // 
            this.cell1.Location = new System.Drawing.Point(48, 77);
            this.cell1.Name = "cell1";
            this.cell1.Size = new System.Drawing.Size(75, 45);
            this.cell1.TabIndex = 0;
            this.cell1.Text = "-";
            this.cell1.UseVisualStyleBackColor = true;
            this.cell1.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell2
            // 
            this.cell2.Location = new System.Drawing.Point(129, 77);
            this.cell2.Name = "cell2";
            this.cell2.Size = new System.Drawing.Size(75, 45);
            this.cell2.TabIndex = 1;
            this.cell2.Text = "-";
            this.cell2.UseVisualStyleBackColor = true;
            this.cell2.Click += new System.EventHandler(this.cell2_Click);
            // 
            // dispMain
            // 
            this.dispMain.AutoSize = true;
            this.dispMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispMain.Location = new System.Drawing.Point(90, 27);
            this.dispMain.Name = "dispMain";
            this.dispMain.Size = new System.Drawing.Size(55, 24);
            this.dispMain.TabIndex = 15;
            this.dispMain.Text = "Turn:";
            this.dispMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dispMain.Click += new System.EventHandler(this.label1_Click);
            // 
            // dispTurn
            // 
            this.dispTurn.AutoSize = true;
            this.dispTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispTurn.Location = new System.Drawing.Point(162, 27);
            this.dispTurn.Name = "dispTurn";
            this.dispTurn.Size = new System.Drawing.Size(22, 27);
            this.dispTurn.TabIndex = 16;
            this.dispTurn.Text = "O";
            this.dispTurn.UseCompatibleTextRendering = true;
            this.dispTurn.UseWaitCursor = true;
            // 
            // dispVerdict
            // 
            this.dispVerdict.AutoSize = true;
            this.dispVerdict.Location = new System.Drawing.Point(91, 277);
            this.dispVerdict.Name = "dispVerdict";
            this.dispVerdict.Size = new System.Drawing.Size(0, 13);
            this.dispVerdict.TabIndex = 17;
            // 
            // cell3
            // 
            this.cell3.Location = new System.Drawing.Point(210, 77);
            this.cell3.Name = "cell3";
            this.cell3.Size = new System.Drawing.Size(75, 45);
            this.cell3.TabIndex = 18;
            this.cell3.Text = "-";
            this.cell3.UseVisualStyleBackColor = true;
            this.cell3.Click += new System.EventHandler(this.cell3_Click);
            // 
            // cell4
            // 
            this.cell4.Location = new System.Drawing.Point(48, 128);
            this.cell4.Name = "cell4";
            this.cell4.Size = new System.Drawing.Size(75, 45);
            this.cell4.TabIndex = 19;
            this.cell4.Text = "-";
            this.cell4.UseVisualStyleBackColor = true;
            this.cell4.Click += new System.EventHandler(this.cell4_Click);
            // 
            // cell5
            // 
            this.cell5.Location = new System.Drawing.Point(129, 128);
            this.cell5.Name = "cell5";
            this.cell5.Size = new System.Drawing.Size(75, 45);
            this.cell5.TabIndex = 21;
            this.cell5.Text = "-";
            this.cell5.UseVisualStyleBackColor = true;
            this.cell5.Click += new System.EventHandler(this.cell5_Click);
            // 
            // cell6
            // 
            this.cell6.Location = new System.Drawing.Point(210, 128);
            this.cell6.Name = "cell6";
            this.cell6.Size = new System.Drawing.Size(75, 45);
            this.cell6.TabIndex = 23;
            this.cell6.Text = "-";
            this.cell6.UseVisualStyleBackColor = true;
            this.cell6.Click += new System.EventHandler(this.cell6_Click);
            // 
            // cell9
            // 
            this.cell9.Location = new System.Drawing.Point(210, 179);
            this.cell9.Name = "cell9";
            this.cell9.Size = new System.Drawing.Size(75, 45);
            this.cell9.TabIndex = 24;
            this.cell9.Text = "-";
            this.cell9.UseVisualStyleBackColor = true;
            this.cell9.Click += new System.EventHandler(this.cell9_Click);
            // 
            // cell8
            // 
            this.cell8.Location = new System.Drawing.Point(129, 179);
            this.cell8.Name = "cell8";
            this.cell8.Size = new System.Drawing.Size(75, 45);
            this.cell8.TabIndex = 25;
            this.cell8.Text = "-";
            this.cell8.UseVisualStyleBackColor = true;
            this.cell8.Click += new System.EventHandler(this.cell8_Click);
            // 
            // cell7
            // 
            this.cell7.Location = new System.Drawing.Point(48, 179);
            this.cell7.Name = "cell7";
            this.cell7.Size = new System.Drawing.Size(75, 45);
            this.cell7.TabIndex = 26;
            this.cell7.Text = "-";
            this.cell7.UseVisualStyleBackColor = true;
            this.cell7.Click += new System.EventHandler(this.cell7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 351);
            this.Controls.Add(this.cell7);
            this.Controls.Add(this.cell8);
            this.Controls.Add(this.cell9);
            this.Controls.Add(this.cell6);
            this.Controls.Add(this.cell5);
            this.Controls.Add(this.cell4);
            this.Controls.Add(this.cell3);
            this.Controls.Add(this.dispVerdict);
            this.Controls.Add(this.dispTurn);
            this.Controls.Add(this.dispMain);
            this.Controls.Add(this.cell2);
            this.Controls.Add(this.cell1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cell1;
        private System.Windows.Forms.Button cell2;
        private System.Windows.Forms.Label dispMain;
        private System.Windows.Forms.Label dispTurn;
        private System.Windows.Forms.Label dispVerdict;
        private System.Windows.Forms.Button cell3;
        private System.Windows.Forms.Button cell4;
        private System.Windows.Forms.Button cell5;
        private System.Windows.Forms.Button cell6;
        private System.Windows.Forms.Button cell9;
        private System.Windows.Forms.Button cell8;
        private System.Windows.Forms.Button cell7;
    }
}

