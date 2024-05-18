namespace ProyectoFinalDB1
{
    partial class FormDigitador
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxResponsable = new System.Windows.Forms.GroupBox();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTipoEvento = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxSalon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxServicios = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewServicio = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxResponsable = new System.Windows.Forms.TextBox();
            this.dataGridViewSalon = new System.Windows.Forms.DataGridView();
            this.dataGridViewPersona = new System.Windows.Forms.DataGridView();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAsistentes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxResponsable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewEventos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 803);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eventos Registrados:";
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Location = new System.Drawing.Point(12, 242);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.Size = new System.Drawing.Size(240, 433);
            this.dataGridViewEventos.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBoxResponsable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(274, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 803);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxDescripcion);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 589);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(974, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otros";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(130, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 47);
            this.button4.TabIndex = 1;
            this.button4.Text = "Guardar Evento";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 47);
            this.button3.TabIndex = 0;
            this.button3.Text = "Nuevo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBoxResponsable
            // 
            this.groupBoxResponsable.Controls.Add(this.dateTimeFinal);
            this.groupBoxResponsable.Controls.Add(this.dateTimeInicio);
            this.groupBoxResponsable.Controls.Add(this.comboBoxTipoEvento);
            this.groupBoxResponsable.Controls.Add(this.label16);
            this.groupBoxResponsable.Controls.Add(this.textBoxCantidad);
            this.groupBoxResponsable.Controls.Add(this.label15);
            this.groupBoxResponsable.Controls.Add(this.textBoxSalon);
            this.groupBoxResponsable.Controls.Add(this.label14);
            this.groupBoxResponsable.Controls.Add(this.comboBoxServicios);
            this.groupBoxResponsable.Controls.Add(this.label13);
            this.groupBoxResponsable.Controls.Add(this.button1);
            this.groupBoxResponsable.Controls.Add(this.dataGridViewServicio);
            this.groupBoxResponsable.Controls.Add(this.label12);
            this.groupBoxResponsable.Controls.Add(this.textBoxResponsable);
            this.groupBoxResponsable.Controls.Add(this.dataGridViewSalon);
            this.groupBoxResponsable.Controls.Add(this.dataGridViewPersona);
            this.groupBoxResponsable.Controls.Add(this.dateTimePickerFinal);
            this.groupBoxResponsable.Controls.Add(this.label9);
            this.groupBoxResponsable.Controls.Add(this.label10);
            this.groupBoxResponsable.Controls.Add(this.label11);
            this.groupBoxResponsable.Controls.Add(this.dateTimePickerInicio);
            this.groupBoxResponsable.Controls.Add(this.label8);
            this.groupBoxResponsable.Controls.Add(this.label7);
            this.groupBoxResponsable.Controls.Add(this.label6);
            this.groupBoxResponsable.Controls.Add(this.textBoxAsistentes);
            this.groupBoxResponsable.Controls.Add(this.label5);
            this.groupBoxResponsable.Controls.Add(this.label4);
            this.groupBoxResponsable.Controls.Add(this.label3);
            this.groupBoxResponsable.Controls.Add(this.label2);
            this.groupBoxResponsable.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxResponsable.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResponsable.Name = "groupBoxResponsable";
            this.groupBoxResponsable.Size = new System.Drawing.Size(974, 589);
            this.groupBoxResponsable.TabIndex = 0;
            this.groupBoxResponsable.TabStop = false;
            this.groupBoxResponsable.Text = "Nuevo Evento";
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeFinal.Location = new System.Drawing.Point(56, 529);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(92, 20);
            this.dateTimeFinal.TabIndex = 2;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeInicio.Location = new System.Drawing.Point(56, 453);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(92, 20);
            this.dateTimeInicio.TabIndex = 3;
            // 
            // comboBoxTipoEvento
            // 
            this.comboBoxTipoEvento.FormattingEnabled = true;
            this.comboBoxTipoEvento.Location = new System.Drawing.Point(86, 77);
            this.comboBoxTipoEvento.Name = "comboBoxTipoEvento";
            this.comboBoxTipoEvento.Size = new System.Drawing.Size(304, 21);
            this.comboBoxTipoEvento.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "TipoEvento";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(776, 452);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(173, 20);
            this.textBoxCantidad.TabIndex = 39;
            this.textBoxCantidad.Text = "50";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(773, 427);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Cantidad;";
            // 
            // textBoxSalon
            // 
            this.textBoxSalon.Location = new System.Drawing.Point(673, 48);
            this.textBoxSalon.Name = "textBoxSalon";
            this.textBoxSalon.Size = new System.Drawing.Size(276, 20);
            this.textBoxSalon.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(630, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Salon:";
            // 
            // comboBoxServicios
            // 
            this.comboBoxServicios.FormattingEnabled = true;
            this.comboBoxServicios.Location = new System.Drawing.Point(524, 81);
            this.comboBoxServicios.Name = "comboBoxServicios";
            this.comboBoxServicios.Size = new System.Drawing.Size(425, 21);
            this.comboBoxServicios.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(440, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Servicios:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewServicio
            // 
            this.dataGridViewServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicio.Location = new System.Drawing.Point(443, 427);
            this.dataGridViewServicio.Name = "dataGridViewServicio";
            this.dataGridViewServicio.Size = new System.Drawing.Size(323, 125);
            this.dataGridViewServicio.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Servicios:";
            // 
            // textBoxResponsable
            // 
            this.textBoxResponsable.Location = new System.Drawing.Point(86, 51);
            this.textBoxResponsable.Name = "textBoxResponsable";
            this.textBoxResponsable.Size = new System.Drawing.Size(304, 20);
            this.textBoxResponsable.TabIndex = 30;
            // 
            // dataGridViewSalon
            // 
            this.dataGridViewSalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalon.Location = new System.Drawing.Point(443, 161);
            this.dataGridViewSalon.Name = "dataGridViewSalon";
            this.dataGridViewSalon.Size = new System.Drawing.Size(506, 222);
            this.dataGridViewSalon.TabIndex = 29;
            this.dataGridViewSalon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalon_CellContentClick);
            // 
            // dataGridViewPersona
            // 
            this.dataGridViewPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersona.Location = new System.Drawing.Point(9, 161);
            this.dataGridViewPersona.Name = "dataGridViewPersona";
            this.dataGridViewPersona.Size = new System.Drawing.Size(381, 222);
            this.dataGridViewPersona.TabIndex = 28;
            this.dataGridViewPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersona_CellContentClick_1);
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(200, 532);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerFinal.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 536);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Fecha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 532);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Hora:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 506);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fin evento:";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(200, 452);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerInicio.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Inicio Evento:";
            // 
            // textBoxAsistentes
            // 
            this.textBoxAsistentes.Location = new System.Drawing.Point(524, 48);
            this.textBoxAsistentes.Name = "textBoxAsistentes";
            this.textBoxAsistentes.Size = new System.Drawing.Size(92, 20);
            this.textBoxAsistentes.TabIndex = 16;
            this.textBoxAsistentes.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "No. Asistentes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Salon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Responsables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personas:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(266, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Descripcion:";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(269, 48);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(693, 104);
            this.richTextBoxDescripcion.TabIndex = 3;
            this.richTextBoxDescripcion.Text = "";
            // 
            // FormDigitador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 803);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDigitador";
            this.Text = "FormDigitador";
            this.Load += new System.EventHandler(this.FormDigitador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxResponsable.ResumeLayout(false);
            this.groupBoxResponsable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxResponsable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAsistentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewPersona;
        private System.Windows.Forms.DataGridView dataGridViewSalon;
        private System.Windows.Forms.TextBox textBoxResponsable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewServicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxServicios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSalon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxTipoEvento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.DateTimePicker dateTimeFinal;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
    }
}