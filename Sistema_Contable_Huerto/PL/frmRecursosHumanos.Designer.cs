namespace Sistema_Contable_Huerto
{
    partial class frmRecursosHumanos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Image = global::Sistema_Contable_Huerto.Properties.Resources._6552699;
            this.btnEmpleados.Location = new System.Drawing.Point(245, 44);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(142, 108);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnArea
            // 
            this.btnArea.Image = global::Sistema_Contable_Huerto.Properties.Resources._3460992;
            this.btnArea.Location = new System.Drawing.Point(56, 44);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(137, 108);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Área";
            this.btnArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // frmRecursosHumanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 243);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRecursosHumanos";
            this.Text = "Recursos Humanos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnEmpleados;
    }
}

