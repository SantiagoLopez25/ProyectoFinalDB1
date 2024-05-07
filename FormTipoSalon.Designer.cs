namespace ProyectoFinalDB1
{
    partial class FormTipoSalon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.dataGridViewTipoSalon = new System.Windows.Forms.DataGridView();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoSalon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBoxTipo);
            this.panel1.Controls.Add(this.dataGridViewTipoSalon);
            this.panel1.Controls.Add(this.buttonNuevo);
            this.panel1.Controls.Add(this.buttonGuardar);
            this.panel1.Controls.Add(this.buttonEliminar);
            this.panel1.Controls.Add(this.buttonEditar);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 900);
            this.panel1.TabIndex = 18;
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.label1);
            this.groupBoxTipo.Controls.Add(this.textBoxNombre);
            this.groupBoxTipo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTipo.Location = new System.Drawing.Point(48, 34);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(1225, 249);
            this.groupBoxTipo.TabIndex = 10;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo de salón";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(253, 65);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(817, 39);
            this.textBoxNombre.TabIndex = 10;
            // 
            // dataGridViewTipoSalon
            // 
            this.dataGridViewTipoSalon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTipoSalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipoSalon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewTipoSalon.Location = new System.Drawing.Point(48, 456);
            this.dataGridViewTipoSalon.Name = "dataGridViewTipoSalon";
            this.dataGridViewTipoSalon.RowHeadersWidth = 62;
            this.dataGridViewTipoSalon.RowTemplate.Height = 28;
            this.dataGridViewTipoSalon.Size = new System.Drawing.Size(1225, 313);
            this.dataGridViewTipoSalon.TabIndex = 16;
            this.dataGridViewTipoSalon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTipoSalon_CellContentClick);
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
            this.buttonGuardar.Location = new System.Drawing.Point(418, 325);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(148, 80);
            this.buttonGuardar.TabIndex = 12;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
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
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(782, 325);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(148, 80);
            this.buttonEditar.TabIndex = 13;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // FormTipoSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 844);
            this.Controls.Add(this.panel1);
            this.Name = "FormTipoSalon";
            this.ShowIcon = false;
            this.Text = "Tipo de salón";
            this.Load += new System.EventHandler(this.FormTipoSalon_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoSalon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewTipoSalon;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}