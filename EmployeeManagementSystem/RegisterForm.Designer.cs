
namespace EmployeeManagementSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.Exit = new System.Windows.Forms.Label();
            this.Signup_btn = new System.Windows.Forms.Button();
            this.Signup_ShowPassword = new System.Windows.Forms.CheckBox();
            this.Signup_Password = new System.Windows.Forms.TextBox();
            this.Signup_Username = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Signinbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(555, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(16, 15);
            this.Exit.TabIndex = 18;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Signup_btn
            // 
            this.Signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Signup_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Signup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Signup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Signup_btn.Location = new System.Drawing.Point(54, 276);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(75, 23);
            this.Signup_btn.TabIndex = 17;
            this.Signup_btn.Text = "SIGNUP";
            this.Signup_btn.UseVisualStyleBackColor = false;
            this.Signup_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Signup_ShowPassword
            // 
            this.Signup_ShowPassword.AutoSize = true;
            this.Signup_ShowPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Signup_ShowPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_ShowPassword.Location = new System.Drawing.Point(257, 246);
            this.Signup_ShowPassword.Name = "Signup_ShowPassword";
            this.Signup_ShowPassword.Size = new System.Drawing.Size(108, 18);
            this.Signup_ShowPassword.TabIndex = 16;
            this.Signup_ShowPassword.Text = "ShowPassword";
            this.Signup_ShowPassword.UseVisualStyleBackColor = false;
            this.Signup_ShowPassword.CheckedChanged += new System.EventHandler(this.Login_ShowPassword_CheckedChanged);
            // 
            // Signup_Password
            // 
            this.Signup_Password.Location = new System.Drawing.Point(128, 220);
            this.Signup_Password.Name = "Signup_Password";
            this.Signup_Password.PasswordChar = '*';
            this.Signup_Password.Size = new System.Drawing.Size(237, 20);
            this.Signup_Password.TabIndex = 15;
            this.Signup_Password.TextChanged += new System.EventHandler(this.Login_Password_TextChanged);
            // 
            // Signup_Username
            // 
            this.Signup_Username.Location = new System.Drawing.Point(128, 176);
            this.Signup_Username.Name = "Signup_Username";
            this.Signup_Username.Size = new System.Drawing.Size(237, 20);
            this.Signup_Username.TabIndex = 14;
            this.Signup_Username.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Login_Username_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Register Account";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 110);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 160);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Employee Management System";
            // 
            // Signinbtn
            // 
            this.Signinbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Signinbtn.FlatAppearance.BorderSize = 0;
            this.Signinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signinbtn.ForeColor = System.Drawing.Color.White;
            this.Signinbtn.Location = new System.Drawing.Point(380, 335);
            this.Signinbtn.Name = "Signinbtn";
            this.Signinbtn.Size = new System.Drawing.Size(183, 23);
            this.Signinbtn.TabIndex = 1;
            this.Signinbtn.Text = "SIGNIN";
            this.Signinbtn.UseVisualStyleBackColor = false;
            this.Signinbtn.Click += new System.EventHandler(this.Signinbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(412, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Login Your Account";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Signup_btn);
            this.Controls.Add(this.Signup_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Signinbtn);
            this.Controls.Add(this.Signup_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Signup_ShowPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button Signup_btn;
        private System.Windows.Forms.CheckBox Signup_ShowPassword;
        private System.Windows.Forms.TextBox Signup_Password;
        private System.Windows.Forms.MaskedTextBox Signup_Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Signinbtn;
        private System.Windows.Forms.Label label5;
    }
}