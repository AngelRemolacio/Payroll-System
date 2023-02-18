namespace FinalProject___Salary_Budgeting_System
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSBSicon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowpassw = new System.Windows.Forms.Button();
            this.btnHidepassw = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSBSicon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.picSBSicon);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 407);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // picSBSicon
            // 
            this.picSBSicon.Image = global::FinalProject___Salary_Budgeting_System.Properties.Resources.PayrollIcon;
            this.picSBSicon.Location = new System.Drawing.Point(70, 87);
            this.picSBSicon.Name = "picSBSicon";
            this.picSBSicon.Size = new System.Drawing.Size(222, 204);
            this.picSBSicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSBSicon.TabIndex = 1;
            this.picSBSicon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(421, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(421, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(430, 126);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(212, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassw
            // 
            this.txtPassw.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPassw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassw.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassw.Location = new System.Drawing.Point(430, 191);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.PasswordChar = '●';
            this.txtPassw.Size = new System.Drawing.Size(212, 22);
            this.txtPassw.TabIndex = 6;
            this.txtPassw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassw_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(561, 257);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(435, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::FinalProject___Salary_Budgeting_System.Properties.Resources.Red;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(694, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(10, 10);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = " ";
            this.toolTip1.SetToolTip(this.btnExit, "Close window.");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowpassw
            // 
            this.btnShowpassw.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShowpassw.BackgroundImage = global::FinalProject___Salary_Budgeting_System.Properties.Resources.eyeicon_1;
            this.btnShowpassw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowpassw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowpassw.FlatAppearance.BorderSize = 0;
            this.btnShowpassw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowpassw.Location = new System.Drawing.Point(618, 191);
            this.btnShowpassw.Name = "btnShowpassw";
            this.btnShowpassw.Size = new System.Drawing.Size(24, 22);
            this.btnShowpassw.TabIndex = 9;
            this.btnShowpassw.Text = " ";
            this.toolTip1.SetToolTip(this.btnShowpassw, "Show password.");
            this.btnShowpassw.UseVisualStyleBackColor = false;
            this.btnShowpassw.Click += new System.EventHandler(this.btnShowpassw_Click);
            // 
            // btnHidepassw
            // 
            this.btnHidepassw.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHidepassw.BackgroundImage = global::FinalProject___Salary_Budgeting_System.Properties.Resources.eyeicon_2;
            this.btnHidepassw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidepassw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidepassw.FlatAppearance.BorderSize = 0;
            this.btnHidepassw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidepassw.Location = new System.Drawing.Point(618, 191);
            this.btnHidepassw.Name = "btnHidepassw";
            this.btnHidepassw.Size = new System.Drawing.Size(24, 22);
            this.btnHidepassw.TabIndex = 10;
            this.btnHidepassw.Text = " ";
            this.toolTip1.SetToolTip(this.btnHidepassw, "Hide password.");
            this.btnHidepassw.UseVisualStyleBackColor = false;
            this.btnHidepassw.Click += new System.EventHandler(this.btnHidepassw_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 405);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowpassw);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.btnHidepassw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll System";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSBSicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picSBSicon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowpassw;
        private System.Windows.Forms.Button btnHidepassw;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

