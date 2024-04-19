namespace Cafe_project_semester_5
{
    partial class Update_Account
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnhistory = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdfemale = new System.Windows.Forms.RadioButton();
            this.rdmale = new System.Windows.Forms.RadioButton();
            this.tbconfirmpassword = new System.Windows.Forms.TextBox();
            this.tccontact = new System.Windows.Forms.TextBox();
            this.tbcnic = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.btnupdateuser = new System.Windows.Forms.Button();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnhistory);
            this.panel1.Controls.Add(this.btnorder);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 452);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(0, 213);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(156, 45);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button5_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(0, 164);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(156, 45);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Delete Account";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(0, 115);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(156, 45);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update Profile";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnhistory
            // 
            this.btnhistory.Location = new System.Drawing.Point(0, 66);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(156, 45);
            this.btnhistory.TabIndex = 2;
            this.btnhistory.Text = "View Order History";
            this.btnhistory.UseVisualStyleBackColor = true;
            this.btnhistory.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.SystemColors.Control;
            this.btnorder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorder.Location = new System.Drawing.Point(0, 18);
            this.btnorder.Margin = new System.Windows.Forms.Padding(0);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(156, 45);
            this.btnorder.TabIndex = 1;
            this.btnorder.Text = "Place Order";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpdob
            // 
            this.dtpdob.Location = new System.Drawing.Point(491, 181);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(143, 20);
            this.dtpdob.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Date_Of_Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "CNIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Name";
            // 
            // rdfemale
            // 
            this.rdfemale.AutoSize = true;
            this.rdfemale.Location = new System.Drawing.Point(311, 188);
            this.rdfemale.Name = "rdfemale";
            this.rdfemale.Size = new System.Drawing.Size(59, 17);
            this.rdfemale.TabIndex = 33;
            this.rdfemale.TabStop = true;
            this.rdfemale.Text = "Female";
            this.rdfemale.UseVisualStyleBackColor = true;
            this.rdfemale.CheckedChanged += new System.EventHandler(this.rdfemale_CheckedChanged);
            // 
            // rdmale
            // 
            this.rdmale.AutoSize = true;
            this.rdmale.Location = new System.Drawing.Point(231, 188);
            this.rdmale.Name = "rdmale";
            this.rdmale.Size = new System.Drawing.Size(48, 17);
            this.rdmale.TabIndex = 32;
            this.rdmale.TabStop = true;
            this.rdmale.Text = "Male";
            this.rdmale.UseVisualStyleBackColor = true;
            this.rdmale.CheckedChanged += new System.EventHandler(this.rdmale_CheckedChanged);
            // 
            // tbconfirmpassword
            // 
            this.tbconfirmpassword.Location = new System.Drawing.Point(491, 230);
            this.tbconfirmpassword.Name = "tbconfirmpassword";
            this.tbconfirmpassword.Size = new System.Drawing.Size(143, 20);
            this.tbconfirmpassword.TabIndex = 31;
            this.tbconfirmpassword.UseSystemPasswordChar = true;
            // 
            // tccontact
            // 
            this.tccontact.Location = new System.Drawing.Point(491, 90);
            this.tccontact.Name = "tccontact";
            this.tccontact.Size = new System.Drawing.Size(143, 20);
            this.tccontact.TabIndex = 30;
            // 
            // tbcnic
            // 
            this.tbcnic.Location = new System.Drawing.Point(227, 132);
            this.tbcnic.Name = "tbcnic";
            this.tbcnic.Size = new System.Drawing.Size(143, 20);
            this.tbcnic.TabIndex = 29;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(227, 90);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(143, 20);
            this.tbname.TabIndex = 28;
            // 
            // btnupdateuser
            // 
            this.btnupdateuser.BackColor = System.Drawing.Color.Indigo;
            this.btnupdateuser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdateuser.Location = new System.Drawing.Point(296, 287);
            this.btnupdateuser.Name = "btnupdateuser";
            this.btnupdateuser.Size = new System.Drawing.Size(109, 36);
            this.btnupdateuser.TabIndex = 27;
            this.btnupdateuser.Text = "Update";
            this.btnupdateuser.UseVisualStyleBackColor = false;
            this.btnupdateuser.Click += new System.EventHandler(this.btnupdateuser_Click);
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(231, 231);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(139, 20);
            this.tbpassword.TabIndex = 26;
            this.tbpassword.UseSystemPasswordChar = true;
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(491, 132);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(143, 20);
            this.tbusername.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(343, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 27);
            this.label9.TabIndex = 41;
            this.label9.Text = "Update Profile";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Indigo;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(434, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 36);
            this.button6.TabIndex = 42;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(-6, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(162, 45);
            this.button8.TabIndex = 8;
            this.button8.Text = "Logout";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(533, 256);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(269, 257);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 17);
            this.checkBox2.TabIndex = 44;
            this.checkBox2.Text = "Show password";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Update_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 334);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdfemale);
            this.Controls.Add(this.rdmale);
            this.Controls.Add(this.tbconfirmpassword);
            this.Controls.Add(this.tccontact);
            this.Controls.Add(this.tbcnic);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.btnupdateuser);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Update_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_dashboard";
            this.Load += new System.EventHandler(this.User_dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdfemale;
        private System.Windows.Forms.RadioButton rdmale;
        private System.Windows.Forms.TextBox tbconfirmpassword;
        private System.Windows.Forms.TextBox tccontact;
        private System.Windows.Forms.TextBox tbcnic;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btnupdateuser;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}