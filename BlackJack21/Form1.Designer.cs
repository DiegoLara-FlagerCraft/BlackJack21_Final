
namespace BlackJack21
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnvCarta = new System.Windows.Forms.Button();
            this.RtxtMostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnvCarta
            // 
            this.BtnvCarta.Location = new System.Drawing.Point(319, 318);
            this.BtnvCarta.Name = "BtnvCarta";
            this.BtnvCarta.Size = new System.Drawing.Size(131, 57);
            this.BtnvCarta.TabIndex = 0;
            this.BtnvCarta.Text = "Add";
            this.BtnvCarta.UseVisualStyleBackColor = true;
            this.BtnvCarta.Click += new System.EventHandler(this.button1_Click);
            // 
            // RtxtMostrar
            // 
            this.RtxtMostrar.Location = new System.Drawing.Point(268, 12);
            this.RtxtMostrar.Name = "RtxtMostrar";
            this.RtxtMostrar.Size = new System.Drawing.Size(237, 196);
            this.RtxtMostrar.TabIndex = 1;
            this.RtxtMostrar.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RtxtMostrar);
            this.Controls.Add(this.BtnvCarta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnvCarta;
        private System.Windows.Forms.RichTextBox RtxtMostrar;
    }
}

