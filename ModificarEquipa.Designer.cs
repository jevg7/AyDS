﻿namespace Zas_Sistema_Administrativo_y_Inventario
{
    partial class ModificarEquipa
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
            this.btnGuardarEquipMod = new System.Windows.Forms.Button();
            this.txtPrecioEquip = new System.Windows.Forms.TextBox();
            this.txtStockEquip = new System.Windows.Forms.TextBox();
            this.txtNombreEquip = new System.Windows.Forms.TextBox();
            this.txtIDEquipa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarEquipMod
            // 
            this.btnGuardarEquipMod.Location = new System.Drawing.Point(240, 932);
            this.btnGuardarEquipMod.Name = "btnGuardarEquipMod";
            this.btnGuardarEquipMod.Size = new System.Drawing.Size(352, 59);
            this.btnGuardarEquipMod.TabIndex = 33;
            this.btnGuardarEquipMod.Text = "Guardar";
            this.btnGuardarEquipMod.UseVisualStyleBackColor = true;
            // 
            // txtPrecioEquip
            // 
            this.txtPrecioEquip.Location = new System.Drawing.Point(318, 717);
            this.txtPrecioEquip.Name = "txtPrecioEquip";
            this.txtPrecioEquip.Size = new System.Drawing.Size(323, 22);
            this.txtPrecioEquip.TabIndex = 32;
            // 
            // txtStockEquip
            // 
            this.txtStockEquip.Location = new System.Drawing.Point(318, 558);
            this.txtStockEquip.Name = "txtStockEquip";
            this.txtStockEquip.Size = new System.Drawing.Size(323, 22);
            this.txtStockEquip.TabIndex = 31;
            // 
            // txtNombreEquip
            // 
            this.txtNombreEquip.Location = new System.Drawing.Point(318, 410);
            this.txtNombreEquip.Name = "txtNombreEquip";
            this.txtNombreEquip.Size = new System.Drawing.Size(323, 22);
            this.txtNombreEquip.TabIndex = 30;
            // 
            // txtIDEquipa
            // 
            this.txtIDEquipa.Location = new System.Drawing.Point(318, 261);
            this.txtIDEquipa.Name = "txtIDEquipa";
            this.txtIDEquipa.Size = new System.Drawing.Size(323, 22);
            this.txtIDEquipa.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 714);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Modificar Equipamiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ModificarEquipa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 1107);
            this.Controls.Add(this.btnGuardarEquipMod);
            this.Controls.Add(this.txtPrecioEquip);
            this.Controls.Add(this.txtStockEquip);
            this.Controls.Add(this.txtNombreEquip);
            this.Controls.Add(this.txtIDEquipa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarEquipa";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarEquipMod;
        private System.Windows.Forms.TextBox txtPrecioEquip;
        private System.Windows.Forms.TextBox txtStockEquip;
        private System.Windows.Forms.TextBox txtNombreEquip;
        private System.Windows.Forms.TextBox txtIDEquipa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}