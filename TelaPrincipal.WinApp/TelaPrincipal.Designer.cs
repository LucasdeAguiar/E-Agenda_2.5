namespace TelaPrincipal.WinApp
{
    partial class TelaPrincipal
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
            this.btnTarefa = new System.Windows.Forms.Button();
            this.btnCompromisso = new System.Windows.Forms.Button();
            this.btnContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            // 
            // btnTarefa
            // 
            this.btnTarefa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTarefa.Location = new System.Drawing.Point(12, 99);
            this.btnTarefa.Name = "btnTarefa";
            this.btnTarefa.Size = new System.Drawing.Size(131, 51);
            this.btnTarefa.TabIndex = 1;
            this.btnTarefa.Text = "Gestão de Tarefas";
            this.btnTarefa.UseVisualStyleBackColor = true;
            this.btnTarefa.Click += new System.EventHandler(this.btnTarefa_Click);
            // 
            // btnCompromisso
            // 
            this.btnCompromisso.Location = new System.Drawing.Point(336, 99);
            this.btnCompromisso.Name = "btnCompromisso";
            this.btnCompromisso.Size = new System.Drawing.Size(131, 51);
            this.btnCompromisso.TabIndex = 2;
            this.btnCompromisso.Text = "Gestão de Compromissos";
            this.btnCompromisso.UseVisualStyleBackColor = true;
            this.btnCompromisso.Click += new System.EventHandler(this.btnCompromisso_Click);
            // 
            // btnContato
            // 
            this.btnContato.Location = new System.Drawing.Point(171, 99);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(131, 51);
            this.btnContato.TabIndex = 3;
            this.btnContato.Text = "Gestão de Contatos";
            this.btnContato.UseVisualStyleBackColor = true;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 239);
            this.Controls.Add(this.btnContato);
            this.Controls.Add(this.btnCompromisso);
            this.Controls.Add(this.btnTarefa);
            this.Controls.Add(this.label1);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTarefa;
        private System.Windows.Forms.Button btnCompromisso;
        private System.Windows.Forms.Button btnContato;
    }
}