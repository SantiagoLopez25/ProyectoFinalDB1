namespace ProyectoFinalDB1
{
    partial class FormServicio
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
            this.dataGridViewServicio = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.groupBoxServicio = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicio)).BeginInit();
            this.groupBoxServicio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewServicio
            // 
            this.dataGridViewServicio.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewServicio.Location = new System.Drawing.Point(44, 448);
            this.dataGridViewServicio.Name = "dataGridViewServicio";
            this.dataGridViewServicio.RowHeadersWidth = 62;
            this.dataGridViewServicio.RowTemplate.Height = 28;
            this.dataGridViewServicio.Size = new System.Drawing.Size(1225, 348);
            this.dataGridViewServicio.TabIndex = 23;
            this.dataGridViewServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServicio_CellContentClick);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(1121, 313);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(148, 80);
            this.buttonEliminar.TabIndex = 21;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(813, 313);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(148, 80);
            this.buttonEditar.TabIndex = 20;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(425, 313);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(148, 80);
            this.buttonGuardar.TabIndex = 19;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Location = new System.Drawing.Point(44, 313);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(148, 80);
            this.buttonNuevo.TabIndex = 18;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // groupBoxServicio
            // 
            this.groupBoxServicio.Controls.Add(this.checkBox1);
            this.groupBoxServicio.Controls.Add(this.label3);
            this.groupBoxServicio.Controls.Add(this.label2);
            this.groupBoxServicio.Controls.Add(this.textBoxCantidad);
            this.groupBoxServicio.Controls.Add(this.label1);
            this.groupBoxServicio.Controls.Add(this.textBoxNombre);
            this.groupBoxServicio.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxServicio.Location = new System.Drawing.Point(44, 30);
            this.groupBoxServicio.Name = "groupBoxServicio";
            this.groupBoxServicio.Size = new System.Drawing.Size(1225, 249);
            this.groupBoxServicio.TabIndex = 17;
            this.groupBoxServicio.TabStop = false;
            this.groupBoxServicio.Text = "Datos Servicio";
            this.groupBoxServicio.Enter += new System.EventHandler(this.groupBoxServicio_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(895, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Disponibilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(250, 157);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(298, 39);
            this.textBoxCantidad.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(250, 63);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(298, 39);
            this.textBoxNombre.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 822);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 100);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1286, -810);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 913);
            this.panel2.TabIndex = 25;
            // 
            // FormServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1318, 934);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxServicio);
            this.Controls.Add(this.dataGridViewServicio);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "FormServicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio";
            this.Load += new System.EventHandler(this.FormServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicio)).EndInit();
            this.groupBoxServicio.ResumeLayout(false);
            this.groupBoxServicio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewServicio;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.GroupBox groupBoxServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}