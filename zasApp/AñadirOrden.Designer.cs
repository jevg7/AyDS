namespace Zas_Sistema_Administrativo_y_Inventario
{
    partial class AñadirOrden
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
            this.btnGuardarOrden = new System.Windows.Forms.Button();
            this.txtProdOrden = new System.Windows.Forms.TextBox();
            this.txtCantOrden = new System.Windows.Forms.TextBox();
            this.txtIDOrden = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProveeOrden = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpOrden = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarOrden
            // 
            this.btnGuardarOrden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarOrden.Location = new System.Drawing.Point(335, 784);
            this.btnGuardarOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarOrden.Name = "btnGuardarOrden";
            this.btnGuardarOrden.Size = new System.Drawing.Size(179, 59);
            this.btnGuardarOrden.TabIndex = 53;
            this.btnGuardarOrden.Text = "Guardar";
            this.btnGuardarOrden.UseVisualStyleBackColor = true;
            this.btnGuardarOrden.Click += new System.EventHandler(this.btnGuardarOrden_Click);
            // 
            // txtProdOrden
            // 
            this.txtProdOrden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProdOrden.Location = new System.Drawing.Point(314, 584);
            this.txtProdOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProdOrden.Multiline = true;
            this.txtProdOrden.Name = "txtProdOrden";
            this.txtProdOrden.Size = new System.Drawing.Size(224, 45);
            this.txtProdOrden.TabIndex = 52;
            // 
            // txtCantOrden
            // 
            this.txtCantOrden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantOrden.Location = new System.Drawing.Point(314, 467);
            this.txtCantOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantOrden.Multiline = true;
            this.txtCantOrden.Name = "txtCantOrden";
            this.txtCantOrden.Size = new System.Drawing.Size(224, 46);
            this.txtCantOrden.TabIndex = 51;
            // 
            // txtIDOrden
            // 
            this.txtIDOrden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDOrden.Location = new System.Drawing.Point(314, 273);
            this.txtIDOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDOrden.Multiline = true;
            this.txtIDOrden.Name = "txtIDOrden";
            this.txtIDOrden.Size = new System.Drawing.Size(224, 43);
            this.txtIDOrden.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Producto";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "Añadir Orden\r\n";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 701);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Proveedor";
            // 
            // txtProveeOrden
            // 
            this.txtProveeOrden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProveeOrden.Location = new System.Drawing.Point(314, 691);
            this.txtProveeOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProveeOrden.Multiline = true;
            this.txtProveeOrden.Name = "txtProveeOrden";
            this.txtProveeOrden.Size = new System.Drawing.Size(224, 48);
            this.txtProveeOrden.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Zas_Sistema_Administrativo_y_Inventario.Properties.Resources.Zas_log;
            this.pictureBox1.Location = new System.Drawing.Point(358, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // dtpOrden
            // 
            this.dtpOrden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpOrden.Location = new System.Drawing.Point(314, 373);
            this.dtpOrden.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOrden.Name = "dtpOrden";
            this.dtpOrden.Size = new System.Drawing.Size(224, 22);
            this.dtpOrden.TabIndex = 57;
            this.dtpOrden.ValueChanged += new System.EventHandler(this.dtpOrden_ValueChanged);
            // 
            // AñadirOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 890);
            this.Controls.Add(this.dtpOrden);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtProveeOrden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardarOrden);
            this.Controls.Add(this.txtProdOrden);
            this.Controls.Add(this.txtCantOrden);
            this.Controls.Add(this.txtIDOrden);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AñadirOrden";
            this.Text = "AñadirOrden";
            this.Load += new System.EventHandler(this.AñadirOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarOrden;
        private System.Windows.Forms.TextBox txtProdOrden;
        private System.Windows.Forms.TextBox txtCantOrden;
        private System.Windows.Forms.TextBox txtIDOrden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProveeOrden;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpOrden;
    }
}