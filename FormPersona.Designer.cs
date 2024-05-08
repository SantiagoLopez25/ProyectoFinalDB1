namespace ProyectoFinalDB1
{
    partial class FormPersona
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxPersona = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridViewPersona = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersona
            // 
            this.groupBoxPersona.Controls.Add(this.checkBox1);
            this.groupBoxPersona.Controls.Add(this.txtApellido);
            this.groupBoxPersona.Controls.Add(this.label4);
            this.groupBoxPersona.Controls.Add(this.label3);
            this.groupBoxPersona.Controls.Add(this.label2);
            this.groupBoxPersona.Controls.Add(this.textBoxTelefono);
            this.groupBoxPersona.Controls.Add(this.label1);
            this.groupBoxPersona.Controls.Add(this.textBoxNombre);
            this.groupBoxPersona.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPersona.Location = new System.Drawing.Point(48, 34);
            this.groupBoxPersona.Name = "groupBoxPersona";
            this.groupBoxPersona.Size = new System.Drawing.Size(1225, 249);
            this.groupBoxPersona.TabIndex = 10;
            this.groupBoxPersona.TabStop = false;
            this.groupBoxPersona.Text = "Datos Persona";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(912, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(250, 163);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(298, 39);
            this.txtApellido.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Apellido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Activo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(784, 163);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(298, 39);
            this.textBoxTelefono.TabIndex = 12;
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
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Location = new System.Drawing.Point(48, 325);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(148, 80);
            this.buttonNuevo.TabIndex = 11;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(391, 325);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(148, 80);
            this.buttonGuardar.TabIndex = 12;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(797, 325);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(148, 80);
            this.buttonEditar.TabIndex = 13;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(1125, 325);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(148, 80);
            this.buttonEliminar.TabIndex = 14;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPersona
            // 
            this.dataGridViewPersona.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewPersona.Location = new System.Drawing.Point(48, 456);
            this.dataGridViewPersona.Name = "dataGridViewPersona";
            this.dataGridViewPersona.RowHeadersWidth = 62;
            this.dataGridViewPersona.RowTemplate.Height = 28;
            this.dataGridViewPersona.Size = new System.Drawing.Size(1225, 313);
            this.dataGridViewPersona.TabIndex = 16;
            this.dataGridViewPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersona_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxPersona);
            this.panel1.Controls.Add(this.dataGridViewPersona);
            this.panel1.Controls.Add(this.buttonNuevo);
            this.panel1.Controls.Add(this.buttonGuardar);
            this.panel1.Controls.Add(this.buttonEliminar);
            this.panel1.Controls.Add(this.buttonEditar);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 900);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1318, 845);
            this.Controls.Add(this.panel1);
            this.Name = "FormPersona";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.FormPersona_Load);
            this.groupBoxPersona.ResumeLayout(false);
            this.groupBoxPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridView dataGridViewPersona;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}