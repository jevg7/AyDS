﻿namespace Zas_Sistema_Administrativo_y_Inventario
{
    partial class reporteReactivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporteReactivos));
            this.RvReactivos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RvReactivos
            // 
            this.RvReactivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvReactivos.LocalReport.ReportEmbeddedResource = "Zas_Sistema_Administrativo_y_Inventario.Reportes.rptReactivos.rdlc";
            this.RvReactivos.Location = new System.Drawing.Point(0, 0);
            this.RvReactivos.Name = "RvReactivos";
            this.RvReactivos.ServerReport.BearerToken = null;
            this.RvReactivos.Size = new System.Drawing.Size(800, 450);
            this.RvReactivos.TabIndex = 0;
            this.RvReactivos.Load += new System.EventHandler(this.RvReactivos_Load);
            // 
            // reporteReactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RvReactivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reporteReactivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporteReactivos";
            this.Load += new System.EventHandler(this.reporteReactivos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RvReactivos;
    }
}