
namespace Tarea2NSB
{
    partial class Principal
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
            this.DocentesButton = new System.Windows.Forms.Button();
            this.EstudiantesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OperacionesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(452, 274);
            this.SalirButton.Size = new System.Drawing.Size(106, 63);
            // 
            // DocentesButton
            // 
            this.DocentesButton.BackColor = System.Drawing.Color.Gray;
            this.DocentesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocentesButton.Location = new System.Drawing.Point(308, 157);
            this.DocentesButton.Name = "DocentesButton";
            this.DocentesButton.Size = new System.Drawing.Size(106, 63);
            this.DocentesButton.TabIndex = 13;
            this.DocentesButton.Text = "Registro Docentes";
            this.DocentesButton.UseVisualStyleBackColor = false;
            this.DocentesButton.Click += new System.EventHandler(this.DocentesButton_Click);
            // 
            // EstudiantesButton
            // 
            this.EstudiantesButton.BackColor = System.Drawing.Color.Gray;
            this.EstudiantesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudiantesButton.Location = new System.Drawing.Point(128, 157);
            this.EstudiantesButton.Name = "EstudiantesButton";
            this.EstudiantesButton.Size = new System.Drawing.Size(106, 63);
            this.EstudiantesButton.TabIndex = 14;
            this.EstudiantesButton.Text = "Registro Estudiantes";
            this.EstudiantesButton.UseVisualStyleBackColor = false;
            this.EstudiantesButton.Click += new System.EventHandler(this.EstudiantesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ejemplo 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ejemplo 1";
            // 
            // OperacionesButton
            // 
            this.OperacionesButton.BackColor = System.Drawing.Color.Gray;
            this.OperacionesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperacionesButton.Location = new System.Drawing.Point(128, 59);
            this.OperacionesButton.Name = "OperacionesButton";
            this.OperacionesButton.Size = new System.Drawing.Size(116, 50);
            this.OperacionesButton.TabIndex = 17;
            this.OperacionesButton.Text = "Operaciones";
            this.OperacionesButton.UseVisualStyleBackColor = false;
            this.OperacionesButton.Click += new System.EventHandler(this.OperacionesButton_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 349);
            this.Controls.Add(this.OperacionesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EstudiantesButton);
            this.Controls.Add(this.DocentesButton);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Controls.SetChildIndex(this.SalirButton, 0);
            this.Controls.SetChildIndex(this.DocentesButton, 0);
            this.Controls.SetChildIndex(this.EstudiantesButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.OperacionesButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button DocentesButton;
        protected System.Windows.Forms.Button EstudiantesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button OperacionesButton;
    }
}