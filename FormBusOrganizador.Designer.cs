namespace ProyectoFinalDB1
{
    partial class FormBusOrganizador
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
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewOrganizador = new System.Windows.Forms.DataGridView();
            this.dataGridViewInformacionP = new System.Windows.Forms.DataGridView();
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformacionP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido del organizador";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(98, 98);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(348, 39);
            this.textBoxApellido.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(98, 185);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(168, 39);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewOrganizador
            // 
            this.dataGridViewOrganizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrganizador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewOrganizador.Location = new System.Drawing.Point(595, 39);
            this.dataGridViewOrganizador.Name = "dataGridViewOrganizador";
            this.dataGridViewOrganizador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewOrganizador.RowTemplate.Height = 28;
            this.dataGridViewOrganizador.Size = new System.Drawing.Size(595, 185);
            this.dataGridViewOrganizador.TabIndex = 3;
            this.dataGridViewOrganizador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrganizador_CellContentClick);
            // 
            // dataGridViewInformacionP
            // 
            this.dataGridViewInformacionP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInformacionP.Location = new System.Drawing.Point(73, 317);
            this.dataGridViewInformacionP.Name = "dataGridViewInformacionP";
            this.dataGridViewInformacionP.RowHeadersWidth = 62;
            this.dataGridViewInformacionP.RowTemplate.Height = 28;
            this.dataGridViewInformacionP.Size = new System.Drawing.Size(1117, 150);
            this.dataGridViewInformacionP.TabIndex = 4;
            this.dataGridViewInformacionP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInformacionP_CellContentClick);
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Location = new System.Drawing.Point(73, 560);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.RowHeadersWidth = 62;
            this.dataGridViewEventos.RowTemplate.Height = 28;
            this.dataGridViewEventos.Size = new System.Drawing.Size(1117, 185);
            this.dataGridViewEventos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datos Personales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eventos Organizados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(595, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 43);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pasado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(718, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Futuro";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(819, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 43);
            this.panel2.TabIndex = 9;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(1022, 786);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(168, 39);
            this.buttonRegresar.TabIndex = 11;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // FormBusOrganizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 848);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewEventos);
            this.Controls.Add(this.dataGridViewInformacionP);
            this.Controls.Add(this.dataGridViewOrganizador);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label1);
            this.Name = "FormBusOrganizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Organizador";
            this.Load += new System.EventHandler(this.FormBusOrganizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrganizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformacionP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewOrganizador;
        private System.Windows.Forms.DataGridView dataGridViewInformacionP;
        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRegresar;
    }
}