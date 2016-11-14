namespace Orders.Forms
{
    partial class Frm_ResourceType
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
            this.NewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(27, 46);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 23);
            this.NewBtn.TabIndex = 0;
            this.NewBtn.Text = "Nuevo";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // Frm_ResourceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 460);
            this.Controls.Add(this.NewBtn);
            this.Name = "Frm_ResourceType";
            this.Text = "Articulo - Tipo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewBtn;
    }
}