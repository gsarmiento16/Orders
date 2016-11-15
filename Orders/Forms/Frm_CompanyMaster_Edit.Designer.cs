namespace Orders.Forms
{
    partial class Frm_CompanyMaster_Edit
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
            this.CodeText = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CanceBtn
            // 
            this.CanceBtn.Location = new System.Drawing.Point(123, 82);
            this.CanceBtn.Name = "CanceBtn";
            this.CanceBtn.Size = new System.Drawing.Size(75, 23);
            this.CanceBtn.TabIndex = 14;
            this.CanceBtn.Text = "Cancelar";
            this.CanceBtn.UseVisualStyleBackColor = true;
            this.CanceBtn.Click += new System.EventHandler(this.CanceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código";
            // 
            // CodeText
            // 
            this.CodeText.Location = new System.Drawing.Point(77, 39);
            this.CodeText.Name = "CodeText";
            this.CodeText.Size = new System.Drawing.Size(215, 20);
            this.CodeText.TabIndex = 12;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(213, 82);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 11;
            this.SaveBtn.Text = "Guardar";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(77, 13);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(215, 20);
            this.NameText.TabIndex = 9;
            // 
            // Frm_CompanyMaster_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 117);
            this.Controls.Add(this.CanceBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeText);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameText);
            this.Name = "Frm_CompanyMaster_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compañia - Grupo";
            this.Load += new System.EventHandler(this.Frm_CompanyMaster_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CanceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeText;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameText;
    }
}