namespace Tarea3.UI.Registros
{
    partial class Capitulo9
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
            this.numericUpDownCantidadArticulo = new System.Windows.Forms.NumericUpDown();
            this.textBoxArticuloIngresado = new System.Windows.Forms.TextBox();
            this.labelMostrarArticulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduzca la cantidad";
            // 
            // numericUpDownCantidadArticulo
            // 
            this.numericUpDownCantidadArticulo.Location = new System.Drawing.Point(213, 70);
            this.numericUpDownCantidadArticulo.Name = "numericUpDownCantidadArticulo";
            this.numericUpDownCantidadArticulo.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownCantidadArticulo.TabIndex = 2;
            this.numericUpDownCantidadArticulo.ValueChanged += new System.EventHandler(this.NumericUpDownCantidadArticulo_ValueChanged);
            // 
            // textBoxArticuloIngresado
            // 
            this.textBoxArticuloIngresado.Location = new System.Drawing.Point(213, 25);
            this.textBoxArticuloIngresado.Name = "textBoxArticuloIngresado";
            this.textBoxArticuloIngresado.Size = new System.Drawing.Size(100, 20);
            this.textBoxArticuloIngresado.TabIndex = 3;
            // 
            // labelMostrarArticulo
            // 
            this.labelMostrarArticulo.AutoSize = true;
            this.labelMostrarArticulo.Location = new System.Drawing.Point(38, 130);
            this.labelMostrarArticulo.Name = "labelMostrarArticulo";
            this.labelMostrarArticulo.Size = new System.Drawing.Size(0, 13);
            this.labelMostrarArticulo.TabIndex = 4;
            // 
            // Capitulo9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.labelMostrarArticulo);
            this.Controls.Add(this.textBoxArticuloIngresado);
            this.Controls.Add(this.numericUpDownCantidadArticulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Capitulo9";
            this.Text = "Capitulo 9";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidadArticulo;
        private System.Windows.Forms.TextBox textBoxArticuloIngresado;
        private System.Windows.Forms.Label labelMostrarArticulo;
    }
}