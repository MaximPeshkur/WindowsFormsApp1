namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.UserSurnameField = new System.Windows.Forms.TextBox();
            this.UserNameField = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.RegisterLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.UserSurnameField);
            this.panel1.Controls.Add(this.UserNameField);
            this.panel1.Controls.Add(this.RegisterButton);
            this.panel1.Controls.Add(this.PassField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LoginField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(386, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Фамилия:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(460, 198);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(89, 40);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Имя:";
            // 
            // UserSurnameField
            // 
            this.UserSurnameField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserSurnameField.Location = new System.Drawing.Point(555, 270);
            this.UserSurnameField.Multiline = true;
            this.UserSurnameField.Name = "UserSurnameField";
            this.UserSurnameField.Size = new System.Drawing.Size(233, 60);
            this.UserSurnameField.TabIndex = 7;
            this.UserSurnameField.Enter += new System.EventHandler(this.UserSurnameField_Enter);
            this.UserSurnameField.Leave += new System.EventHandler(this.UserSurnameField_Leave);
            // 
            // UserNameField
            // 
            this.UserNameField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameField.Location = new System.Drawing.Point(555, 178);
            this.UserNameField.Multiline = true;
            this.UserNameField.Name = "UserNameField";
            this.UserNameField.Size = new System.Drawing.Size(233, 60);
            this.UserNameField.TabIndex = 6;
            this.UserNameField.Enter += new System.EventHandler(this.UserNameField_Enter);
            this.UserNameField.Leave += new System.EventHandler(this.UserNameField_Leave);
            // 
            // RegisterButton
            // 
            this.RegisterButton.AutoSize = true;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(43)))));
            this.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(68)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(321, 351);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(228, 61);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "Зарегистрироваться";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(73, 286);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(233, 44);
            this.PassField.TabIndex = 4;
            this.PassField.UseSystemPasswordChar = true;
            this.PassField.Enter += new System.EventHandler(this.PassField_Enter);
            this.PassField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(73, 178);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(233, 60);
            this.LoginField.TabIndex = 2;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 172);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(758, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 29);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 172);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.lock__2_;
            this.pictureBox2.Location = new System.Drawing.Point(7, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(7, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterLabel.Location = new System.Drawing.Point(376, 415);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(114, 15);
            this.RegisterLabel.TabIndex = 10;
            this.RegisterLabel.Text = "Уже есть аккаунт?";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox UserSurnameField;
        private System.Windows.Forms.TextBox UserNameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RegisterLabel;
    }
}