
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RtxtManoD = new System.Windows.Forms.RichTextBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.LabelD = new System.Windows.Forms.Label();
            this.LabelP = new System.Windows.Forms.Label();
            this.RtxtManoP = new System.Windows.Forms.RichTextBox();
            this.BtnPlantar = new System.Windows.Forms.Button();
            this.BtnPedir = new System.Windows.Forms.Button();
            this.LabelScoreD = new System.Windows.Forms.Label();
            this.RtxtScoreD = new System.Windows.Forms.RichTextBox();
            this.RtxtScoreP = new System.Windows.Forms.RichTextBox();
            this.LabelScoreP = new System.Windows.Forms.Label();
            this.LabelGames = new System.Windows.Forms.Label();
            this.RtxtGames = new System.Windows.Forms.RichTextBox();
            this.LabelWins = new System.Windows.Forms.Label();
            this.LabelFails = new System.Windows.Forms.Label();
            this.RtxtWins = new System.Windows.Forms.RichTextBox();
            this.RtxtFails = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RtxtManoD
            // 
            this.RtxtManoD.BackColor = System.Drawing.Color.Green;
            this.RtxtManoD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxtManoD.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtManoD.Location = new System.Drawing.Point(496, 46);
            this.RtxtManoD.Name = "RtxtManoD";
            this.RtxtManoD.ReadOnly = true;
            this.RtxtManoD.Size = new System.Drawing.Size(166, 112);
            this.RtxtManoD.TabIndex = 2;
            this.RtxtManoD.Text = "";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnIniciar.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(496, 216);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(166, 65);
            this.BtnIniciar.TabIndex = 3;
            this.BtnIniciar.Text = "JUGAR";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // LabelD
            // 
            this.LabelD.AutoSize = true;
            this.LabelD.BackColor = System.Drawing.Color.Transparent;
            this.LabelD.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelD.Location = new System.Drawing.Point(515, 12);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(125, 31);
            this.LabelD.TabIndex = 4;
            this.LabelD.Text = "DEALER";
            // 
            // LabelP
            // 
            this.LabelP.AutoSize = true;
            this.LabelP.BackColor = System.Drawing.Color.Transparent;
            this.LabelP.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelP.Location = new System.Drawing.Point(515, 334);
            this.LabelP.Name = "LabelP";
            this.LabelP.Size = new System.Drawing.Size(124, 31);
            this.LabelP.TabIndex = 5;
            this.LabelP.Text = "PLAYER";
            // 
            // RtxtManoP
            // 
            this.RtxtManoP.BackColor = System.Drawing.Color.Green;
            this.RtxtManoP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxtManoP.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtManoP.Location = new System.Drawing.Point(496, 385);
            this.RtxtManoP.Name = "RtxtManoP";
            this.RtxtManoP.ReadOnly = true;
            this.RtxtManoP.Size = new System.Drawing.Size(166, 112);
            this.RtxtManoP.TabIndex = 6;
            this.RtxtManoP.Text = "";
            // 
            // BtnPlantar
            // 
            this.BtnPlantar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnPlantar.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlantar.Location = new System.Drawing.Point(410, 513);
            this.BtnPlantar.Name = "BtnPlantar";
            this.BtnPlantar.Size = new System.Drawing.Size(137, 45);
            this.BtnPlantar.TabIndex = 7;
            this.BtnPlantar.Text = "Plantar";
            this.BtnPlantar.UseVisualStyleBackColor = false;
            this.BtnPlantar.Click += new System.EventHandler(this.BtnPlantar_Click);
            // 
            // BtnPedir
            // 
            this.BtnPedir.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnPedir.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedir.Location = new System.Drawing.Point(607, 513);
            this.BtnPedir.Name = "BtnPedir";
            this.BtnPedir.Size = new System.Drawing.Size(137, 45);
            this.BtnPedir.TabIndex = 8;
            this.BtnPedir.Text = "Pedir";
            this.BtnPedir.UseVisualStyleBackColor = false;
            this.BtnPedir.Click += new System.EventHandler(this.BtnPedir_Click);
            // 
            // LabelScoreD
            // 
            this.LabelScoreD.AutoSize = true;
            this.LabelScoreD.BackColor = System.Drawing.Color.Transparent;
            this.LabelScoreD.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreD.Location = new System.Drawing.Point(365, 46);
            this.LabelScoreD.Name = "LabelScoreD";
            this.LabelScoreD.Size = new System.Drawing.Size(99, 22);
            this.LabelScoreD.TabIndex = 9;
            this.LabelScoreD.Text = "PUNTAJE";
            // 
            // RtxtScoreD
            // 
            this.RtxtScoreD.BackColor = System.Drawing.Color.Green;
            this.RtxtScoreD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxtScoreD.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtScoreD.Location = new System.Drawing.Point(369, 71);
            this.RtxtScoreD.Name = "RtxtScoreD";
            this.RtxtScoreD.ReadOnly = true;
            this.RtxtScoreD.Size = new System.Drawing.Size(92, 58);
            this.RtxtScoreD.TabIndex = 10;
            this.RtxtScoreD.Text = "";
            // 
            // RtxtScoreP
            // 
            this.RtxtScoreP.BackColor = System.Drawing.Color.Green;
            this.RtxtScoreP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxtScoreP.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtScoreP.Location = new System.Drawing.Point(369, 410);
            this.RtxtScoreP.Name = "RtxtScoreP";
            this.RtxtScoreP.ReadOnly = true;
            this.RtxtScoreP.Size = new System.Drawing.Size(92, 58);
            this.RtxtScoreP.TabIndex = 11;
            this.RtxtScoreP.Text = "";
            // 
            // LabelScoreP
            // 
            this.LabelScoreP.AutoSize = true;
            this.LabelScoreP.BackColor = System.Drawing.Color.Transparent;
            this.LabelScoreP.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreP.Location = new System.Drawing.Point(365, 385);
            this.LabelScoreP.Name = "LabelScoreP";
            this.LabelScoreP.Size = new System.Drawing.Size(99, 22);
            this.LabelScoreP.TabIndex = 12;
            this.LabelScoreP.Text = "PUNTAJE";
            // 
            // LabelGames
            // 
            this.LabelGames.AutoSize = true;
            this.LabelGames.BackColor = System.Drawing.Color.Transparent;
            this.LabelGames.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGames.Location = new System.Drawing.Point(797, 20);
            this.LabelGames.Name = "LabelGames";
            this.LabelGames.Size = new System.Drawing.Size(210, 22);
            this.LabelGames.TabIndex = 13;
            this.LabelGames.Text = "PARTIDAS JUGADAS";
            // 
            // RtxtGames
            // 
            this.RtxtGames.BackColor = System.Drawing.Color.Green;
            this.RtxtGames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxtGames.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtGames.Location = new System.Drawing.Point(854, 46);
            this.RtxtGames.Name = "RtxtGames";
            this.RtxtGames.ReadOnly = true;
            this.RtxtGames.Size = new System.Drawing.Size(92, 37);
            this.RtxtGames.TabIndex = 14;
            this.RtxtGames.Text = "";
            // 
            // LabelWins
            // 
            this.LabelWins.AutoSize = true;
            this.LabelWins.BackColor = System.Drawing.Color.Transparent;
            this.LabelWins.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWins.Location = new System.Drawing.Point(797, 98);
            this.LabelWins.Name = "LabelWins";
            this.LabelWins.Size = new System.Drawing.Size(217, 22);
            this.LabelWins.TabIndex = 15;
            this.LabelWins.Text = "PARTIDAS GANADAS";
            // 
            // LabelFails
            // 
            this.LabelFails.AutoSize = true;
            this.LabelFails.BackColor = System.Drawing.Color.Transparent;
            this.LabelFails.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFails.Location = new System.Drawing.Point(792, 170);
            this.LabelFails.Name = "LabelFails";
            this.LabelFails.Size = new System.Drawing.Size(215, 22);
            this.LabelFails.TabIndex = 16;
            this.LabelFails.Text = "PARTIDAS PERDIDAS";
            // 
            // RtxtWins
            // 
            this.RtxtWins.BackColor = System.Drawing.Color.Green;
            this.RtxtWins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxtWins.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtWins.Location = new System.Drawing.Point(854, 123);
            this.RtxtWins.Name = "RtxtWins";
            this.RtxtWins.ReadOnly = true;
            this.RtxtWins.Size = new System.Drawing.Size(92, 37);
            this.RtxtWins.TabIndex = 17;
            this.RtxtWins.Text = "";
            // 
            // RtxtFails
            // 
            this.RtxtFails.BackColor = System.Drawing.Color.Green;
            this.RtxtFails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxtFails.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtFails.Location = new System.Drawing.Point(854, 195);
            this.RtxtFails.Name = "RtxtFails";
            this.RtxtFails.ReadOnly = true;
            this.RtxtFails.Size = new System.Drawing.Size(92, 37);
            this.RtxtFails.TabIndex = 18;
            this.RtxtFails.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 607);
            this.Controls.Add(this.RtxtFails);
            this.Controls.Add(this.RtxtWins);
            this.Controls.Add(this.LabelFails);
            this.Controls.Add(this.LabelWins);
            this.Controls.Add(this.RtxtGames);
            this.Controls.Add(this.LabelGames);
            this.Controls.Add(this.LabelScoreP);
            this.Controls.Add(this.RtxtScoreP);
            this.Controls.Add(this.RtxtScoreD);
            this.Controls.Add(this.LabelScoreD);
            this.Controls.Add(this.BtnPedir);
            this.Controls.Add(this.BtnPlantar);
            this.Controls.Add(this.RtxtManoP);
            this.Controls.Add(this.LabelP);
            this.Controls.Add(this.LabelD);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.RtxtManoD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox RtxtManoD;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label LabelD;
        private System.Windows.Forms.Label LabelP;
        private System.Windows.Forms.RichTextBox RtxtManoP;
        private System.Windows.Forms.Button BtnPlantar;
        private System.Windows.Forms.Button BtnPedir;
        private System.Windows.Forms.Label LabelScoreD;
        private System.Windows.Forms.RichTextBox RtxtScoreD;
        private System.Windows.Forms.RichTextBox RtxtScoreP;
        private System.Windows.Forms.Label LabelScoreP;
        private System.Windows.Forms.Label LabelGames;
        private System.Windows.Forms.RichTextBox RtxtGames;
        private System.Windows.Forms.Label LabelWins;
        private System.Windows.Forms.Label LabelFails;
        private System.Windows.Forms.RichTextBox RtxtWins;
        private System.Windows.Forms.RichTextBox RtxtFails;
    }
}

