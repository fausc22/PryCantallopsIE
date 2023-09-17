namespace PryCantallopsIE
{
    partial class frmRegistroProveedores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.txtJurisdiccion = new System.Windows.Forms.TextBox();
            this.txtJuzgado = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtLiquidacion = new System.Windows.Forms.TextBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtLiquidacion);
            this.groupBox1.Controls.Add(this.txtJurisdiccion);
            this.groupBox1.Controls.Add(this.txtJuzgado);
            this.groupBox1.Controls.Add(this.txtEntidad);
            this.groupBox1.Controls.Add(this.txtNro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtExpediente);
            this.groupBox1.Controls.Add(this.txtApertura);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(892, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "N°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apertura";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° Expediente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Juzgazo ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Liquidacion Responsable";
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(207, 113);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(100, 22);
            this.txtApertura.TabIndex = 9;
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(207, 155);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(100, 22);
            this.txtExpediente.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Jurisdiccion";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(898, 461);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 36);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(1006, 461);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 35);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1116, 461);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 36);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(207, 70);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(100, 22);
            this.txtEntidad.TabIndex = 17;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(207, 27);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(100, 22);
            this.txtNro.TabIndex = 16;
            // 
            // txtJurisdiccion
            // 
            this.txtJurisdiccion.Location = new System.Drawing.Point(207, 238);
            this.txtJurisdiccion.Name = "txtJurisdiccion";
            this.txtJurisdiccion.Size = new System.Drawing.Size(100, 22);
            this.txtJurisdiccion.TabIndex = 19;
            // 
            // txtJuzgado
            // 
            this.txtJuzgado.Location = new System.Drawing.Point(207, 195);
            this.txtJuzgado.Name = "txtJuzgado";
            this.txtJuzgado.Size = new System.Drawing.Size(100, 22);
            this.txtJuzgado.TabIndex = 18;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(207, 322);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 22);
            this.txtDireccion.TabIndex = 21;
            // 
            // txtLiquidacion
            // 
            this.txtLiquidacion.Location = new System.Drawing.Point(207, 279);
            this.txtLiquidacion.Name = "txtLiquidacion";
            this.txtLiquidacion.Size = new System.Drawing.Size(100, 22);
            this.txtLiquidacion.TabIndex = 20;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(24, 68);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.Size = new System.Drawing.Size(852, 377);
            this.dgvProveedores.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(466, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(367, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Registrar Datos del Proveedor";
            // 
            // frmRegistroProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 508);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistroProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistroProveedores";
            this.Load += new System.EventHandler(this.frmRegistroProveedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtLiquidacion;
        private System.Windows.Forms.TextBox txtJurisdiccion;
        private System.Windows.Forms.TextBox txtJuzgado;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label label9;
    }
}