﻿namespace Tarea3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.capitulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitulosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // capitulosToolStripMenuItem
            // 
            this.capitulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitulo9ToolStripMenuItem,
            this.capitulo10ToolStripMenuItem});
            this.capitulosToolStripMenuItem.Name = "capitulosToolStripMenuItem";
            this.capitulosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.capitulosToolStripMenuItem.Text = "Capitulos ";
            // 
            // capitulo9ToolStripMenuItem
            // 
            this.capitulo9ToolStripMenuItem.Name = "capitulo9ToolStripMenuItem";
            this.capitulo9ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capitulo9ToolStripMenuItem.Text = "Capitulo 9";
            this.capitulo9ToolStripMenuItem.Click += new System.EventHandler(this.Capitulo9ToolStripMenuItem_Click_1);
            // 
            // capitulo10ToolStripMenuItem
            // 
            this.capitulo10ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioTiendaToolStripMenuItem,
            this.estudianteToolStripMenuItem,
            this.poligonoToolStripMenuItem});
            this.capitulo10ToolStripMenuItem.Name = "capitulo10ToolStripMenuItem";
            this.capitulo10ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capitulo10ToolStripMenuItem.Text = "Capitulo 10";
            // 
            // inventarioTiendaToolStripMenuItem
            // 
            this.inventarioTiendaToolStripMenuItem.Name = "inventarioTiendaToolStripMenuItem";
            this.inventarioTiendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventarioTiendaToolStripMenuItem.Text = "Inventario Tienda";
            this.inventarioTiendaToolStripMenuItem.Click += new System.EventHandler(this.InventarioTiendaToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            this.estudianteToolStripMenuItem.Click += new System.EventHandler(this.EstudianteToolStripMenuItem_Click);
            // 
            // poligonoToolStripMenuItem
            // 
            this.poligonoToolStripMenuItem.Name = "poligonoToolStripMenuItem";
            this.poligonoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poligonoToolStripMenuItem.Text = "Poligono";
            this.poligonoToolStripMenuItem.Click += new System.EventHandler(this.PoligonoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tarea 3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem capitulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioTiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poligonoToolStripMenuItem;
    }
}

