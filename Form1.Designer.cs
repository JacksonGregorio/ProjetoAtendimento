namespace ProjetoAtendimento
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGerarSenha;
        private System.Windows.Forms.Button btnAdicionarGuiche;
        private System.Windows.Forms.Button btnChamarSenha;
        private System.Windows.Forms.Button btnListarGuiches;
        private System.Windows.Forms.Button btnListarAtendimentos;
        private System.Windows.Forms.ListBox lstSenhas;
        private System.Windows.Forms.ListBox lstGuiches;
        private System.Windows.Forms.TextBox txtGuicheId;
        private System.Windows.Forms.Label lblGuicheId;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGerarSenha = new System.Windows.Forms.Button();
            this.btnAdicionarGuiche = new System.Windows.Forms.Button();
            this.btnChamarSenha = new System.Windows.Forms.Button();
            this.btnListarGuiches = new System.Windows.Forms.Button();
            this.btnListarAtendimentos = new System.Windows.Forms.Button();
            this.lstSenhas = new System.Windows.Forms.ListBox();
            this.lstGuiches = new System.Windows.Forms.ListBox();
            this.txtGuicheId = new System.Windows.Forms.TextBox();
            this.lblGuicheId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerarSenha
            // 
            this.btnGerarSenha.Location = new System.Drawing.Point(12, 12);
            this.btnGerarSenha.Name = "btnGerarSenha";
            this.btnGerarSenha.Size = new System.Drawing.Size(100, 23);
            this.btnGerarSenha.TabIndex = 0;
            this.btnGerarSenha.Text = "Gerar Senha";
            this.btnGerarSenha.UseVisualStyleBackColor = true;
            this.btnGerarSenha.Click += new System.EventHandler(this.btnGerarSenha_Click);
            // 
            // btnAdicionarGuiche
            // 
            this.btnAdicionarGuiche.Location = new System.Drawing.Point(118, 12);
            this.btnAdicionarGuiche.Name = "btnAdicionarGuiche";
            this.btnAdicionarGuiche.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionarGuiche.TabIndex = 1;
            this.btnAdicionarGuiche.Text = "Adicionar Guichê";
            this.btnAdicionarGuiche.UseVisualStyleBackColor = true;
            this.btnAdicionarGuiche.Click += new System.EventHandler(this.btnAdicionarGuiche_Click);
            // 
            // btnChamarSenha
            // 
            this.btnChamarSenha.Location = new System.Drawing.Point(224, 12);
            this.btnChamarSenha.Name = "btnChamarSenha";
            this.btnChamarSenha.Size = new System.Drawing.Size(100, 23);
            this.btnChamarSenha.TabIndex = 2;
            this.btnChamarSenha.Text = "Chamar Senha";
            this.btnChamarSenha.UseVisualStyleBackColor = true;
            this.btnChamarSenha.Click += new System.EventHandler(this.btnChamarSenha_Click);
            // 
            // btnListarGuiches
            // 
            this.btnListarGuiches.Location = new System.Drawing.Point(12, 41);
            this.btnListarGuiches.Name = "btnListarGuiches";
            this.btnListarGuiches.Size = new System.Drawing.Size(100, 23);
            this.btnListarGuiches.TabIndex = 3;
            this.btnListarGuiches.Text = "Listar Guichês";
            this.btnListarGuiches.UseVisualStyleBackColor = true;
            this.btnListarGuiches.Click += new System.EventHandler(this.btnListarGuiches_Click);
            // 
            // btnListarAtendimentos
            // 
            this.btnListarAtendimentos.Location = new System.Drawing.Point(118, 41);
            this.btnListarAtendimentos.Name = "btnListarAtendimentos";
            this.btnListarAtendimentos.Size = new System.Drawing.Size(100, 23);
            this.btnListarAtendimentos.TabIndex = 4;
            this.btnListarAtendimentos.Text = "Listar Atendimentos";
            this.btnListarAtendimentos.UseVisualStyleBackColor = true;
            this.btnListarAtendimentos.Click += new System.EventHandler(this.btnListarAtendimentos_Click);
            // 
            // lstSenhas
            // 
            this.lstSenhas.FormattingEnabled = true;
            this.lstSenhas.Location = new System.Drawing.Point(12, 70);
            this.lstSenhas.Name = "lstSenhas";
            this.lstSenhas.Size = new System.Drawing.Size(312, 95);
            this.lstSenhas.TabIndex = 5;
            // 
            // lstGuiches
            // 
            this.lstGuiches.FormattingEnabled = true;
            this.lstGuiches.Location = new System.Drawing.Point(12, 171);
            this.lstGuiches.Name = "lstGuiches";
            this.lstGuiches.Size = new System.Drawing.Size(312, 95);
            this.lstGuiches.TabIndex = 6;
            // 
            // txtGuicheId
            // 
            // 
            this.txtGuicheId.Location = new System.Drawing.Point(274, 41);
            this.txtGuicheId.Name = "txtGuicheId";
            this.txtGuicheId.Size = new System.Drawing.Size(50, 20);
            this.txtGuicheId.TabIndex = 7;
            // 
            // lblGuicheId
            // 
            this.lblGuicheId.AutoSize = true;
            this.lblGuicheId.Location = new System.Drawing.Point(224, 44);
            this.lblGuicheId.Name = "lblGuicheId";
            this.lblGuicheId.Size = new System.Drawing.Size(54, 13);
            this.lblGuicheId.TabIndex = 8;
            this.lblGuicheId.Text = "Guichê ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 278);
            this.Controls.Add(this.lblGuicheId);
            this.Controls.Add(this.txtGuicheId);
            this.Controls.Add(this.lstGuiches);
            this.Controls.Add(this.lstSenhas);
            this.Controls.Add(this.btnListarAtendimentos);
            this.Controls.Add(this.btnListarGuiches);
            this.Controls.Add(this.btnChamarSenha);
            this.Controls.Add(this.btnAdicionarGuiche);
            this.Controls.Add(this.btnGerarSenha);
            this.Name = "Form1";
            this.Text = "Gerenciamento de Senhas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}
