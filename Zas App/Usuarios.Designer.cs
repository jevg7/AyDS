namespace Zas_Sistema_Administrativo_y_Inventario
{
    partial class Usuarios
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificarEquip = new System.Windows.Forms.Button();
            this.btnAñadirUsuario = new System.Windows.Forms.Button();
            this.btnMostrarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbUsuarios = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnModificarEquip);
            this.panel1.Controls.Add(this.btnAñadirUsuario);
            this.panel1.Controls.Add(this.btnMostrarUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 1025);
            this.panel1.TabIndex = 5;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(36, 926);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(103, 30);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnModificarEquip
            // 
            this.btnModificarEquip.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEquip.Location = new System.Drawing.Point(110, 555);
            this.btnModificarEquip.Name = "btnModificarEquip";
            this.btnModificarEquip.Size = new System.Drawing.Size(145, 55);
            this.btnModificarEquip.TabIndex = 10;
            this.btnModificarEquip.Text = "Modificar Usuario\r\n";
            this.btnModificarEquip.UseVisualStyleBackColor = true;
            // 
            // btnAñadirUsuario
            // 
            this.btnAñadirUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirUsuario.Location = new System.Drawing.Point(110, 438);
            this.btnAñadirUsuario.Name = "btnAñadirUsuario";
            this.btnAñadirUsuario.Size = new System.Drawing.Size(145, 56);
            this.btnAñadirUsuario.TabIndex = 9;
            this.btnAñadirUsuario.Text = "Añadir Nuevo Usuario\r\n";
            this.btnAñadirUsuario.UseVisualStyleBackColor = true;
            // 
            // btnMostrarUsuario
            // 
            this.btnMostrarUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarUsuario.Location = new System.Drawing.Point(110, 332);
            this.btnMostrarUsuario.Name = "btnMostrarUsuario";
            this.btnMostrarUsuario.Size = new System.Drawing.Size(145, 56);
            this.btnMostrarUsuario.TabIndex = 8;
            this.btnMostrarUsuario.Text = "Mostrar Usuarios";
            this.btnMostrarUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(140, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zas_Sistema_Administrativo_y_Inventario.Properties.Resources.Zas_log;
            this.pictureBox1.Location = new System.Drawing.Point(120, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbUsuarios
            // 
            this.grbUsuarios.Controls.Add(this.dataGridView1);
            this.grbUsuarios.Location = new System.Drawing.Point(557, 251);
            this.grbUsuarios.Name = "grbUsuarios";
            this.grbUsuarios.Size = new System.Drawing.Size(883, 557);
            this.grbUsuarios.TabIndex = 7;
            this.grbUsuarios.TabStop = false;
            this.grbUsuarios.Text = "Vizualizacion de Usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 1017);
            this.Controls.Add(this.grbUsuarios);
            this.Controls.Add(this.panel1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificarEquip;
        private System.Windows.Forms.Button btnAñadirUsuario;
        private System.Windows.Forms.Button btnMostrarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbUsuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}