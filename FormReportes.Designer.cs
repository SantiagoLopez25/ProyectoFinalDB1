namespace ProyectoFinalDB1
{
    partial class FormReportes
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
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButtonFecha = new System.Windows.Forms.RadioButton();
            this.radioButtonCalendarizacion = new System.Windows.Forms.RadioButton();
            this.radioButtonApellido = new System.Windows.Forms.RadioButton();
            this.radioButtonEspacios = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.Location = new System.Drawing.Point(1156, 46);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(177, 40);
            this.buttonCerrarSesion.TabIndex = 4;
            this.buttonCerrarSesion.Text = "Cerrar Sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Proyecto DB - SQLServer";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(241, 46);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(241, 33);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Bienvido [ user ]";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.radioButtonFecha);
            this.groupBox1.Controls.Add(this.radioButtonCalendarizacion);
            this.groupBox1.Controls.Add(this.radioButtonApellido);
            this.groupBox1.Controls.Add(this.radioButtonEspacios);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 198);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1257, 416);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Director";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1094, 310);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Abrir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtonFecha
            // 
            this.radioButtonFecha.AutoSize = true;
            this.radioButtonFecha.Location = new System.Drawing.Point(422, 88);
            this.radioButtonFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonFecha.Name = "radioButtonFecha";
            this.radioButtonFecha.Size = new System.Drawing.Size(216, 36);
            this.radioButtonFecha.TabIndex = 4;
            this.radioButtonFecha.TabStop = true;
            this.radioButtonFecha.Text = "Buscar por fecha";
            this.radioButtonFecha.UseVisualStyleBackColor = true;
            this.radioButtonFecha.CheckedChanged += new System.EventHandler(this.radioButtonFecha_CheckedChanged);
            // 
            // radioButtonCalendarizacion
            // 
            this.radioButtonCalendarizacion.AutoSize = true;
            this.radioButtonCalendarizacion.Location = new System.Drawing.Point(28, 189);
            this.radioButtonCalendarizacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCalendarizacion.Name = "radioButtonCalendarizacion";
            this.radioButtonCalendarizacion.Size = new System.Drawing.Size(207, 36);
            this.radioButtonCalendarizacion.TabIndex = 3;
            this.radioButtonCalendarizacion.Text = "Calendarización";
            this.radioButtonCalendarizacion.UseVisualStyleBackColor = true;
            this.radioButtonCalendarizacion.CheckedChanged += new System.EventHandler(this.radioButtonCalendarizacion_CheckedChanged);
            // 
            // radioButtonApellido
            // 
            this.radioButtonApellido.AutoSize = true;
            this.radioButtonApellido.Location = new System.Drawing.Point(171, 88);
            this.radioButtonApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonApellido.Name = "radioButtonApellido";
            this.radioButtonApellido.Size = new System.Drawing.Size(243, 36);
            this.radioButtonApellido.TabIndex = 2;
            this.radioButtonApellido.TabStop = true;
            this.radioButtonApellido.Text = "Buscar por apellido";
            this.radioButtonApellido.UseVisualStyleBackColor = true;
            this.radioButtonApellido.CheckedChanged += new System.EventHandler(this.radioButtonApellido_CheckedChanged);
            // 
            // radioButtonEspacios
            // 
            this.radioButtonEspacios.AutoSize = true;
            this.radioButtonEspacios.Checked = true;
            this.radioButtonEspacios.Location = new System.Drawing.Point(28, 88);
            this.radioButtonEspacios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonEspacios.Name = "radioButtonEspacios";
            this.radioButtonEspacios.Size = new System.Drawing.Size(128, 36);
            this.radioButtonEspacios.TabIndex = 1;
            this.radioButtonEspacios.TabStop = true;
            this.radioButtonEspacios.Text = "Espacios";
            this.radioButtonEspacios.UseVisualStyleBackColor = true;
            this.radioButtonEspacios.CheckedChanged += new System.EventHandler(this.radioButtonEspacios_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reportes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalDB1.Properties.Resources.profile_circle_icon_242774;
            this.pictureBox1.Location = new System.Drawing.Point(40, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(1134, 673);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(142, 44);
            this.buttonSalir.TabIndex = 10;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 747);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.buttonCerrarSesion);
            this.Name = "FormReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButtonFecha;
        private System.Windows.Forms.RadioButton radioButtonCalendarizacion;
        private System.Windows.Forms.RadioButton radioButtonApellido;
        private System.Windows.Forms.RadioButton radioButtonEspacios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalir;
    }
}