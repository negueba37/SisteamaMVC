namespace AplicacaoResponsiva
{
    partial class FrmPrincipal
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
            this.pMenuLateral = new System.Windows.Forms.Panel();
            this.pMovimento = new System.Windows.Forms.Panel();
            this.OutrasSaidas = new System.Windows.Forms.Button();
            this.btPrrestacaoServ = new System.Windows.Forms.Button();
            this.btVenda = new System.Windows.Forms.Button();
            this.btMovimento = new System.Windows.Forms.Button();
            this.pProduto = new System.Windows.Forms.Panel();
            this.btConsultaServico = new System.Windows.Forms.Button();
            this.btManuntServico = new System.Windows.Forms.Button();
            this.btConsultaProd = new System.Windows.Forms.Button();
            this.btManutProduto = new System.Windows.Forms.Button();
            this.btProduto = new System.Windows.Forms.Button();
            this.pPessoas = new System.Windows.Forms.Panel();
            this.btFornecedor = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btUsuario = new System.Windows.Forms.Button();
            this.btPessoa = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.Panel();
            this.pPlayer = new System.Windows.Forms.Panel();
            this.pChildForm = new System.Windows.Forms.Panel();
            this.pMenuLateral.SuspendLayout();
            this.pMovimento.SuspendLayout();
            this.pProduto.SuspendLayout();
            this.pPessoas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenuLateral
            // 
            this.pMenuLateral.AutoScroll = true;
            this.pMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pMenuLateral.Controls.Add(this.pMovimento);
            this.pMenuLateral.Controls.Add(this.btMovimento);
            this.pMenuLateral.Controls.Add(this.pProduto);
            this.pMenuLateral.Controls.Add(this.btProduto);
            this.pMenuLateral.Controls.Add(this.pPessoas);
            this.pMenuLateral.Controls.Add(this.btPessoa);
            this.pMenuLateral.Controls.Add(this.pLogo);
            this.pMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pMenuLateral.Name = "pMenuLateral";
            this.pMenuLateral.Size = new System.Drawing.Size(222, 561);
            this.pMenuLateral.TabIndex = 0;
            // 
            // pMovimento
            // 
            this.pMovimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pMovimento.Controls.Add(this.OutrasSaidas);
            this.pMovimento.Controls.Add(this.btPrrestacaoServ);
            this.pMovimento.Controls.Add(this.btVenda);
            this.pMovimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMovimento.Location = new System.Drawing.Point(0, 544);
            this.pMovimento.Name = "pMovimento";
            this.pMovimento.Size = new System.Drawing.Size(205, 124);
            this.pMovimento.TabIndex = 6;
            // 
            // OutrasSaidas
            // 
            this.OutrasSaidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutrasSaidas.FlatAppearance.BorderSize = 0;
            this.OutrasSaidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutrasSaidas.ForeColor = System.Drawing.Color.LightGray;
            this.OutrasSaidas.Location = new System.Drawing.Point(0, 80);
            this.OutrasSaidas.Name = "OutrasSaidas";
            this.OutrasSaidas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.OutrasSaidas.Size = new System.Drawing.Size(205, 40);
            this.OutrasSaidas.TabIndex = 5;
            this.OutrasSaidas.Text = "Outas saídas";
            this.OutrasSaidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OutrasSaidas.UseVisualStyleBackColor = true;
            this.OutrasSaidas.Click += new System.EventHandler(this.button12_Click);
            // 
            // btPrrestacaoServ
            // 
            this.btPrrestacaoServ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPrrestacaoServ.FlatAppearance.BorderSize = 0;
            this.btPrrestacaoServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrrestacaoServ.ForeColor = System.Drawing.Color.LightGray;
            this.btPrrestacaoServ.Location = new System.Drawing.Point(0, 40);
            this.btPrrestacaoServ.Name = "btPrrestacaoServ";
            this.btPrrestacaoServ.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btPrrestacaoServ.Size = new System.Drawing.Size(205, 40);
            this.btPrrestacaoServ.TabIndex = 3;
            this.btPrrestacaoServ.Text = "Prestação de serviço";
            this.btPrrestacaoServ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPrrestacaoServ.UseVisualStyleBackColor = true;
            this.btPrrestacaoServ.Click += new System.EventHandler(this.button14_Click);
            // 
            // btVenda
            // 
            this.btVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btVenda.FlatAppearance.BorderSize = 0;
            this.btVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVenda.ForeColor = System.Drawing.Color.LightGray;
            this.btVenda.Location = new System.Drawing.Point(0, 0);
            this.btVenda.Name = "btVenda";
            this.btVenda.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btVenda.Size = new System.Drawing.Size(205, 40);
            this.btVenda.TabIndex = 2;
            this.btVenda.Text = "Venda";
            this.btVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVenda.UseVisualStyleBackColor = true;
            this.btVenda.Click += new System.EventHandler(this.button15_Click);
            // 
            // btMovimento
            // 
            this.btMovimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMovimento.FlatAppearance.BorderSize = 0;
            this.btMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMovimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMovimento.Location = new System.Drawing.Point(0, 504);
            this.btMovimento.Name = "btMovimento";
            this.btMovimento.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btMovimento.Size = new System.Drawing.Size(205, 40);
            this.btMovimento.TabIndex = 5;
            this.btMovimento.Text = "Movimento";
            this.btMovimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMovimento.UseVisualStyleBackColor = true;
            this.btMovimento.Click += new System.EventHandler(this.btMovimento_Click);
            // 
            // pProduto
            // 
            this.pProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pProduto.Controls.Add(this.btConsultaServico);
            this.pProduto.Controls.Add(this.btManuntServico);
            this.pProduto.Controls.Add(this.btConsultaProd);
            this.pProduto.Controls.Add(this.btManutProduto);
            this.pProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pProduto.Location = new System.Drawing.Point(0, 342);
            this.pProduto.Name = "pProduto";
            this.pProduto.Size = new System.Drawing.Size(205, 162);
            this.pProduto.TabIndex = 4;
            // 
            // btConsultaServico
            // 
            this.btConsultaServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btConsultaServico.FlatAppearance.BorderSize = 0;
            this.btConsultaServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultaServico.ForeColor = System.Drawing.Color.LightGray;
            this.btConsultaServico.Location = new System.Drawing.Point(0, 120);
            this.btConsultaServico.Name = "btConsultaServico";
            this.btConsultaServico.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btConsultaServico.Size = new System.Drawing.Size(205, 40);
            this.btConsultaServico.TabIndex = 5;
            this.btConsultaServico.Text = "Consulta de serviço";
            this.btConsultaServico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultaServico.UseVisualStyleBackColor = true;
            this.btConsultaServico.Click += new System.EventHandler(this.btConsultaServico_Click);
            // 
            // btManuntServico
            // 
            this.btManuntServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btManuntServico.FlatAppearance.BorderSize = 0;
            this.btManuntServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btManuntServico.ForeColor = System.Drawing.Color.LightGray;
            this.btManuntServico.Location = new System.Drawing.Point(0, 80);
            this.btManuntServico.Name = "btManuntServico";
            this.btManuntServico.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btManuntServico.Size = new System.Drawing.Size(205, 40);
            this.btManuntServico.TabIndex = 4;
            this.btManuntServico.Text = "Manutenção de serviço";
            this.btManuntServico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btManuntServico.UseVisualStyleBackColor = true;
            this.btManuntServico.Click += new System.EventHandler(this.btManuntServico_Click);
            // 
            // btConsultaProd
            // 
            this.btConsultaProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btConsultaProd.FlatAppearance.BorderSize = 0;
            this.btConsultaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultaProd.ForeColor = System.Drawing.Color.LightGray;
            this.btConsultaProd.Location = new System.Drawing.Point(0, 40);
            this.btConsultaProd.Name = "btConsultaProd";
            this.btConsultaProd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btConsultaProd.Size = new System.Drawing.Size(205, 40);
            this.btConsultaProd.TabIndex = 3;
            this.btConsultaProd.Text = "Consulta Produto";
            this.btConsultaProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultaProd.UseVisualStyleBackColor = true;
            this.btConsultaProd.Click += new System.EventHandler(this.btConsultaProd_Click);
            // 
            // btManutProduto
            // 
            this.btManutProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btManutProduto.FlatAppearance.BorderSize = 0;
            this.btManutProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btManutProduto.ForeColor = System.Drawing.Color.LightGray;
            this.btManutProduto.Location = new System.Drawing.Point(0, 0);
            this.btManutProduto.Name = "btManutProduto";
            this.btManutProduto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btManutProduto.Size = new System.Drawing.Size(205, 40);
            this.btManutProduto.TabIndex = 2;
            this.btManutProduto.Text = "Manutenção de produto";
            this.btManutProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btManutProduto.UseVisualStyleBackColor = true;
            this.btManutProduto.Click += new System.EventHandler(this.btManutProduto_Click);
            // 
            // btProduto
            // 
            this.btProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btProduto.FlatAppearance.BorderSize = 0;
            this.btProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btProduto.Location = new System.Drawing.Point(0, 302);
            this.btProduto.Name = "btProduto";
            this.btProduto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btProduto.Size = new System.Drawing.Size(205, 40);
            this.btProduto.TabIndex = 3;
            this.btProduto.Text = "Produto";
            this.btProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            // 
            // pPessoas
            // 
            this.pPessoas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pPessoas.Controls.Add(this.btFornecedor);
            this.pPessoas.Controls.Add(this.btCliente);
            this.pPessoas.Controls.Add(this.button3);
            this.pPessoas.Controls.Add(this.btUsuario);
            this.pPessoas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPessoas.Location = new System.Drawing.Point(0, 140);
            this.pPessoas.Name = "pPessoas";
            this.pPessoas.Size = new System.Drawing.Size(205, 162);
            this.pPessoas.TabIndex = 2;
            // 
            // btFornecedor
            // 
            this.btFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFornecedor.FlatAppearance.BorderSize = 0;
            this.btFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFornecedor.ForeColor = System.Drawing.Color.LightGray;
            this.btFornecedor.Location = new System.Drawing.Point(0, 120);
            this.btFornecedor.Name = "btFornecedor";
            this.btFornecedor.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btFornecedor.Size = new System.Drawing.Size(205, 40);
            this.btFornecedor.TabIndex = 5;
            this.btFornecedor.Text = "Forecedor";
            this.btFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFornecedor.UseVisualStyleBackColor = true;
            this.btFornecedor.Click += new System.EventHandler(this.button5_Click);
            // 
            // btCliente
            // 
            this.btCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCliente.FlatAppearance.BorderSize = 0;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.ForeColor = System.Drawing.Color.LightGray;
            this.btCliente.Location = new System.Drawing.Point(0, 80);
            this.btCliente.Name = "btCliente";
            this.btCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btCliente.Size = new System.Drawing.Size(205, 40);
            this.btCliente.TabIndex = 4;
            this.btCliente.Text = "Cliente";
            this.btCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(0, 40);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(205, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Funcionário";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btUsuario
            // 
            this.btUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUsuario.FlatAppearance.BorderSize = 0;
            this.btUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.btUsuario.Location = new System.Drawing.Point(0, 0);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btUsuario.Size = new System.Drawing.Size(205, 40);
            this.btUsuario.TabIndex = 2;
            this.btUsuario.Text = "Usuário";
            this.btUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsuario.UseVisualStyleBackColor = true;
            this.btUsuario.Click += new System.EventHandler(this.btUsuario_Click);
            // 
            // btPessoa
            // 
            this.btPessoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPessoa.FlatAppearance.BorderSize = 0;
            this.btPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPessoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPessoa.Location = new System.Drawing.Point(0, 100);
            this.btPessoa.Name = "btPessoa";
            this.btPessoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btPessoa.Size = new System.Drawing.Size(205, 40);
            this.btPessoa.TabIndex = 1;
            this.btPessoa.Text = "Pessoa";
            this.btPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPessoa.UseVisualStyleBackColor = true;
            this.btPessoa.Click += new System.EventHandler(this.btPessoa_Click);
            // 
            // pLogo
            // 
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(205, 100);
            this.pLogo.TabIndex = 0;
            // 
            // pPlayer
            // 
            this.pPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPlayer.Location = new System.Drawing.Point(222, 461);
            this.pPlayer.Name = "pPlayer";
            this.pPlayer.Size = new System.Drawing.Size(722, 100);
            this.pPlayer.TabIndex = 1;
            // 
            // pChildForm
            // 
            this.pChildForm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChildForm.Location = new System.Drawing.Point(222, 0);
            this.pChildForm.Name = "pChildForm";
            this.pChildForm.Size = new System.Drawing.Size(722, 461);
            this.pChildForm.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.pChildForm);
            this.Controls.Add(this.pPlayer);
            this.Controls.Add(this.pMenuLateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pMenuLateral.ResumeLayout(false);
            this.pMovimento.ResumeLayout(false);
            this.pProduto.ResumeLayout(false);
            this.pPessoas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenuLateral;
        private System.Windows.Forms.Panel pMovimento;
        private System.Windows.Forms.Button OutrasSaidas;
        private System.Windows.Forms.Button btPrrestacaoServ;
        private System.Windows.Forms.Button btVenda;
        private System.Windows.Forms.Button btMovimento;
        private System.Windows.Forms.Panel pProduto;
        private System.Windows.Forms.Button btConsultaServico;
        private System.Windows.Forms.Button btManuntServico;
        private System.Windows.Forms.Button btConsultaProd;
        private System.Windows.Forms.Button btManutProduto;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Panel pPessoas;
        private System.Windows.Forms.Button btFornecedor;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btUsuario;
        private System.Windows.Forms.Button btPessoa;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Panel pPlayer;
        private System.Windows.Forms.Panel pChildForm;
    }
}

