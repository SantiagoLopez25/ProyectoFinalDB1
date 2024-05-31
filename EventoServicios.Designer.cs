namespace ProyectoFinalDB1
{
    partial class EventoServicios
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewEventoServicio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(79, 26);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(291, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(79, 52);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(209, 20);
            this.textBoxCantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewEventoServicio
            // 
            this.dataGridViewEventoServicio.AllowUserToDeleteRows = false;
            this.dataGridViewEventoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventoServicio.Location = new System.Drawing.Point(16, 92);
            this.dataGridViewEventoServicio.Name = "dataGridViewEventoServicio";
            this.dataGridViewEventoServicio.ReadOnly = true;
            this.dataGridViewEventoServicio.Size = new System.Drawing.Size(786, 150);
            this.dataGridViewEventoServicio.TabIndex = 5;
            this.dataGridViewEventoServicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEventoServicio_CellClick);
            // 
            // EventoServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 273);
            this.Controls.Add(this.dataGridViewEventoServicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Name = "EventoServicios";
            this.Text = "EventoServicios";
            this.Load += new System.EventHandler(this.EventoServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewEventoServicio;
    }
}