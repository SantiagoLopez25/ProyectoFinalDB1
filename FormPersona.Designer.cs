﻿namespace ProyectoFinalDB1
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
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonActivo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.dataGridViewPersona = new System.Windows.Forms.DataGridView();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.groupBoxPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPersona
            // 
            this.groupBoxPersona.Controls.Add(this.comboBoxEmail);
            this.groupBoxPersona.Controls.Add(this.label4);
            this.groupBoxPersona.Controls.Add(this.radioButtonActivo);
            this.groupBoxPersona.Controls.Add(this.label3);
            this.groupBoxPersona.Controls.Add(this.label2);
            this.groupBoxPersona.Controls.Add(this.textBoxTelefono);
            this.groupBoxPersona.Controls.Add(this.label1);
            this.groupBoxPersona.Controls.Add(this.textBoxNombre);
            this.groupBoxPersona.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPersona.Location = new System.Drawing.Point(48, 56);
            this.groupBoxPersona.Name = "groupBoxPersona";
            this.groupBoxPersona.Size = new System.Drawing.Size(1225, 249);
            this.groupBoxPersona.TabIndex = 10;
            this.groupBoxPersona.TabStop = false;
            this.groupBoxPersona.Text = "Datos Persona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(674, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // radioButtonActivo
            // 
            this.radioButtonActivo.AutoSize = true;
            this.radioButtonActivo.Location = new System.Drawing.Point(937, 80);
            this.radioButtonActivo.Name = "radioButtonActivo";
            this.radioButtonActivo.Size = new System.Drawing.Size(21, 20);
            this.radioButtonActivo.TabIndex = 15;
            this.radioButtonActivo.TabStop = true;
            this.radioButtonActivo.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(102, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(250, 157);
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
            this.buttonNuevo.Location = new System.Drawing.Point(48, 339);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(148, 80);
            this.buttonNuevo.TabIndex = 11;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(334, 339);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(148, 80);
            this.buttonGuardar.TabIndex = 12;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(607, 339);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(148, 80);
            this.buttonEditar.TabIndex = 13;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(1125, 339);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(148, 80);
            this.buttonEliminar.TabIndex = 14;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListar.Location = new System.Drawing.Point(862, 339);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(148, 80);
            this.buttonListar.TabIndex = 15;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPersona
            // 
            this.dataGridViewPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersona.Location = new System.Drawing.Point(48, 474);
            this.dataGridViewPersona.Name = "dataGridViewPersona";
            this.dataGridViewPersona.RowHeadersWidth = 62;
            this.dataGridViewPersona.RowTemplate.Height = 28;
            this.dataGridViewPersona.Size = new System.Drawing.Size(1225, 348);
            this.dataGridViewPersona.TabIndex = 16;
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(797, 157);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(298, 40);
            this.comboBoxEmail.TabIndex = 18;
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 844);
            this.Controls.Add(this.dataGridViewPersona);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.groupBoxPersona);
            this.Name = "FormPersona";
            this.Text = "Persona";
            this.groupBoxPersona.ResumeLayout(false);
            this.groupBoxPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxPersona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonActivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.DataGridView dataGridViewPersona;
        private System.Windows.Forms.ComboBox comboBoxEmail;
    }
}