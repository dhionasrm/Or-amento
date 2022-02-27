
namespace Orçamento
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
            this.TituloOrcamento = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.dateData = new System.Windows.Forms.DateTimePicker();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPrevisao = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDadosCliente = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtPrevisao = new System.Windows.Forms.TextBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblValorPecas = new System.Windows.Forms.Label();
            this.lblValorServico = new System.Windows.Forms.Label();
            this.lblValorDesconto = new System.Windows.Forms.Label();
            this.txtValorPecas = new System.Windows.Forms.TextBox();
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.lblParcelamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloOrcamento
            // 
            this.TituloOrcamento.AutoSize = true;
            this.TituloOrcamento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloOrcamento.Location = new System.Drawing.Point(253, 70);
            this.TituloOrcamento.Name = "TituloOrcamento";
            this.TituloOrcamento.Size = new System.Drawing.Size(164, 23);
            this.TituloOrcamento.TabIndex = 1;
            this.TituloOrcamento.Text = "ORDEM DE SERVIÇO";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmpresa.Location = new System.Drawing.Point(26, 100);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(193, 20);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "Empresa: Martelinho do Ouro";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(228, 100);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(193, 20);
            this.lblCNPJ.TabIndex = 3;
            this.lblCNPJ.Text = "CNPJ: XX.XXX.XXX/XXXX-XX";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(26, 205);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(47, 20);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa:";
            // 
            // dateData
            // 
            this.dateData.Location = new System.Drawing.Point(140, 230);
            this.dateData.MaxDate = new System.DateTime(2022, 2, 27, 0, 0, 0, 0);
            this.dateData.Name = "dateData";
            this.dateData.Size = new System.Drawing.Size(213, 20);
            this.dateData.TabIndex = 6;
            this.dateData.Value = new System.DateTime(2022, 2, 27, 0, 0, 0, 0);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(26, 625);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(81, 20);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(26, 180);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 20);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(92, 180);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(550, 20);
            this.txtCliente.TabIndex = 12;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(75, 205);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(74, 20);
            this.txtPlaca.TabIndex = 13;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(157, 625);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(110, 20);
            this.txtValorTotal.TabIndex = 14;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(26, 230);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(112, 20);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data Orçamento:";
            // 
            // imprimirButton
            // 
            this.imprimirButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimirButton.Location = new System.Drawing.Point(30, 662);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(237, 27);
            this.imprimirButton.TabIndex = 16;
            this.imprimirButton.Text = "Imprimir";
            this.imprimirButton.UseVisualStyleBackColor = true;
            this.imprimirButton.Click += new System.EventHandler(this.imprimirButton_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(26, 322);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(616, 219);
            this.txtDescricao.TabIndex = 19;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(26, 300);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(178, 19);
            this.lblDescricao.TabIndex = 18;
            this.lblDescricao.Text = "Descrição do Serviço:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Orçamento.Properties.Resources.LOGO_MARTELINHO_DE_OURO_300_x_60px;
            this.pictureBox1.Location = new System.Drawing.Point(176, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 65);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(153, 205);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(59, 20);
            this.lblModelo.TabIndex = 21;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblPrevisao
            // 
            this.lblPrevisao.AutoSize = true;
            this.lblPrevisao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevisao.Location = new System.Drawing.Point(359, 231);
            this.lblPrevisao.Name = "lblPrevisao";
            this.lblPrevisao.Size = new System.Drawing.Size(67, 20);
            this.lblPrevisao.TabIndex = 22;
            this.lblPrevisao.Text = "Previsão:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(427, 205);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 20);
            this.lblTelefone.TabIndex = 23;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(26, 125);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(612, 20);
            this.lblEndereco.TabIndex = 24;
            this.lblEndereco.Text = "Endereço: Avenida Assis Brasil, 5343, Loja 1, Sarandi, Porto Alegre - RS, Telefon" +
    "e: (51)985436688";
            // 
            // lblDadosCliente
            // 
            this.lblDadosCliente.AutoSize = true;
            this.lblDadosCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosCliente.Location = new System.Drawing.Point(288, 155);
            this.lblDadosCliente.Name = "lblDadosCliente";
            this.lblDadosCliente.Size = new System.Drawing.Size(95, 20);
            this.lblDadosCliente.TabIndex = 25;
            this.lblDadosCliente.Text = "Dados Cliente";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(218, 205);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(203, 20);
            this.txtModelo.TabIndex = 26;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(491, 205);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(151, 20);
            this.txtTelefone.TabIndex = 27;
            // 
            // txtPrevisao
            // 
            this.txtPrevisao.Location = new System.Drawing.Point(431, 230);
            this.txtPrevisao.Name = "txtPrevisao";
            this.txtPrevisao.Size = new System.Drawing.Size(211, 20);
            this.txtPrevisao.TabIndex = 28;
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.Location = new System.Drawing.Point(307, 260);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(56, 20);
            this.lblServico.TabIndex = 29;
            this.lblServico.Text = "Serviço";
            // 
            // lblValorPecas
            // 
            this.lblValorPecas.AutoSize = true;
            this.lblValorPecas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPecas.Location = new System.Drawing.Point(26, 550);
            this.lblValorPecas.Name = "lblValorPecas";
            this.lblValorPecas.Size = new System.Drawing.Size(87, 20);
            this.lblValorPecas.TabIndex = 30;
            this.lblValorPecas.Text = "Valor Peças:\r\n";
            // 
            // lblValorServico
            // 
            this.lblValorServico.AutoSize = true;
            this.lblValorServico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorServico.Location = new System.Drawing.Point(26, 575);
            this.lblValorServico.Name = "lblValorServico";
            this.lblValorServico.Size = new System.Drawing.Size(97, 20);
            this.lblValorServico.TabIndex = 31;
            this.lblValorServico.Text = "Valor Serviço:";
            // 
            // lblValorDesconto
            // 
            this.lblValorDesconto.AutoSize = true;
            this.lblValorDesconto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDesconto.Location = new System.Drawing.Point(26, 600);
            this.lblValorDesconto.Name = "lblValorDesconto";
            this.lblValorDesconto.Size = new System.Drawing.Size(108, 20);
            this.lblValorDesconto.TabIndex = 32;
            this.lblValorDesconto.Text = "Valor Desconto:";
            // 
            // txtValorPecas
            // 
            this.txtValorPecas.Location = new System.Drawing.Point(157, 550);
            this.txtValorPecas.Name = "txtValorPecas";
            this.txtValorPecas.Size = new System.Drawing.Size(110, 20);
            this.txtValorPecas.TabIndex = 33;
            // 
            // txtValorServico
            // 
            this.txtValorServico.Location = new System.Drawing.Point(157, 575);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Size = new System.Drawing.Size(110, 20);
            this.txtValorServico.TabIndex = 34;
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Location = new System.Drawing.Point(157, 600);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(110, 20);
            this.txtValorDesconto.TabIndex = 35;
            // 
            // lblParcelamento
            // 
            this.lblParcelamento.AutoSize = true;
            this.lblParcelamento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelamento.ForeColor = System.Drawing.Color.Red;
            this.lblParcelamento.Location = new System.Drawing.Point(270, 662);
            this.lblParcelamento.Name = "lblParcelamento";
            this.lblParcelamento.Size = new System.Drawing.Size(368, 20);
            this.lblParcelamento.TabIndex = 36;
            this.lblParcelamento.Text = "PARCELAMENTO EM ATÉ 3X COM CARTÃO DE CRÉDITO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 749);
            this.Controls.Add(this.lblParcelamento);
            this.Controls.Add(this.txtValorDesconto);
            this.Controls.Add(this.txtValorServico);
            this.Controls.Add(this.txtValorPecas);
            this.Controls.Add(this.lblValorDesconto);
            this.Controls.Add(this.lblValorServico);
            this.Controls.Add(this.lblValorPecas);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.txtPrevisao);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblDadosCliente);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblPrevisao);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.dateData);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.TituloOrcamento);
            this.Name = "Form1";
            this.Text = "Orçamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TituloOrcamento;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.DateTimePicker dateData;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button imprimirButton;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPrevisao;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDadosCliente;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtPrevisao;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblValorPecas;
        private System.Windows.Forms.Label lblValorServico;
        private System.Windows.Forms.Label lblValorDesconto;
        private System.Windows.Forms.TextBox txtValorPecas;
        private System.Windows.Forms.TextBox txtValorServico;
        private System.Windows.Forms.TextBox txtValorDesconto;
        private System.Windows.Forms.Label lblParcelamento;
    }
}

