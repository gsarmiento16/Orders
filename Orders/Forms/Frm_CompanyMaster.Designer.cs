namespace Orders.Forms
{
    partial class Frm_CompanyMaster
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grid = new Orders.General.CustomDataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ext_id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualizadoEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualizadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBtn,
            this.DeleteBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1192, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewBtn
            // 
            this.NewBtn.Image = global::Orders.Properties.Resources.addIcon;
            this.NewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(62, 22);
            this.NewBtn.Text = "Nuevo";
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Image = global::Orders.Properties.Resources.close_delete_128;
            this.DeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(70, 22);
            this.DeleteBtn.Text = "Eliminar";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.Ext_id,
            this.Codigo,
            this.Nombre,
            this.CreatedAt,
            this.CreadoPor,
            this.ActualizadoEn,
            this.ActualizadoPor});
            this.grid.Location = new System.Drawing.Point(6, 38);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(1174, 275);
            this.grid.TabIndex = 1;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Width = 30;
            // 
            // Ext_id
            // 
            this.Ext_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ext_id.DataPropertyName = "Ext_Id";
            this.Ext_id.HeaderText = "Id";
            this.Ext_id.Name = "Ext_id";
            this.Ext_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ext_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Code";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Name";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 250;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "Created";
            this.CreatedAt.HeaderText = "Creado en";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.Width = 200;
            // 
            // CreadoPor
            // 
            this.CreadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreadoPor.DataPropertyName = "UserCreated";
            this.CreadoPor.HeaderText = "Creado por";
            this.CreadoPor.Name = "CreadoPor";
            // 
            // ActualizadoEn
            // 
            this.ActualizadoEn.DataPropertyName = "Updated";
            this.ActualizadoEn.HeaderText = "Actualizado en";
            this.ActualizadoEn.Name = "ActualizadoEn";
            this.ActualizadoEn.Width = 200;
            // 
            // ActualizadoPor
            // 
            this.ActualizadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActualizadoPor.DataPropertyName = "UserUpdated";
            this.ActualizadoPor.HeaderText = "Actualizado por";
            this.ActualizadoPor.Name = "ActualizadoPor";
            // 
            // Frm_CompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 445);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_CompanyMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compañia - Grupo ";
            this.Load += new System.EventHandler(this.Frm_CompanyMaster_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewBtn;
        private General.CustomDataGridView grid;
        private System.Windows.Forms.ToolStripButton DeleteBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewLinkColumn Ext_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualizadoEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualizadoPor;
    }
}