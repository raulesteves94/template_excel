namespace TesteExcelNPOI
{
    partial class FormPrincipal
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
            this.btnGerarCatalogo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.saveFileDialogCatalogo = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnGerarCatalogo
            // 
            this.btnGerarCatalogo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGerarCatalogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerarCatalogo.Location = new System.Drawing.Point(81, 41);
            this.btnGerarCatalogo.Name = "btnGerarCatalogo";
            this.btnGerarCatalogo.Size = new System.Drawing.Size(172, 24);
            this.btnGerarCatalogo.TabIndex = 0;
            this.btnGerarCatalogo.Text = "Gerar Catálogo de Produtos";
            this.btnGerarCatalogo.UseVisualStyleBackColor = false;
            this.btnGerarCatalogo.Click += new System.EventHandler(this.btnGerarCatalogo_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSair.Location = new System.Drawing.Point(81, 88);
            this.btnSair.Name = "btnSair";
            this.btnSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair.Size = new System.Drawing.Size(172, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 155);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerarCatalogo);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarCatalogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCatalogo;
    }
}

