namespace Correos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPara = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAsunto = new System.Windows.Forms.TextBox();
            this.txbCC = new System.Windows.Forms.TextBox();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.BotonEnvar = new System.Windows.Forms.Button();
            this.txbPara = new System.Windows.Forms.TextBox();
            this.TxMensaje = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelPara
            // 
            this.labelPara.AutoSize = true;
            this.labelPara.Location = new System.Drawing.Point(13, 38);
            this.labelPara.Name = "labelPara";
            this.labelPara.Size = new System.Drawing.Size(36, 15);
            this.labelPara.TabIndex = 0;
            this.labelPara.Text = "Para :";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(280, 38);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(29, 15);
            this.labelCC.TabIndex = 0;
            this.labelCC.Text = "CC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Asunto :";
            // 
            // txbAsunto
            // 
            this.txbAsunto.Location = new System.Drawing.Point(80, 90);
            this.txbAsunto.Name = "txbAsunto";
            this.txbAsunto.Size = new System.Drawing.Size(470, 23);
            this.txbAsunto.TabIndex = 1;
            // 
            // txbCC
            // 
            this.txbCC.Location = new System.Drawing.Point(315, 35);
            this.txbCC.Name = "txbCC";
            this.txbCC.Size = new System.Drawing.Size(235, 23);
            this.txbCC.TabIndex = 1;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(12, 145);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(57, 15);
            this.labelMensaje.TabIndex = 2;
            this.labelMensaje.Text = "Mensaje :";
            // 
            // BotonEnvar
            // 
            this.BotonEnvar.Location = new System.Drawing.Point(475, 345);
            this.BotonEnvar.Name = "BotonEnvar";
            this.BotonEnvar.Size = new System.Drawing.Size(75, 23);
            this.BotonEnvar.TabIndex = 3;
            this.BotonEnvar.Text = "Enviar";
            this.BotonEnvar.UseVisualStyleBackColor = true;
            this.BotonEnvar.Click += new System.EventHandler(this.BotonEnvar_Click);
            // 
            // txbPara
            // 
            this.txbPara.Location = new System.Drawing.Point(80, 35);
            this.txbPara.Name = "txbPara";
            this.txbPara.Size = new System.Drawing.Size(194, 23);
            this.txbPara.TabIndex = 1;
            // 
            // TxMensaje
            // 
            this.TxMensaje.Location = new System.Drawing.Point(80, 145);
            this.TxMensaje.Name = "TxMensaje";
            this.TxMensaje.Size = new System.Drawing.Size(470, 194);
            this.TxMensaje.TabIndex = 4;
            this.TxMensaje.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 380);
            this.Controls.Add(this.TxMensaje);
            this.Controls.Add(this.txbPara);
            this.Controls.Add(this.BotonEnvar);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.txbCC);
            this.Controls.Add(this.txbAsunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCC);
            this.Controls.Add(this.labelPara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPara;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAsunto;
        private System.Windows.Forms.TextBox txbCC;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Button BotonEnvar;
        private System.Windows.Forms.TextBox txbPara;
        private System.Windows.Forms.RichTextBox TxMensaje;
    }
}

