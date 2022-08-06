
namespace Tarea2NSB.Ejemplo2
{
    partial class RegistroFrm
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
            this.valor2txt = new System.Windows.Forms.TextBox();
            this.restxt = new System.Windows.Forms.TextBox();
            this.Valor1txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalirButton
            // 
            this.SalirButton.Size = new System.Drawing.Size(91, 33);
            // 
            // valor2txt
            // 
            this.valor2txt.Location = new System.Drawing.Point(152, 93);
            this.valor2txt.Name = "valor2txt";
            this.valor2txt.Size = new System.Drawing.Size(284, 20);
            this.valor2txt.TabIndex = 11;
            // 
            // restxt
            // 
            this.restxt.Location = new System.Drawing.Point(152, 143);
            this.restxt.Name = "restxt";
            this.restxt.Size = new System.Drawing.Size(284, 20);
            this.restxt.TabIndex = 10;
            // 
            // Valor1txt
            // 
            this.Valor1txt.Location = new System.Drawing.Point(152, 46);
            this.Valor1txt.Name = "Valor1txt";
            this.Valor1txt.Size = new System.Drawing.Size(284, 20);
            this.Valor1txt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.BackColor = System.Drawing.Color.Gray;
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(460, 130);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(91, 33);
            this.LimpiarButton.TabIndex = 12;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = false;
            // 
            // ModificarButton
            // 
            this.ModificarButton.BackColor = System.Drawing.Color.Gray;
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(460, 85);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(91, 33);
            this.ModificarButton.TabIndex = 13;
            this.ModificarButton.Text = "ModificarButton";
            this.ModificarButton.UseVisualStyleBackColor = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.Color.Gray;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(460, 38);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(91, 33);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = false;
            // 
            // RegistroFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 285);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.valor2txt);
            this.Controls.Add(this.restxt);
            this.Controls.Add(this.Valor1txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroFrm";
            this.Text = "RegistroFrm";
            this.Load += new System.EventHandler(this.RegistroFrm_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valor2txt;
        private System.Windows.Forms.TextBox restxt;
        private System.Windows.Forms.TextBox Valor1txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button LimpiarButton;
        protected System.Windows.Forms.Button ModificarButton;
        protected System.Windows.Forms.Button GuardarButton;
    }
}