﻿
namespace Tarea2NSB
{
    partial class FormSalir
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
            this.SalirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.Gray;
            this.SalirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.Location = new System.Drawing.Point(460, 232);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 33);
            this.SalirButton.TabIndex = 0;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = false;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // FormSalir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(576, 289);
            this.Controls.Add(this.SalirButton);
            this.Name = "FormSalir";
            this.Text = "FormSalir";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button SalirButton;
    }
}