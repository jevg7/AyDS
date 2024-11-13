namespace Zas_Sistema_Administrativo_y_Inventario
{
    partial class Añadirequipa
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
            this.btnGuardarEquip = new System.Windows.Forms.Button();
            this.txtPrecioEquip = new System.Windows.Forms.TextBox();
            this.txtStockEquip = new System.Windows.Forms.TextBox();
            this.txtNombreEquip = new System.Windows.Forms.TextBox();
            this.txtIDEquipa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarEquip
            // 
            this.btnGuardarEquip.Location = new System.Drawing.Point(758, 1168);
            this.btnGuardarEquip.Name = "btnGuardarEquip";
            this.btnGuardarEquip.Size = new System.Drawing.Size(169, 59);
            this.btnGuardarEquip.TabIndex = 23;
            this.btnGuardarEquip.Text = "Guardar";
            this.btnGuardarEquip.UseVisualStyleBackColor = true;
            // 
            // txtPrecioEquip
            // 
            this.txtPrecioEquip.Location = new System.Drawing.Point(318, 908);
            this.txtPrecioEquip.Multiline = true;
            this.txtPrecioEquip.Name = "txtPrecioEquip";
            this.txtPrecioEquip.Size = new System.Drawing.Size(224, 45);
            this.txtPrecioEquip.TabIndex = 22;
            this.txtPrecioEquip.TextChanged += new System.EventHandler(this.txtPrecioEquip_TextChanged);
            // 
            // txtStockEquip
            // 
            this.txtStockEquip.Location = new System.Drawing.Point(318, 758);
            this.txtStockEquip.Multiline = true;
            this.txtStockEquip.Name = "txtStockEquip";
            this.txtStockEquip.Size = new System.Drawing.Size(224, 42);
            this.txtStockEquip.TabIndex = 21;
            // 
            // txtNombreEquip
            // 
            this.txtNombreEquip.Location = new System.Drawing.Point(318, 614);
            this.txtNombreEquip.Multiline = true;
            this.txtNombreEquip.Name = "txtNombreEquip";
            this.txtNombreEquip.Size = new System.Drawing.Size(224, 40);
            this.txtNombreEquip.TabIndex = 19;
            // 
            // txtIDEquipa
            // 
            this.txtIDEquipa.Location = new System.Drawing.Point(318, 448);
            this.txtIDEquipa.Multiline = true;
            this.txtIDEquipa.Name = "txtIDEquipa";
            this.txtIDEquipa.Size = new System.Drawing.Size(224, 42);
            this.txtIDEquipa.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 754);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 904);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Añadir Equipamiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zas_Sistema_Administrativo_y_Inventario.Properties.Resources.Zas_log;
            this.pictureBox1.Location = new System.Drawing.Point(431, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Añadirequipa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(960, 1296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardarEquip);
            this.Controls.Add(this.txtPrecioEquip);
            this.Controls.Add(this.txtStockEquip);
            this.Controls.Add(this.txtNombreEquip);
            this.Controls.Add(this.txtIDEquipa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Añadirequipa";
            this.Text = "Añadirequipa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarEquip;
        private System.Windows.Forms.TextBox txtPrecioEquip;
        private System.Windows.Forms.TextBox txtStockEquip;
        private System.Windows.Forms.TextBox txtNombreEquip;
        private System.Windows.Forms.TextBox txtIDEquipa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}