namespace ProyectoFinalDB1
{
    partial class FormPantallaAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButtonTipoSalon = new System.Windows.Forms.RadioButton();
            this.radioButtonSalon = new System.Windows.Forms.RadioButton();
            this.radioButtonServicio = new System.Windows.Forms.RadioButton();
            this.radioButtonPersona = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvido [ user ]";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.radioButtonTipoSalon);
            this.groupBox1.Controls.Add(this.radioButtonSalon);
            this.groupBox1.Controls.Add(this.radioButtonServicio);
            this.groupBox1.Controls.Add(this.radioButtonPersona);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrador";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(737, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Abrir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtonTipoSalon
            // 
            this.radioButtonTipoSalon.AutoSize = true;
            this.radioButtonTipoSalon.Location = new System.Drawing.Point(169, 50);
            this.radioButtonTipoSalon.Name = "radioButtonTipoSalon";
            this.radioButtonTipoSalon.Size = new System.Drawing.Size(76, 17);
            this.radioButtonTipoSalon.TabIndex = 4;
            this.radioButtonTipoSalon.TabStop = true;
            this.radioButtonTipoSalon.Text = "Tipo Salon";
            this.radioButtonTipoSalon.UseVisualStyleBackColor = true;
            this.radioButtonTipoSalon.CheckedChanged += new System.EventHandler(this.radioButtonTipoSalon_CheckedChanged);
            // 
            // radioButtonSalon
            // 
            this.radioButtonSalon.AutoSize = true;
            this.radioButtonSalon.Location = new System.Drawing.Point(19, 114);
            this.radioButtonSalon.Name = "radioButtonSalon";
            this.radioButtonSalon.Size = new System.Drawing.Size(52, 17);
            this.radioButtonSalon.TabIndex = 3;
            this.radioButtonSalon.Text = "Salon";
            this.radioButtonSalon.UseVisualStyleBackColor = true;
            this.radioButtonSalon.CheckedChanged += new System.EventHandler(this.radioButtonSalon_CheckedChanged);
            // 
            // radioButtonServicio
            // 
            this.radioButtonServicio.AutoSize = true;
            this.radioButtonServicio.Location = new System.Drawing.Point(95, 50);
            this.radioButtonServicio.Name = "radioButtonServicio";
            this.radioButtonServicio.Size = new System.Drawing.Size(68, 17);
            this.radioButtonServicio.TabIndex = 2;
            this.radioButtonServicio.TabStop = true;
            this.radioButtonServicio.Text = "Servicios";
            this.radioButtonServicio.UseVisualStyleBackColor = true;
            this.radioButtonServicio.CheckedChanged += new System.EventHandler(this.radioButtonServicio_CheckedChanged);
            // 
            // radioButtonPersona
            // 
            this.radioButtonPersona.AutoSize = true;
            this.radioButtonPersona.Checked = true;
            this.radioButtonPersona.Location = new System.Drawing.Point(19, 50);
            this.radioButtonPersona.Name = "radioButtonPersona";
            this.radioButtonPersona.Size = new System.Drawing.Size(69, 17);
            this.radioButtonPersona.TabIndex = 1;
            this.radioButtonPersona.TabStop = true;
            this.radioButtonPersona.Text = "Personas";
            this.radioButtonPersona.UseVisualStyleBackColor = true;
            this.radioButtonPersona.CheckedChanged += new System.EventHandler(this.radioButtonPersona_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tablas Fuertes:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(729, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar Sesión...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(732, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalDB1.Properties.Resources.profile_circle_icon_242774;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proyecto DB - SQLServer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tablas Debiles:";
            // 
            // FormPantallaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(862, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormPantallaAdmin";
            this.Text = "Aplicación - user";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPantallaAdmin_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonServicio;
        private System.Windows.Forms.RadioButton radioButtonPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonTipoSalon;
        private System.Windows.Forms.RadioButton radioButtonSalon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}