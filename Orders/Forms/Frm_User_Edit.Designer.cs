namespace Orders.Forms
{
    partial class Frm_User_Edit
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
            this.CanceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangePasswordChk = new System.Windows.Forms.CheckBox();
            this.ActiveChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CanceBtn
            // 
            this.CanceBtn.Location = new System.Drawing.Point(269, 149);
            this.CanceBtn.Name = "CanceBtn";
            this.CanceBtn.Size = new System.Drawing.Size(75, 23);
            this.CanceBtn.TabIndex = 20;
            this.CanceBtn.Text = "Cancelar";
            this.CanceBtn.UseVisualStyleBackColor = true;
            this.CanceBtn.Click += new System.EventHandler(this.CanceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuario";
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(88, 38);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(351, 20);
            this.UserNameText.TabIndex = 18;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(364, 149);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Guardar";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(88, 12);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(351, 20);
            this.NameText.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Contraseña";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(88, 93);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(351, 20);
            this.PasswordText.TabIndex = 21;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(88, 67);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(351, 20);
            this.EmailText.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email";
            // 
            // ChangePasswordChk
            // 
            this.ChangePasswordChk.AutoSize = true;
            this.ChangePasswordChk.Location = new System.Drawing.Point(88, 119);
            this.ChangePasswordChk.Name = "ChangePasswordChk";
            this.ChangePasswordChk.Size = new System.Drawing.Size(110, 17);
            this.ChangePasswordChk.TabIndex = 25;
            this.ChangePasswordChk.Text = "Cambiar Contraña";
            this.ChangePasswordChk.UseVisualStyleBackColor = true;
            // 
            // ActiveChk
            // 
            this.ActiveChk.AutoSize = true;
            this.ActiveChk.Location = new System.Drawing.Point(221, 119);
            this.ActiveChk.Name = "ActiveChk";
            this.ActiveChk.Size = new System.Drawing.Size(56, 17);
            this.ActiveChk.TabIndex = 26;
            this.ActiveChk.Text = "Active";
            this.ActiveChk.UseVisualStyleBackColor = true;
            // 
            // Frm_User_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 205);
            this.Controls.Add(this.ActiveChk);
            this.Controls.Add(this.ChangePasswordChk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.CanceBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameText);
            this.Name = "Frm_User_Edit";
            this.Text = "Configuración - Usuario";
            this.Load += new System.EventHandler(this.Frm_User_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CanceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChangePasswordChk;
        private System.Windows.Forms.CheckBox ActiveChk;
    }
}