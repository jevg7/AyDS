﻿namespace Zas_Sistema_Administrativo_y_Inventario
{
    partial class vReactivo
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDreactivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgrgrReact = new System.Windows.Forms.Button();
            this.btnGuardarReact = new System.Windows.Forms.Button();
            this.btnCancelarReact = new System.Windows.Forms.Button();
            this.dgvReactivos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrecio.Location = new System.Drawing.Point(639, 63);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(177, 30);
            this.txtPrecio.TabIndex = 20;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStock.Location = new System.Drawing.Point(378, 112);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(177, 30);
            this.txtStock.TabIndex = 19;
            // 
            // txtFormula
            // 
            this.txtFormula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFormula.Location = new System.Drawing.Point(378, 63);
            this.txtFormula.Margin = new System.Windows.Forms.Padding(2);
            this.txtFormula.Multiline = true;
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(177, 30);
            this.txtFormula.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(98, 112);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 30);
            this.txtNombre.TabIndex = 17;
            // 
            // txtIDreactivo
            // 
            this.txtIDreactivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDreactivo.Enabled = false;
            this.txtIDreactivo.Location = new System.Drawing.Point(98, 65);
            this.txtIDreactivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDreactivo.Multiline = true;
            this.txtIDreactivo.Name = "txtIDreactivo";
            this.txtIDreactivo.Size = new System.Drawing.Size(177, 30);
            this.txtIDreactivo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fórmula";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Reactivos";
            // 
            // btnAgrgrReact
            // 
            this.btnAgrgrReact.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgrgrReact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgrgrReact.Location = new System.Drawing.Point(580, 114);
            this.btnAgrgrReact.Name = "btnAgrgrReact";
            this.btnAgrgrReact.Size = new System.Drawing.Size(79, 28);
            this.btnAgrgrReact.TabIndex = 22;
            this.btnAgrgrReact.Text = "Agregar";
            this.btnAgrgrReact.UseVisualStyleBackColor = true;
            this.btnAgrgrReact.Click += new System.EventHandler(this.btnAgrgrReact_Click);
            // 
            // btnGuardarReact
            // 
            this.btnGuardarReact.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardarReact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarReact.Enabled = false;
            this.btnGuardarReact.Location = new System.Drawing.Point(665, 114);
            this.btnGuardarReact.Name = "btnGuardarReact";
            this.btnGuardarReact.Size = new System.Drawing.Size(94, 28);
            this.btnGuardarReact.TabIndex = 23;
            this.btnGuardarReact.Text = "Guardar";
            this.btnGuardarReact.UseVisualStyleBackColor = true;
            this.btnGuardarReact.Click += new System.EventHandler(this.btnGuardarReact_Click);
            // 
            // btnCancelarReact
            // 
            this.btnCancelarReact.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelarReact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarReact.Location = new System.Drawing.Point(765, 114);
            this.btnCancelarReact.Name = "btnCancelarReact";
            this.btnCancelarReact.Size = new System.Drawing.Size(94, 28);
            this.btnCancelarReact.TabIndex = 24;
            this.btnCancelarReact.Text = "Cancelar";
            this.btnCancelarReact.UseVisualStyleBackColor = true;
            this.btnCancelarReact.Click += new System.EventHandler(this.btnCancelarReact_Click);
            // 
            // dgvReactivos
            // 
            this.dgvReactivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReactivos.Location = new System.Drawing.Point(15, 164);
            this.dgvReactivos.Name = "dgvReactivos";
            this.dgvReactivos.Size = new System.Drawing.Size(844, 317);
            this.dgvReactivos.TabIndex = 25;
            this.dgvReactivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReactivos_CellContentClick);
            // 
            // vReactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(871, 493);
            this.Controls.Add(this.dgvReactivos);
            this.Controls.Add(this.btnCancelarReact);
            this.Controls.Add(this.btnGuardarReact);
            this.Controls.Add(this.btnAgrgrReact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDreactivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vReactivo";
            this.Text = "vReactivo";
            this.Load += new System.EventHandler(this.vReactivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReactivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDreactivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgrgrReact;
        private System.Windows.Forms.Button btnGuardarReact;
        private System.Windows.Forms.Button btnCancelarReact;
        private System.Windows.Forms.DataGridView dgvReactivos;
    }
}