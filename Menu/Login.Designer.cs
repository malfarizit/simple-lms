namespace Library_Management_Syatem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelloginpassword = new System.Windows.Forms.Label();
            this.labelloginusername = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxloginusername = new System.Windows.Forms.TextBox();
            this.textBoxloginpassword = new System.Windows.Forms.TextBox();
            this.labelondate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelloginpassword
            // 
            this.labelloginpassword.AutoSize = true;
            this.labelloginpassword.BackColor = System.Drawing.Color.Transparent;
            this.labelloginpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloginpassword.Location = new System.Drawing.Point(395, 211);
            this.labelloginpassword.Name = "labelloginpassword";
            this.labelloginpassword.Size = new System.Drawing.Size(86, 20);
            this.labelloginpassword.TabIndex = 23;
            this.labelloginpassword.Text = "Password";
            // 
            // labelloginusername
            // 
            this.labelloginusername.AutoSize = true;
            this.labelloginusername.BackColor = System.Drawing.Color.Transparent;
            this.labelloginusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloginusername.Location = new System.Drawing.Point(383, 143);
            this.labelloginusername.Name = "labelloginusername";
            this.labelloginusername.Size = new System.Drawing.Size(97, 20);
            this.labelloginusername.TabIndex = 0;
            this.labelloginusername.Text = "Student ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(308, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(447, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "SignUp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(354, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Forget Password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxloginusername
            // 
            this.textBoxloginusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxloginusername.Location = new System.Drawing.Point(308, 166);
            this.textBoxloginusername.Name = "textBoxloginusername";
            this.textBoxloginusername.Size = new System.Drawing.Size(252, 26);
            this.textBoxloginusername.TabIndex = 1;
            this.textBoxloginusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxloginpassword
            // 
            this.textBoxloginpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxloginpassword.Location = new System.Drawing.Point(308, 234);
            this.textBoxloginpassword.Name = "textBoxloginpassword";
            this.textBoxloginpassword.PasswordChar = '*';
            this.textBoxloginpassword.Size = new System.Drawing.Size(252, 26);
            this.textBoxloginpassword.TabIndex = 2;
            this.textBoxloginpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelondate
            // 
            this.labelondate.AutoSize = true;
            this.labelondate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelondate.Location = new System.Drawing.Point(744, 537);
            this.labelondate.Name = "labelondate";
            this.labelondate.Size = new System.Drawing.Size(18, 25);
            this.labelondate.TabIndex = 24;
            this.labelondate.Text = ".";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(899, 571);
            this.Controls.Add(this.labelondate);
            this.Controls.Add(this.textBoxloginpassword);
            this.Controls.Add(this.textBoxloginusername);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelloginpassword);
            this.Controls.Add(this.labelloginusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelloginpassword;
        private System.Windows.Forms.Label labelloginusername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxloginusername;
        private System.Windows.Forms.TextBox textBoxloginpassword;
        private System.Windows.Forms.Label labelondate;
    }
}