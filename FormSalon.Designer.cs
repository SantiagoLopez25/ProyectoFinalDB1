namespace ProyectoFinalDB1
{
    partial class FormSalon
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
            this.dataGridViewSalon = new System.Windows.Forms.DataGridView();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.groupBoxSalon = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonDisponibilidad = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxTamannio = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoSalon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalon)).BeginInit();
            this.groupBoxSalon.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSalon
            // 
            this.dataGridViewSalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalon.Location = new System.Drawing.Point(46, 487);
            this.dataGridViewSalon.Name = "dataGridViewSalon";
            this.dataGridViewSalon.RowHeadersWidth = 62;
            this.dataGridViewSalon.RowTemplate.Height = 28;
            this.dataGridViewSalon.Size = new System.Drawing.Size(1225, 320);
            this.dataGridViewSalon.TabIndex = 23;
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListar.Location = new System.Drawing.Point(860, 357);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(148, 80);
            this.buttonListar.TabIndex = 22;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(1123, 357);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(148, 80);
            this.buttonEliminar.TabIndex = 21;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(605, 357);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(148, 80);
            this.buttonEditar.TabIndex = 20;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(332, 357);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(148, 80);
            this.buttonGuardar.TabIndex = 19;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Location = new System.Drawing.Point(46, 357);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(148, 80);
            this.buttonNuevo.TabIndex = 18;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // groupBoxSalon
            // 
            this.groupBoxSalon.Controls.Add(this.label5);
            this.groupBoxSalon.Controls.Add(this.textBoxDireccion);
            this.groupBoxSalon.Controls.Add(this.comboBoxTipoSalon);
            this.groupBoxSalon.Controls.Add(this.comboBoxTamannio);
            this.groupBoxSalon.Controls.Add(this.label4);
            this.groupBoxSalon.Controls.Add(this.radioButtonDisponibilidad);
            this.groupBoxSalon.Controls.Add(this.label3);
            this.groupBoxSalon.Controls.Add(this.label2);
            this.groupBoxSalon.Controls.Add(this.label1);
            this.groupBoxSalon.Controls.Add(this.textBoxNombre);
            this.groupBoxSalon.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSalon.Location = new System.Drawing.Point(46, 41);
            this.groupBoxSalon.Name = "groupBoxSalon";
            this.groupBoxSalon.Size = new System.Drawing.Size(1225, 281);
            this.groupBoxSalon.TabIndex = 17;
            this.groupBoxSalon.TabStop = false;
            this.groupBoxSalon.Text = "Datos Salón";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo";
            // 
            // radioButtonDisponibilidad
            // 
            this.radioButtonDisponibilidad.AutoSize = true;
            this.radioButtonDisponibilidad.Location = new System.Drawing.Point(984, 77);
            this.radioButtonDisponibilidad.Name = "radioButtonDisponibilidad";
            this.radioButtonDisponibilidad.Size = new System.Drawing.Size(21, 20);
            this.radioButtonDisponibilidad.TabIndex = 15;
            this.radioButtonDisponibilidad.TabStop = true;
            this.radioButtonDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Disponibilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tamaño";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(176, 58);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(298, 39);
            this.textBoxNombre.TabIndex = 10;
            // 
            // comboBoxTamannio
            // 
            this.comboBoxTamannio.FormattingEnabled = true;
            this.comboBoxTamannio.Items.AddRange(new object[] {
            "Grande",
            "Mediano",
            "Pequeño"});
            this.comboBoxTamannio.Location = new System.Drawing.Point(176, 152);
            this.comboBoxTamannio.Name = "comboBoxTamannio";
            this.comboBoxTamannio.Size = new System.Drawing.Size(298, 40);
            this.comboBoxTamannio.TabIndex = 18;
            // 
            // comboBoxTipoSalon
            // 
            this.comboBoxTipoSalon.FormattingEnabled = true;
            this.comboBoxTipoSalon.Items.AddRange(new object[] {
            "Grande",
            "Mediano",
            "Pequeño"});
            this.comboBoxTipoSalon.Location = new System.Drawing.Point(842, 146);
            this.comboBoxTipoSalon.Name = "comboBoxTipoSalon";
            this.comboBoxTipoSalon.Size = new System.Drawing.Size(298, 40);
            this.comboBoxTipoSalon.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Direción";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.Location = new System.Drawing.Point(176, 226);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(964, 39);
            this.textBoxDireccion.TabIndex = 20;
            // 
            // FormSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 844);
            this.Controls.Add(this.dataGridViewSalon);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.groupBoxSalon);
            this.Name = "FormSalon";
            this.Text = "Salón";
            this.Load += new System.EventHandler(this.FormSalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalon)).EndInit();
            this.groupBoxSalon.ResumeLayout(false);
            this.groupBoxSalon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSalon;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.GroupBox groupBoxSalon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonDisponibilidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxTipoSalon;
        private System.Windows.Forms.ComboBox comboBoxTamannio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDireccion;
    }
}