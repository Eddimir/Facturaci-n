﻿namespace Proyecto1.Modulos
{
    partial class FrmCrearModulos
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
            this.components = new System.ComponentModel.Container();
            this.lblid = new System.Windows.Forms.Label();
            this.lblNombreModulo = new System.Windows.Forms.Label();
            this.txtNombreDeModulo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(201, 9);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 18);
            this.lblid.TabIndex = 0;
            // 
            // lblNombreModulo
            // 
            this.lblNombreModulo.AutoSize = true;
            this.lblNombreModulo.Location = new System.Drawing.Point(10, 16);
            this.lblNombreModulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreModulo.Name = "lblNombreModulo";
            this.lblNombreModulo.Size = new System.Drawing.Size(140, 18);
            this.lblNombreModulo.TabIndex = 1;
            this.lblNombreModulo.Text = "Nombre de Modulo:";
            // 
            // txtNombreDeModulo
            // 
            this.txtNombreDeModulo.Location = new System.Drawing.Point(13, 38);
            this.txtNombreDeModulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDeModulo.Name = "txtNombreDeModulo";
            this.txtNombreDeModulo.Size = new System.Drawing.Size(319, 24);
            this.txtNombreDeModulo.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(244, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 32);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCrearModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 118);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreDeModulo);
            this.Controls.Add(this.lblNombreModulo);
            this.Controls.Add(this.lblid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCrearModulos";
            this.Text = "FrmCrearModulos";
            this.Load += new System.EventHandler(this.FrmCrearModulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreModulo;
        private System.Windows.Forms.TextBox txtNombreDeModulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label lblid;
    }
}