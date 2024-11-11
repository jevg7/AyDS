namespace Zas_Sistema_Administrativo_y_Inventario
{
    partial class Pantallaprinci
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnherramientas = new System.Windows.Forms.Button();
            this.btnEquipamiento = new System.Windows.Forms.Button();
            this.btnreactivos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnOrdenes);
            this.panel1.Controls.Add(this.btnherramientas);
            this.panel1.Controls.Add(this.btnEquipamiento);
            this.panel1.Controls.Add(this.btnreactivos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 849);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.Location = new System.Drawing.Point(13, 796);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(188, 26);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(30, 622);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(163, 40);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.Location = new System.Drawing.Point(30, 520);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(163, 45);
            this.btnOrdenes.TabIndex = 4;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            // 
            // btnherramientas
            // 
            this.btnherramientas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnherramientas.Location = new System.Drawing.Point(30, 424);
            this.btnherramientas.Name = "btnherramientas";
            this.btnherramientas.Size = new System.Drawing.Size(163, 47);
            this.btnherramientas.TabIndex = 3;
            this.btnherramientas.Text = "Herramientas";
            this.btnherramientas.UseVisualStyleBackColor = true;
            // 
            // btnEquipamiento
            // 
            this.btnEquipamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipamiento.Location = new System.Drawing.Point(30, 322);
            this.btnEquipamiento.Name = "btnEquipamiento";
            this.btnEquipamiento.Size = new System.Drawing.Size(163, 46);
            this.btnEquipamiento.TabIndex = 2;
            this.btnEquipamiento.Text = "Equipamiento";
            this.btnEquipamiento.UseVisualStyleBackColor = true;
            // 
            // btnreactivos
            // 
            this.btnreactivos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreactivos.Location = new System.Drawing.Point(30, 227);
            this.btnreactivos.Name = "btnreactivos";
            this.btnreactivos.Size = new System.Drawing.Size(163, 42);
            this.btnreactivos.TabIndex = 1;
            this.btnreactivos.Text = "Reactivos";
            this.btnreactivos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MoeumT R", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(297, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Zas! Medical\r\nSistema Administrativo\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zas_Sistema_Administrativo_y_Inventario.Properties.Resources.Zas_log;
            this.pictureBox1.Location = new System.Drawing.Point(63, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pantallaprinci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 843);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Pantallaprinci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnherramientas;
        private System.Windows.Forms.Button btnEquipamiento;
        private System.Windows.Forms.Button btnreactivos;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label label1;
    }
}