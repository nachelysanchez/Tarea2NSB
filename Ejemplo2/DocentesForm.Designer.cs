
namespace Tarea2NSB.Ejemplo2
{
    partial class DocentesForm
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
            this.Materiatxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(460, 178);
            // 
            // Materiatxt
            // 
            this.Materiatxt.Location = new System.Drawing.Point(153, 186);
            this.Materiatxt.Name = "Materiatxt";
            this.Materiatxt.Size = new System.Drawing.Size(284, 20);
            this.Materiatxt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Materia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Registro de Docentes";
            // 
            // DocentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 242);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Materiatxt);
            this.Controls.Add(this.label4);
            this.Name = "DocentesForm";
            this.Text = "DocentesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocentesForm_FormClosed);
            this.Load += new System.EventHandler(this.DocentesForm_Load);
            this.Controls.SetChildIndex(this.SalirButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Valor1txt, 0);
            this.Controls.SetChildIndex(this.restxt, 0);
            this.Controls.SetChildIndex(this.valor2txt, 0);
            this.Controls.SetChildIndex(this.LimpiarButton, 0);
            this.Controls.SetChildIndex(this.ModificarButton, 0);
            this.Controls.SetChildIndex(this.GuardarButton, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.Materiatxt, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox Materiatxt;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}