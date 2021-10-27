namespace Sistema_Contable_Huerto
{
    partial class frmArea
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
            this.txtIdArea = new System.Windows.Forms.TextBox();
            this.txtTipoAreaEmp = new System.Windows.Forms.TextBox();
            this.btnAgregarAr = new System.Windows.Forms.Button();
            this.btnModificarA = new System.Windows.Forms.Button();
            this.btnBorrarA = new System.Windows.Forms.Button();
            this.btnCancelarA = new System.Windows.Forms.Button();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.labelIDa = new System.Windows.Forms.Label();
            this.labelTIPOA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdArea
            // 
            this.txtIdArea.Location = new System.Drawing.Point(32, 25);
            this.txtIdArea.Name = "txtIdArea";
            this.txtIdArea.Size = new System.Drawing.Size(94, 20);
            this.txtIdArea.TabIndex = 0;
            // 
            // txtTipoAreaEmp
            // 
            this.txtTipoAreaEmp.Location = new System.Drawing.Point(132, 25);
            this.txtTipoAreaEmp.Name = "txtTipoAreaEmp";
            this.txtTipoAreaEmp.Size = new System.Drawing.Size(244, 20);
            this.txtTipoAreaEmp.TabIndex = 1;
            // 
            // btnAgregarAr
            // 
            this.btnAgregarAr.Image = global::Sistema_Contable_Huerto.Properties.Resources._285657_floppy_guardar_save_icon;
            this.btnAgregarAr.Location = new System.Drawing.Point(32, 51);
            this.btnAgregarAr.Name = "btnAgregarAr";
            this.btnAgregarAr.Size = new System.Drawing.Size(80, 37);
            this.btnAgregarAr.TabIndex = 2;
            this.btnAgregarAr.Text = "Agregar";
            this.btnAgregarAr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarAr.UseVisualStyleBackColor = true;
            this.btnAgregarAr.Click += new System.EventHandler(this.btnAgregarAr_Click);
            // 
            // btnModificarA
            // 
            this.btnModificarA.Image = global::Sistema_Contable_Huerto.Properties.Resources.istockphoto_1078269892_170x170;
            this.btnModificarA.Location = new System.Drawing.Point(118, 51);
            this.btnModificarA.Name = "btnModificarA";
            this.btnModificarA.Size = new System.Drawing.Size(82, 37);
            this.btnModificarA.TabIndex = 3;
            this.btnModificarA.Text = "Modificar";
            this.btnModificarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarA.UseVisualStyleBackColor = true;
            this.btnModificarA.Click += new System.EventHandler(this.btnModificarA_Click);
            // 
            // btnBorrarA
            // 
            this.btnBorrarA.Image = global::Sistema_Contable_Huerto.Properties.Resources._299045_sign_error_icon;
            this.btnBorrarA.Location = new System.Drawing.Point(206, 51);
            this.btnBorrarA.Name = "btnBorrarA";
            this.btnBorrarA.Size = new System.Drawing.Size(77, 37);
            this.btnBorrarA.TabIndex = 4;
            this.btnBorrarA.Text = "Borrar";
            this.btnBorrarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarA.UseVisualStyleBackColor = true;
            this.btnBorrarA.Click += new System.EventHandler(this.btnBorrarA_Click);
            // 
            // btnCancelarA
            // 
            this.btnCancelarA.Image = global::Sistema_Contable_Huerto.Properties.Resources._5983582;
            this.btnCancelarA.Location = new System.Drawing.Point(289, 51);
            this.btnCancelarA.Name = "btnCancelarA";
            this.btnCancelarA.Size = new System.Drawing.Size(87, 37);
            this.btnCancelarA.TabIndex = 5;
            this.btnCancelarA.Text = "Cancelar";
            this.btnCancelarA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarA.UseVisualStyleBackColor = true;
            this.btnCancelarA.Click += new System.EventHandler(this.btnCancelarA_Click);
            // 
            // dgvArea
            // 
            this.dgvArea.AllowUserToAddRows = false;
            this.dgvArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Location = new System.Drawing.Point(32, 94);
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.ReadOnly = true;
            this.dgvArea.Size = new System.Drawing.Size(344, 199);
            this.dgvArea.TabIndex = 6;
            this.dgvArea.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // labelIDa
            // 
            this.labelIDa.AutoSize = true;
            this.labelIDa.Location = new System.Drawing.Point(29, 9);
            this.labelIDa.Name = "labelIDa";
            this.labelIDa.Size = new System.Drawing.Size(21, 13);
            this.labelIDa.TabIndex = 7;
            this.labelIDa.Text = "ID:";
            // 
            // labelTIPOA
            // 
            this.labelTIPOA.AutoSize = true;
            this.labelTIPOA.Location = new System.Drawing.Point(129, 9);
            this.labelTIPOA.Name = "labelTIPOA";
            this.labelTIPOA.Size = new System.Drawing.Size(85, 13);
            this.labelTIPOA.TabIndex = 8;
            this.labelTIPOA.Text = "Nombre del área";
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 331);
            this.Controls.Add(this.labelTIPOA);
            this.Controls.Add(this.labelIDa);
            this.Controls.Add(this.dgvArea);
            this.Controls.Add(this.btnCancelarA);
            this.Controls.Add(this.btnBorrarA);
            this.Controls.Add(this.btnModificarA);
            this.Controls.Add(this.btnAgregarAr);
            this.Controls.Add(this.txtTipoAreaEmp);
            this.Controls.Add(this.txtIdArea);
            this.Name = "frmArea";
            this.Text = "Área del Empleado";
            this.Load += new System.EventHandler(this.frmArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdArea;
        private System.Windows.Forms.TextBox txtTipoAreaEmp;
        private System.Windows.Forms.Button btnAgregarAr;
        private System.Windows.Forms.Button btnModificarA;
        private System.Windows.Forms.Button btnBorrarA;
        private System.Windows.Forms.Button btnCancelarA;
        private System.Windows.Forms.DataGridView dgvArea;
        private System.Windows.Forms.Label labelIDa;
        private System.Windows.Forms.Label labelTIPOA;
    }
}