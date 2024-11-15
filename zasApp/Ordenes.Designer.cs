namespace Zas_Sistema_Administrativo_y_Inventario
{
    partial class Ordenes
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
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificarOrden = new System.Windows.Forms.Button();
            this.btnAñadirOrdenes = new System.Windows.Forms.Button();
            this.btnMostrarOrdenes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbOrdenes = new System.Windows.Forms.GroupBox();
            this.dtgvOrdenes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnModificarOrden);
            this.panel1.Controls.Add(this.btnAñadirOrdenes);
            this.panel1.Controls.Add(this.btnMostrarOrdenes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 1010);
            this.panel1.TabIndex = 5;
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(101, 635);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(145, 55);
            this.btnReporte.TabIndex = 12;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(32, 942);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(103, 30);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificarOrden
            // 
            this.btnModificarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarOrden.Location = new System.Drawing.Point(101, 533);
            this.btnModificarOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarOrden.Name = "btnModificarOrden";
            this.btnModificarOrden.Size = new System.Drawing.Size(145, 55);
            this.btnModificarOrden.TabIndex = 10;
            this.btnModificarOrden.Text = "Modificar Ordenes\r\n";
            this.btnModificarOrden.UseVisualStyleBackColor = true;
            this.btnModificarOrden.Click += new System.EventHandler(this.btnModificarOrden_Click);
            // 
            // btnAñadirOrdenes
            // 
            this.btnAñadirOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirOrdenes.Location = new System.Drawing.Point(101, 423);
            this.btnAñadirOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirOrdenes.Name = "btnAñadirOrdenes";
            this.btnAñadirOrdenes.Size = new System.Drawing.Size(145, 57);
            this.btnAñadirOrdenes.TabIndex = 9;
            this.btnAñadirOrdenes.Text = "Añadir Nuevas Ordenes\r\n";
            this.btnAñadirOrdenes.UseVisualStyleBackColor = true;
            this.btnAñadirOrdenes.Click += new System.EventHandler(this.btnAñadirOrdenes_Click);
            // 
            // btnMostrarOrdenes
            // 
            this.btnMostrarOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarOrdenes.Location = new System.Drawing.Point(101, 306);
            this.btnMostrarOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarOrdenes.Name = "btnMostrarOrdenes";
            this.btnMostrarOrdenes.Size = new System.Drawing.Size(145, 57);
            this.btnMostrarOrdenes.TabIndex = 8;
            this.btnMostrarOrdenes.Text = "Mostrar Ordenes";
            this.btnMostrarOrdenes.UseVisualStyleBackColor = true;
            this.btnMostrarOrdenes.Click += new System.EventHandler(this.btnMostrarOrdenes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(127, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ordenes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zas_Sistema_Administrativo_y_Inventario.Properties.Resources.Zas_log;
            this.pictureBox1.Location = new System.Drawing.Point(117, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbOrdenes
            // 
            this.grbOrdenes.Controls.Add(this.dtgvOrdenes);
            this.grbOrdenes.Location = new System.Drawing.Point(676, 225);
            this.grbOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbOrdenes.Name = "grbOrdenes";
            this.grbOrdenes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbOrdenes.Size = new System.Drawing.Size(883, 558);
            this.grbOrdenes.TabIndex = 6;
            this.grbOrdenes.TabStop = false;
            this.grbOrdenes.Text = "Vizualizacion de Ordenes";
            // 
            // dtgvOrdenes
            // 
            this.dtgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrdenes.Location = new System.Drawing.Point(49, 62);
            this.dtgvOrdenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvOrdenes.Name = "dtgvOrdenes";
            this.dtgvOrdenes.RowHeadersWidth = 51;
            this.dtgvOrdenes.RowTemplate.Height = 24;
            this.dtgvOrdenes.Size = new System.Drawing.Size(800, 453);
            this.dtgvOrdenes.TabIndex = 0;
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 1008);
            this.Controls.Add(this.grbOrdenes);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ordenes";
            this.Text = "Ordenes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbOrdenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificarOrden;
        private System.Windows.Forms.Button btnAñadirOrdenes;
        private System.Windows.Forms.Button btnMostrarOrdenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbOrdenes;
        private System.Windows.Forms.DataGridView dtgvOrdenes;
        private System.Windows.Forms.Button btnReporte;
    }
}