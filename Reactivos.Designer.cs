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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificarReactivo = new System.Windows.Forms.Button();
            this.btnAñadirNewReact = new System.Windows.Forms.Button();
            this.btnMostrarreact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbReactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbReactivos
            // 
            this.grbReactivos.Controls.Add(this.dataGridView1);
            this.grbReactivos.Location = new System.Drawing.Point(507, 125);
            this.grbReactivos.Name = "grbReactivos";
            this.grbReactivos.Size = new System.Drawing.Size(1073, 714);
            this.grbReactivos.TabIndex = 2;
            this.grbReactivos.TabStop = false;
            this.grbReactivos.Text = "Visualizacion de inventario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 653);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnModificarReactivo);
            this.panel1.Controls.Add(this.btnAñadirNewReact);
            this.panel1.Controls.Add(this.btnMostrarreact);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 1024);
            this.panel1.TabIndex = 3;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(25, 982);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(103, 30);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnModificarReactivo
            // 
            this.btnModificarReactivo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarReactivo.Location = new System.Drawing.Point(83, 613);
            this.btnModificarReactivo.Name = "btnModificarReactivo";
            this.btnModificarReactivo.Size = new System.Drawing.Size(145, 55);
            this.btnModificarReactivo.TabIndex = 10;
            this.btnModificarReactivo.Text = "Modificar Reactivo";
            this.btnModificarReactivo.UseVisualStyleBackColor = true;
            // 
            // btnAñadirNewReact
            // 
            this.btnAñadirNewReact.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirNewReact.Location = new System.Drawing.Point(83, 479);
            this.btnAñadirNewReact.Name = "btnAñadirNewReact";
            this.btnAñadirNewReact.Size = new System.Drawing.Size(145, 56);
            this.btnAñadirNewReact.TabIndex = 9;
            this.btnAñadirNewReact.Text = "Añadir Nuevo Reactivo";
            this.btnAñadirNewReact.UseVisualStyleBackColor = true;
            // 
            // btnMostrarreact
            // 
            this.btnMostrarreact.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarreact.Location = new System.Drawing.Point(83, 362);
            this.btnMostrarreact.Name = "btnMostrarreact";
            this.btnMostrarreact.Size = new System.Drawing.Size(145, 56);
            this.btnMostrarreact.TabIndex = 8;
            this.btnMostrarreact.Text = "Mostrar Reactivos";
            this.btnMostrarreact.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(96, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "REACTIVOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zas_Sistema_Administrativo_y_Inventario.Properties.Resources.Zas_log;
            this.pictureBox1.Location = new System.Drawing.Point(100, 79);
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
            this.Name = "Reactivos";
            this.Text = "Form3";
            this.grbReactivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbReactivos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModificarReactivo;
        private System.Windows.Forms.Button btnAñadirNewReact;
        private System.Windows.Forms.Button btnMostrarreact;
        private System.Windows.Forms.Button btnRegresar;
    }
}