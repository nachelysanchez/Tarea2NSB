
namespace Tarea2NSB
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Valor1txt = new System.Windows.Forms.TextBox();
            this.restxt = new System.Windows.Forms.TextBox();
            this.valor2txt = new System.Windows.Forms.TextBox();
            this.SumarButton = new System.Windows.Forms.Button();
            this.RestarButton = new System.Windows.Forms.Button();
            this.MultiplicarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = " Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // Valor1txt
            // 
            this.Valor1txt.Location = new System.Drawing.Point(146, 40);
            this.Valor1txt.Name = "Valor1txt";
            this.Valor1txt.Size = new System.Drawing.Size(100, 20);
            this.Valor1txt.TabIndex = 3;
            // 
            // restxt
            // 
            this.restxt.Location = new System.Drawing.Point(146, 137);
            this.restxt.Name = "restxt";
            this.restxt.Size = new System.Drawing.Size(100, 20);
            this.restxt.TabIndex = 4;
            // 
            // valor2txt
            // 
            this.valor2txt.Location = new System.Drawing.Point(146, 87);
            this.valor2txt.Name = "valor2txt";
            this.valor2txt.Size = new System.Drawing.Size(100, 20);
            this.valor2txt.TabIndex = 5;
            // 
            // SumarButton
            // 
            this.SumarButton.Location = new System.Drawing.Point(276, 39);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(75, 23);
            this.SumarButton.TabIndex = 6;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            // 
            // RestarButton
            // 
            this.RestarButton.Location = new System.Drawing.Point(276, 68);
            this.RestarButton.Name = "RestarButton";
            this.RestarButton.Size = new System.Drawing.Size(75, 23);
            this.RestarButton.TabIndex = 7;
            this.RestarButton.Text = "Restar";
            this.RestarButton.UseVisualStyleBackColor = true;
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.Location = new System.Drawing.Point(276, 97);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplicarButton.TabIndex = 8;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(276, 126);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 9;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 203);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.MultiplicarButton);
            this.Controls.Add(this.RestarButton);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.valor2txt);
            this.Controls.Add(this.restxt);
            this.Controls.Add(this.Valor1txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Operando con valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Valor1txt;
        private System.Windows.Forms.TextBox restxt;
        private System.Windows.Forms.TextBox valor2txt;
        private System.Windows.Forms.Button SumarButton;
        private System.Windows.Forms.Button RestarButton;
        private System.Windows.Forms.Button MultiplicarButton;
        private System.Windows.Forms.Button LimpiarButton;
    }
}

