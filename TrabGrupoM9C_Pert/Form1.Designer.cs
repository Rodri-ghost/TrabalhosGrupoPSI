namespace TrabGrupoM9C_Pert
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaior = new System.Windows.Forms.Button();
            this.txtVet = new System.Windows.Forms.TextBox();
            this.lblMaior = new System.Windows.Forms.Label();
            this.btnSalv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // btnMaior
            // 
            this.btnMaior.Location = new System.Drawing.Point(118, 145);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(100, 23);
            this.btnMaior.TabIndex = 1;
            this.btnMaior.Text = "Maior";
            this.btnMaior.UseVisualStyleBackColor = true;
            this.btnMaior.Click += new System.EventHandler(this.btnMaior_Click);
            // 
            // txtVet
            // 
            this.txtVet.Location = new System.Drawing.Point(118, 72);
            this.txtVet.Name = "txtVet";
            this.txtVet.Size = new System.Drawing.Size(100, 20);
            this.txtVet.TabIndex = 2;
            // 
            // lblMaior
            // 
            this.lblMaior.AutoSize = true;
            this.lblMaior.Location = new System.Drawing.Point(151, 207);
            this.lblMaior.Name = "lblMaior";
            this.lblMaior.Size = new System.Drawing.Size(33, 13);
            this.lblMaior.TabIndex = 3;
            this.lblMaior.Text = "Maior";
            // 
            // btnSalv
            // 
            this.btnSalv.Location = new System.Drawing.Point(253, 70);
            this.btnSalv.Name = "btnSalv";
            this.btnSalv.Size = new System.Drawing.Size(100, 23);
            this.btnSalv.TabIndex = 4;
            this.btnSalv.Text = "salvar";
            this.btnSalv.UseVisualStyleBackColor = true;
            this.btnSalv.Click += new System.EventHandler(this.btnSalv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 324);
            this.Controls.Add(this.btnSalv);
            this.Controls.Add(this.lblMaior);
            this.Controls.Add(this.txtVet);
            this.Controls.Add(this.btnMaior);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaior;
        private System.Windows.Forms.TextBox txtVet;
        private System.Windows.Forms.Label lblMaior;
        private System.Windows.Forms.Button btnSalv;
    }
}

