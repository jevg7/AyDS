namespace Zas_Sistema_Administrativo_y_Inventario
{
    partial class Equipamiento
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
            this.btnAñadirequipamiento = new System.Windows.Forms.Button();
            this.btnMostrarEquip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbEquipamiento = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.grbEquipamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnModificarEquip);
            this.panel1.Controls.Add(this.btnAñadirequipamiento);
            this.panel1.Controls.Add(this.btnMostrarEquip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-14, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 991);
            this.panel1.TabIndex = 4;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnModificarEquip.Location = new System.Drawing.Point(116, 549);
            this.btnModificarEquip.Name = "btnModificarEquip";
            this.btnModificarEquip.Size = new System.Drawing.Size(145, 55);
            this.btnModificarEquip.TabIndex = 10;
            this.btnModificarEquip.Text = "Modificar Equipamiento";
            this.btnModificarEquip.UseVisualStyleBackColor = true;
            // 
            // btnAñadirequipamiento
            // 
            this.btnAñadirequipamiento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirequipamiento.Location = new System.Drawing.Point(116, 442);
            this.btnAñadirequipamiento.Name = "btnAñadirequipamiento";
            this.btnAñadirequipamiento.Size = new System.Drawing.Size(145, 56);
            this.btnAñadirequipamiento.TabIndex = 9;
            this.btnAñadirequipamiento.Text = "Añadir Nuevo Equipamiento";
            this.btnAñadirequipamiento.UseVisualStyleBackColor = true;
            // 
            // btnMostrarEquip
            // 
            this.btnMostrarEquip.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEquip.Location = new System.Drawing.Point(116, 325);
            this.btnMostrarEquip.Name = "btnMostrarEquip";
            this.btnMostrarEquip.Size = new System.Drawing.Size(145, 56);
            this.btnMostrarEquip.TabIndex = 8;
            this.btnMostrarEquip.Text = "Mostrar Equipamiento";
            this.btnMostrarEquip.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(116, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Equipamiento";
            // 
            // grbEquipamiento
            // 
            this.grbEquipamiento.Controls.Add(this.dataGridView1);
            this.grbEquipamiento.Location = new System.Drawing.Point(628, 221);
            this.grbEquipamiento.Name = "grbEquipamiento";
            this.grbEquipamiento.Size = new System.Drawing.Size(883, 557);
            this.grbEquipamiento.TabIndex = 5;
            this.grbEquipamiento.TabStop = false;
            this.grbEquipamiento.Text = "Vizualizacion de equipamiento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zas_Sistema_Administrativo_y_Inventario.Properties.Resources.Zas_log;
            this.pictureBox1.Location = new System.Drawing.Point(120, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Equipamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 982);
            this.Controls.Add(this.grbEquipamiento);
            this.Controls.Add(this.panel1);
            this.Name = "Equipamiento";
            this.Text = "Equipamiento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbEquipamiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificarEquip;
        private System.Windows.Forms.Button btnAñadirequipamiento;
        private System.Windows.Forms.Button btnMostrarEquip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbEquipamiento;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}