
namespace Tarea2NSB.Ejemplo2
{
    partial class EstudiantesForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(460, 142);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(460, 97);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(460, 50);
            // 
            // valor2txt
            // 
            this.valor2txt.Location = new System.Drawing.Point(152, 105);
            // 
            // restxt
            // 
            this.restxt.Location = new System.Drawing.Point(152, 155);
            // 
            // Valor1txt
            // 
            this.Valor1txt.Location = new System.Drawing.Point(152, 58);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(57, 154);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(54, 104);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 57);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(460, 198);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Registro de Estudiantes";
            // 
            // EstudiantesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 263);
            this.Controls.Add(this.label4);
            this.Name = "EstudiantesForm";
            this.Text = "EstudiantesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EstudiantesForm_FormClosed);
            this.Load += new System.EventHandler(this.EstudiantesForm_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
    }
}