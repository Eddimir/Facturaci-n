﻿namespace Proyecto1.Reportes
{
    partial class ReportesGenerales
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
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.reportPanel1 = new Microsoft.Reporting.WinForms.ReportPanel();
        //    this.SuspendLayout();
        //    // 
        //    // reportPanel1
        //    // 
        //    this.reportPanel1.AutoScroll = true;
        //    this.reportPanel1.CurrentPage = null;
        //    this.reportPanel1.Location = new System.Drawing.Point(399, 95);
        //    this.reportPanel1.Name = "reportPanel1";
        //    this.reportPanel1.ShowContextMenu = true;
        //    this.reportPanel1.Size = new System.Drawing.Size(200, 100);
        //    this.reportPanel1.TabIndex = 0;
        //    this.reportPanel1.ViewerControl = null;
        //    // 
        //    // ReportesGenerales
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Controls.Add(this.reportPanel1);
        //    this.Name = "ReportesGenerales";
        //    this.Text = "ReportesGenerales";
        //    this.ResumeLayout(false);

        //}
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesGenerales));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            // 
            // ReportesGenerales
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesGenerales";
            this.Load += new System.EventHandler(this.ReportesGenerales_Load_1);
            this.ResumeLayout(false);

        }

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        //public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        #endregion

        //private ReportPanel reportPanel1;

    }
}