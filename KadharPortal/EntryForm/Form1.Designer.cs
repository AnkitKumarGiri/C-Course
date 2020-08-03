namespace EntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FatherName = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // FatherName
            // 
            this.FatherName.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.FatherName.AutoSize = true;
            this.FatherName.Location = new System.Drawing.Point(76, 111);
            this.FatherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(100, 17);
            this.FatherName.TabIndex = 1;
            this.FatherName.Text = "Father\'s Name";
            this.FatherName.Click += new System.EventHandler(this.FatherName_Click);
            // 
            // Age
            // 
            this.Age.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(76, 159);
            this.Age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(33, 17);
            this.Age.TabIndex = 2;
            this.Age.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(219, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(219, 111);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(132, 22);
            this.txtFatherName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(219, 159);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(132, 22);
            this.txtAge.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(152, 251);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 390);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.FatherName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FatherName;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnSubmit;
    }
}

