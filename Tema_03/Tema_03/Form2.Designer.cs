namespace Tema_03
{
    partial class Form2
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
            this.txtBloc = new System.Windows.Forms.TextBox();
            this.txtGuardar = new System.Windows.Forms.Button();
            this.txtAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BLOC DE NOTAS";
            // 
            // txtBloc
            // 
            this.txtBloc.Location = new System.Drawing.Point(27, 56);
            this.txtBloc.Multiline = true;
            this.txtBloc.Name = "txtBloc";
            this.txtBloc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBloc.Size = new System.Drawing.Size(371, 201);
            this.txtBloc.TabIndex = 1;
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(94, 290);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(96, 33);
            this.txtGuardar.TabIndex = 2;
            this.txtGuardar.Text = "GUARDAR";
            this.txtGuardar.UseVisualStyleBackColor = true;
            // 
            // txtAbrir
            // 
            this.txtAbrir.Location = new System.Drawing.Point(223, 290);
            this.txtAbrir.Name = "txtAbrir";
            this.txtAbrir.Size = new System.Drawing.Size(96, 33);
            this.txtAbrir.TabIndex = 3;
            this.txtAbrir.Text = "ABRIR";
            this.txtAbrir.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 356);
            this.Controls.Add(this.txtAbrir);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.txtBloc);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBloc;
        private System.Windows.Forms.Button txtGuardar;
        private System.Windows.Forms.Button txtAbrir;
    }
}