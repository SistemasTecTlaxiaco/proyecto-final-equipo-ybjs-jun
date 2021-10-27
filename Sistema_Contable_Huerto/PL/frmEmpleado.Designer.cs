namespace Sistema_Contable_Huerto
{
    partial class frmEmpleado
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
            this.txtIDEmp = new System.Windows.Forms.TextBox();
            this.txtNom1Empleado = new System.Windows.Forms.TextBox();
            this.txtApe1Empleado = new System.Windows.Forms.TextBox();
            this.txtApe2Empleado = new System.Windows.Forms.TextBox();
            this.txtRFCEmpleado = new System.Windows.Forms.TextBox();
            this.cmbAreaEmpleado = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNom1 = new System.Windows.Forms.Label();
            this.label1Ape = new System.Windows.Forms.Label();
            this.label2Ape = new System.Windows.Forms.Label();
            this.labelRFC = new System.Windows.Forms.Label();
            this.labelAreaEmp = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.txtNom2Empleado = new System.Windows.Forms.TextBox();
            this.label2Nombre = new System.Windows.Forms.Label();
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.labelTipoempleado = new System.Windows.Forms.Label();
            this.dtpNaciEmp = new System.Windows.Forms.DateTimePicker();
            this.dtpicIngresoEmp = new System.Windows.Forms.DateTimePicker();
            this.txtSalarioEmpleado = new System.Windows.Forms.TextBox();
            this.labelFecNacEMp = new System.Windows.Forms.Label();
            this.labelIngresoEmp = new System.Windows.Forms.Label();
            this.labelSalarioEmp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDEmp
            // 
            this.txtIDEmp.Location = new System.Drawing.Point(229, 46);
            this.txtIDEmp.Name = "txtIDEmp";
            this.txtIDEmp.Size = new System.Drawing.Size(88, 20);
            this.txtIDEmp.TabIndex = 0;
            // 
            // txtNom1Empleado
            // 
            this.txtNom1Empleado.Location = new System.Drawing.Point(336, 46);
            this.txtNom1Empleado.Name = "txtNom1Empleado";
            this.txtNom1Empleado.Size = new System.Drawing.Size(132, 20);
            this.txtNom1Empleado.TabIndex = 1;
            // 
            // txtApe1Empleado
            // 
            this.txtApe1Empleado.Location = new System.Drawing.Point(229, 87);
            this.txtApe1Empleado.Name = "txtApe1Empleado";
            this.txtApe1Empleado.Size = new System.Drawing.Size(178, 20);
            this.txtApe1Empleado.TabIndex = 2;
            // 
            // txtApe2Empleado
            // 
            this.txtApe2Empleado.Location = new System.Drawing.Point(413, 87);
            this.txtApe2Empleado.Name = "txtApe2Empleado";
            this.txtApe2Empleado.Size = new System.Drawing.Size(200, 20);
            this.txtApe2Empleado.TabIndex = 3;
            // 
            // txtRFCEmpleado
            // 
            this.txtRFCEmpleado.Location = new System.Drawing.Point(229, 128);
            this.txtRFCEmpleado.Name = "txtRFCEmpleado";
            this.txtRFCEmpleado.Size = new System.Drawing.Size(178, 20);
            this.txtRFCEmpleado.TabIndex = 4;
            // 
            // cmbAreaEmpleado
            // 
            this.cmbAreaEmpleado.FormattingEnabled = true;
            this.cmbAreaEmpleado.Location = new System.Drawing.Point(229, 166);
            this.cmbAreaEmpleado.Name = "cmbAreaEmpleado";
            this.cmbAreaEmpleado.Size = new System.Drawing.Size(178, 21);
            this.cmbAreaEmpleado.TabIndex = 5;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(226, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(37, 13);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "Clave:";
            // 
            // labelNom1
            // 
            this.labelNom1.AutoSize = true;
            this.labelNom1.Location = new System.Drawing.Point(334, 30);
            this.labelNom1.Name = "labelNom1";
            this.labelNom1.Size = new System.Drawing.Size(79, 13);
            this.labelNom1.TabIndex = 7;
            this.labelNom1.Text = "Primer Nombre:";
            // 
            // label1Ape
            // 
            this.label1Ape.AutoSize = true;
            this.label1Ape.Location = new System.Drawing.Point(226, 71);
            this.label1Ape.Name = "label1Ape";
            this.label1Ape.Size = new System.Drawing.Size(79, 13);
            this.label1Ape.TabIndex = 8;
            this.label1Ape.Text = "Primer Apellido:";
            // 
            // label2Ape
            // 
            this.label2Ape.AutoSize = true;
            this.label2Ape.Location = new System.Drawing.Point(410, 71);
            this.label2Ape.Name = "label2Ape";
            this.label2Ape.Size = new System.Drawing.Size(93, 13);
            this.label2Ape.TabIndex = 9;
            this.label2Ape.Text = "Segundo Apellido:";
            // 
            // labelRFC
            // 
            this.labelRFC.AutoSize = true;
            this.labelRFC.Location = new System.Drawing.Point(226, 112);
            this.labelRFC.Name = "labelRFC";
            this.labelRFC.Size = new System.Drawing.Size(31, 13);
            this.labelRFC.TabIndex = 10;
            this.labelRFC.Text = "RFC:";
            // 
            // labelAreaEmp
            // 
            this.labelAreaEmp.AutoSize = true;
            this.labelAreaEmp.Location = new System.Drawing.Point(226, 151);
            this.labelAreaEmp.Name = "labelAreaEmp";
            this.labelAreaEmp.Size = new System.Drawing.Size(79, 13);
            this.labelAreaEmp.TabIndex = 11;
            this.labelAreaEmp.Text = "Área Empleado";
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(51, 31);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(172, 195);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 12;
            this.picFoto.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Image = global::Sistema_Contable_Huerto.Properties.Resources._720970;
            this.btnExaminar.Location = new System.Drawing.Point(51, 232);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(172, 34);
            this.btnExaminar.TabIndex = 13;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExaminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Sistema_Contable_Huerto.Properties.Resources._285657_floppy_guardar_save_icon;
            this.btnAgregar.Location = new System.Drawing.Point(229, 232);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 35);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Sistema_Contable_Huerto.Properties.Resources.istockphoto_1078269892_170x170;
            this.btnModificar.Location = new System.Drawing.Point(327, 232);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 35);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::Sistema_Contable_Huerto.Properties.Resources._299045_sign_error_icon;
            this.btnBorrar.Location = new System.Drawing.Point(426, 232);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 35);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Sistema_Contable_Huerto.Properties.Resources._5983582;
            this.btnCancelar.Location = new System.Drawing.Point(528, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 35);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEmpleados);
            this.groupBox1.Location = new System.Drawing.Point(51, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 183);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(6, 11);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(550, 166);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // txtNom2Empleado
            // 
            this.txtNom2Empleado.Location = new System.Drawing.Point(481, 46);
            this.txtNom2Empleado.Name = "txtNom2Empleado";
            this.txtNom2Empleado.Size = new System.Drawing.Size(132, 20);
            this.txtNom2Empleado.TabIndex = 19;
            // 
            // label2Nombre
            // 
            this.label2Nombre.AutoSize = true;
            this.label2Nombre.Location = new System.Drawing.Point(478, 30);
            this.label2Nombre.Name = "label2Nombre";
            this.label2Nombre.Size = new System.Drawing.Size(93, 13);
            this.label2Nombre.TabIndex = 20;
            this.label2Nombre.Text = "Segundo Nombre:";
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(413, 127);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoEmpleado.TabIndex = 21;
            // 
            // labelTipoempleado
            // 
            this.labelTipoempleado.AutoSize = true;
            this.labelTipoempleado.Location = new System.Drawing.Point(410, 112);
            this.labelTipoempleado.Name = "labelTipoempleado";
            this.labelTipoempleado.Size = new System.Drawing.Size(81, 13);
            this.labelTipoempleado.TabIndex = 22;
            this.labelTipoempleado.Text = "Tipo Empleado:";
            // 
            // dtpNaciEmp
            // 
            this.dtpNaciEmp.CustomFormat = "yyyy-MM-dd";
            this.dtpNaciEmp.Location = new System.Drawing.Point(413, 166);
            this.dtpNaciEmp.Name = "dtpNaciEmp";
            this.dtpNaciEmp.Size = new System.Drawing.Size(200, 20);
            this.dtpNaciEmp.TabIndex = 23;
            // 
            // dtpicIngresoEmp
            // 
            this.dtpicIngresoEmp.CustomFormat = "yyyy-MM-dd";
            this.dtpicIngresoEmp.Location = new System.Drawing.Point(229, 206);
            this.dtpicIngresoEmp.Name = "dtpicIngresoEmp";
            this.dtpicIngresoEmp.Size = new System.Drawing.Size(224, 20);
            this.dtpicIngresoEmp.TabIndex = 24;
            // 
            // txtSalarioEmpleado
            // 
            this.txtSalarioEmpleado.Location = new System.Drawing.Point(459, 205);
            this.txtSalarioEmpleado.Name = "txtSalarioEmpleado";
            this.txtSalarioEmpleado.Size = new System.Drawing.Size(154, 20);
            this.txtSalarioEmpleado.TabIndex = 25;
            // 
            // labelFecNacEMp
            // 
            this.labelFecNacEMp.AutoSize = true;
            this.labelFecNacEMp.Location = new System.Drawing.Point(412, 151);
            this.labelFecNacEMp.Name = "labelFecNacEMp";
            this.labelFecNacEMp.Size = new System.Drawing.Size(108, 13);
            this.labelFecNacEMp.TabIndex = 26;
            this.labelFecNacEMp.Text = "Fecha de Nacimiento";
            // 
            // labelIngresoEmp
            // 
            this.labelIngresoEmp.AutoSize = true;
            this.labelIngresoEmp.Location = new System.Drawing.Point(227, 190);
            this.labelIngresoEmp.Name = "labelIngresoEmp";
            this.labelIngresoEmp.Size = new System.Drawing.Size(153, 13);
            this.labelIngresoEmp.TabIndex = 27;
            this.labelIngresoEmp.Text = "Fecha de ingreso a la Empresa";
            // 
            // labelSalarioEmp
            // 
            this.labelSalarioEmp.AutoSize = true;
            this.labelSalarioEmp.Location = new System.Drawing.Point(456, 189);
            this.labelSalarioEmp.Name = "labelSalarioEmp";
            this.labelSalarioEmp.Size = new System.Drawing.Size(39, 13);
            this.labelSalarioEmp.TabIndex = 28;
            this.labelSalarioEmp.Text = "Salario";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 471);
            this.Controls.Add(this.labelSalarioEmp);
            this.Controls.Add(this.labelIngresoEmp);
            this.Controls.Add(this.labelFecNacEMp);
            this.Controls.Add(this.txtSalarioEmpleado);
            this.Controls.Add(this.dtpicIngresoEmp);
            this.Controls.Add(this.dtpNaciEmp);
            this.Controls.Add(this.labelTipoempleado);
            this.Controls.Add(this.cmbTipoEmpleado);
            this.Controls.Add(this.label2Nombre);
            this.Controls.Add(this.txtNom2Empleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.labelAreaEmp);
            this.Controls.Add(this.labelRFC);
            this.Controls.Add(this.label2Ape);
            this.Controls.Add(this.label1Ape);
            this.Controls.Add(this.labelNom1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.cmbAreaEmpleado);
            this.Controls.Add(this.txtRFCEmpleado);
            this.Controls.Add(this.txtApe2Empleado);
            this.Controls.Add(this.txtApe1Empleado);
            this.Controls.Add(this.txtNom1Empleado);
            this.Controls.Add(this.txtIDEmp);
            this.Name = "frmEmpleado";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDEmp;
        private System.Windows.Forms.TextBox txtNom1Empleado;
        private System.Windows.Forms.TextBox txtApe1Empleado;
        private System.Windows.Forms.TextBox txtApe2Empleado;
        private System.Windows.Forms.TextBox txtRFCEmpleado;
        private System.Windows.Forms.ComboBox cmbAreaEmpleado;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNom1;
        private System.Windows.Forms.Label label1Ape;
        private System.Windows.Forms.Label label2Ape;
        private System.Windows.Forms.Label labelRFC;
        private System.Windows.Forms.Label labelAreaEmp;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TextBox txtNom2Empleado;
        private System.Windows.Forms.Label label2Nombre;
        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.Label labelTipoempleado;
        private System.Windows.Forms.DateTimePicker dtpNaciEmp;
        private System.Windows.Forms.DateTimePicker dtpicIngresoEmp;
        private System.Windows.Forms.TextBox txtSalarioEmpleado;
        private System.Windows.Forms.Label labelFecNacEMp;
        private System.Windows.Forms.Label labelIngresoEmp;
        private System.Windows.Forms.Label labelSalarioEmp;
    }
}