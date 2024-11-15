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
            this.btnReporteEquipamiento = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnModificarEquip = new System.Windows.Forms.Button();
            this.btnAñadirequipamiento = new System.Windows.Forms.Button();
            this.btnMostrarEquip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbEquipamiento = new System.Windows.Forms.GroupBox();
            this.dtgvEquipamiento = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbEquipamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEquipamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnReporteEquipamiento);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnModificarEquip);
            this.panel1.Controls.Add(this.btnAñadirequipamiento);
            this.panel1.Controls.Add(this.btnMostrarEquip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-10, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 805);
            this.panel1.TabIndex = 4;
            // 
            // btnReporteEquipamiento
            // 
            this.btnReporteEquipamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteEquipamiento.Location = new System.Drawing.Point(87, 533);
            this.btnReporteEquipamiento.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteEquipamiento.Name = "btnReporteEquipamiento";
            this.btnReporteEquipamiento.Size = new System.Drawing.Size(109, 45);
            this.btnReporteEquipamiento.TabIndex = 12;
            this.btnReporteEquipamiento.Text = "Generar Reporte";
            this.btnReporteEquipamiento.UseVisualStyleBackColor = true;
            this.btnReporteEquipamiento.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(27, 747);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(88, 29);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificarEquip
            // 
            this.btnModificarEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEquip.Location = new System.Drawing.Point(87, 446);
            this.btnModificarEquip.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarEquip.Name = "btnModificarEquip";
            this.btnModificarEquip.Size = new System.Drawing.Size(109, 45);
            this.btnModificarEquip.TabIndex = 10;
            this.btnModificarEquip.Text = "Modificar Equipamiento";
            this.btnModificarEquip.UseVisualStyleBackColor = true;
            this.btnModificarEquip.Click += new System.EventHandler(this.btnModificarEquip_Click);
            // 
            // btnAñadirequipamiento
            // 
            this.btnAñadirequipamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirequipamiento.Location = new System.Drawing.Point(87, 359);
            this.btnAñadirequipamiento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirequipamiento.Name = "btnAñadirequipamiento";
            this.btnAñadirequipamiento.Size = new System.Drawing.Size(109, 46);
            this.btnAñadirequipamiento.TabIndex = 9;
            this.btnAñadirequipamiento.Text = "Añadir Nuevo Equipamiento";
            this.btnAñadirequipamiento.UseVisualStyleBackColor = true;
            this.btnAñadirequipamiento.Click += new System.EventHandler(this.btnAñadirequipamiento_Click);
            // 
            // btnMostrarEquip
            // 
            this.btnMostrarEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEquip.Location = new System.Drawing.Point(87, 264);
            this.btnMostrarEquip.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarEquip.Name = "btnMostrarEquip";
            this.btnMostrarEquip.Size = new System.Drawing.Size(109, 46);
            this.btnMostrarEquip.TabIndex = 8;
            this.btnMostrarEquip.Text = "Mostrar Equipamiento";
            this.btnMostrarEquip.UseVisualStyleBackColor = true;
            this.btnMostrarEquip.Click += new System.EventHandler(this.btnMostrarEquip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(87, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Equipamiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zas_Sistema_Administrativo_y_Inventario.Properties.Resources.Zas_log;
            this.pictureBox1.Location = new System.Drawing.Point(90, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbEquipamiento
            // 
            this.grbEquipamiento.Controls.Add(this.dtgvEquipamiento);
            this.grbEquipamiento.Location = new System.Drawing.Point(471, 180);
            this.grbEquipamiento.Margin = new System.Windows.Forms.Padding(2);
            this.grbEquipamiento.Name = "grbEquipamiento";
            this.grbEquipamiento.Padding = new System.Windows.Forms.Padding(2);
            this.grbEquipamiento.Size = new System.Drawing.Size(662, 453);
            this.grbEquipamiento.TabIndex = 5;
            this.grbEquipamiento.TabStop = false;
            this.grbEquipamiento.Text = "Vizualizacion de equipamiento";
            // 
            // dtgvEquipamiento
            // 
            this.dtgvEquipamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEquipamiento.Location = new System.Drawing.Point(32, 54);
            this.dtgvEquipamiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvEquipamiento.Name = "dtgvEquipamiento";
            this.dtgvEquipamiento.RowHeadersWidth = 51;
            this.dtgvEquipamiento.RowTemplate.Height = 24;
            this.dtgvEquipamiento.Size = new System.Drawing.Size(600, 368);
            this.dtgvEquipamiento.TabIndex = 0;
            // 
            // Equipamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 798);
            this.Controls.Add(this.grbEquipamiento);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Equipamiento";
            this.Text = "Equipamiento";
            this.Load += new System.EventHandler(this.Equipamiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbEquipamiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEquipamiento)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgvEquipamiento;
        private System.Windows.Forms.Button btnReporteEquipamiento;
    }
}