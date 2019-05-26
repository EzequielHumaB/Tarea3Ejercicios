namespace Tarea3.UI.Registros
{
    partial class PoligonoForm
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
            this.numericUpDownLadoIngresado = new System.Windows.Forms.NumericUpDown();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelVolumen = new System.Windows.Forms.Label();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonVolumen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLadoIngresado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Longitud del lado";
            // 
            // numericUpDownLadoIngresado
            // 
            this.numericUpDownLadoIngresado.Location = new System.Drawing.Point(154, 22);
            this.numericUpDownLadoIngresado.Name = "numericUpDownLadoIngresado";
            this.numericUpDownLadoIngresado.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLadoIngresado.TabIndex = 1;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(39, 65);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(0, 13);
            this.labelArea.TabIndex = 2;
            // 
            // labelVolumen
            // 
            this.labelVolumen.AutoSize = true;
            this.labelVolumen.Location = new System.Drawing.Point(39, 99);
            this.labelVolumen.Name = "labelVolumen";
            this.labelVolumen.Size = new System.Drawing.Size(0, 13);
            this.labelVolumen.TabIndex = 3;
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(154, 65);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(120, 23);
            this.buttonArea.TabIndex = 4;
            this.buttonArea.Text = "Calcular Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.ButtonArea_Click);
            // 
            // buttonVolumen
            // 
            this.buttonVolumen.Location = new System.Drawing.Point(154, 99);
            this.buttonVolumen.Name = "buttonVolumen";
            this.buttonVolumen.Size = new System.Drawing.Size(120, 23);
            this.buttonVolumen.TabIndex = 5;
            this.buttonVolumen.Text = "Calcular Volumen";
            this.buttonVolumen.UseVisualStyleBackColor = true;
            this.buttonVolumen.Click += new System.EventHandler(this.ButtonVolumen_Click);
            // 
            // PoligonoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 174);
            this.Controls.Add(this.buttonVolumen);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.labelVolumen);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.numericUpDownLadoIngresado);
            this.Controls.Add(this.label1);
            this.Name = "PoligonoForm";
            this.Text = "Calcular area y volumen";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLadoIngresado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownLadoIngresado;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelVolumen;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonVolumen;
    }
}