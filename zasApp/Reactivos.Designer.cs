namespace Zas_Sistema_Administrativo_y_Inventario
{
    partial class Reactivos
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
            this.grbReactivos = new System.Windows.Forms.GroupBox();
            this.dtgvReactivos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReporteReactivo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificarReactivo = new System.Windows.Forms.Button();
            this.btnAnadirNewReact = new System.Windows.Forms.Button();
            this.btnMostrarreact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbReactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReactivos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbReactivos
            // 
            this.grbReactivos.Controls.Add(this.dtgvReactivos);
            this.grbReactivos.Location = new System.Drawing.Point(507, 126);
            this.grbReactivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbReactivos.Name = "grbReactivos";
            this.grbReactivos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbReactivos.Size = new System.Drawing.Size(1073, 714);
            this.grbReactivos.TabIndex = 2;
            this.grbReactivos.TabStop = false;
            this.grbReactivos.Text = "Visualizacion de inventario";
            // 
            // dtgvReactivos
            // 
            this.dtgvReactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReactivos.Location = new System.Drawing.Point(21, 34);
            this.dtgvReactivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvReactivos.Name = "dtgvReactivos";
            this.dtgvReactivos.RowHeadersWidth = 51;
            this.dtgvReactivos.RowTemplate.Height = 24;
            this.dtgvReactivos.Size = new System.Drawing.Size(1017, 654);
            this.dtgvReactivos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnReporteReactivo);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnModificarReactivo);
            this.panel1.Controls.Add(this.btnAnadirNewReact);
            this.panel1.Controls.Add(this.btnMostrarreact);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 1024);
            this.panel1.TabIndex = 3;
            // 
            // btnReporteReactivo
            // 
            this.btnReporteReactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteReactivo.Location = new System.Drawing.Point(83, 730);
            this.btnReporteReactivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteReactivo.Name = "btnReporteReactivo";
            this.btnReporteReactivo.Size = new System.Drawing.Size(145, 55);
            this.btnReporteReactivo.TabIndex = 12;
            this.btnReporteReactivo.Text = "Generar Reporte";
            this.btnReporteReactivo.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(27, 866);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(125, 41);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificarReactivo
            // 
            this.btnModificarReactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarReactivo.Location = new System.Drawing.Point(83, 613);
            this.btnModificarReactivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarReactivo.Name = "btnModificarReactivo";
            this.btnModificarReactivo.Size = new System.Drawing.Size(145, 55);
            this.btnModificarReactivo.TabIndex = 10;
            this.btnModificarReactivo.Text = "Modificar Reactivo";
            this.btnModificarReactivo.UseVisualStyleBackColor = true;
            this.btnModificarReactivo.Click += new System.EventHandler(this.btnModificarReactivo_Click);
            // 
            // btnAnadirNewReact
            // 
            this.btnAnadirNewReact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirNewReact.Location = new System.Drawing.Point(83, 479);
            this.btnAnadirNewReact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnadirNewReact.Name = "btnAnadirNewReact";
            this.btnAnadirNewReact.Size = new System.Drawing.Size(145, 57);
            this.btnAnadirNewReact.TabIndex = 9;
            this.btnAnadirNewReact.Text = "Añadir Nuevo Reactivo";
            this.btnAnadirNewReact.UseVisualStyleBackColor = true;
            this.btnAnadirNewReact.Click += new System.EventHandler(this.btnAnadirNewReact_Click);
            // 
            // btnMostrarreact
            // 
            this.btnMostrarreact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarreact.Location = new System.Drawing.Point(83, 362);
            this.btnMostrarreact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarreact.Name = "btnMostrarreact";
            this.btnMostrarreact.Size = new System.Drawing.Size(145, 57);
            this.btnMostrarreact.TabIndex = 8;
            this.btnMostrarreact.Text = "Mostrar Reactivos";
            this.btnMostrarreact.UseVisualStyleBackColor = true;
            this.btnMostrarreact.Click += new System.EventHandler(this.btnMostrarreact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(96, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "REACTIVOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zas_Sistema_Administrativo_y_Inventario.Properties.Resources.Zas_log;
            this.pictureBox1.Location = new System.Drawing.Point(100, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Reactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 1019);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbReactivos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reactivos";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Reactivos_Load);
            this.grbReactivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReactivos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbReactivos;
        private System.Windows.Forms.DataGridView dtgvReactivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModificarReactivo;
        private System.Windows.Forms.Button btnAnadirNewReact;
        private System.Windows.Forms.Button btnMostrarreact;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnReporteReactivo;
    }
}