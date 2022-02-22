
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
            this.TituloEmpresa = new System.Windows.Forms.Label();
            this.TituloOrcamento = new System.Windows.Forms.Label();
            this.NomeEmpresa = new System.Windows.Forms.Label();
            this.CNPJ_Empresa = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TituloEmpresa
            // 
            this.TituloEmpresa.AutoSize = true;
            this.TituloEmpresa.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TituloEmpresa.Location = new System.Drawing.Point(176, 9);
            this.TituloEmpresa.Name = "TituloEmpresa";
            this.TituloEmpresa.Size = new System.Drawing.Size(290, 29);
            this.TituloEmpresa.TabIndex = 0;
            this.TituloEmpresa.Text = "MARTELINHO DE OURO";
            // 
            // TituloOrcamento
            // 
            this.TituloOrcamento.AutoSize = true;
            this.TituloOrcamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloOrcamento.Location = new System.Drawing.Point(254, 60);
            this.TituloOrcamento.Name = "TituloOrcamento";
            this.TituloOrcamento.Size = new System.Drawing.Size(134, 22);
            this.TituloOrcamento.TabIndex = 1;
            this.TituloOrcamento.Text = "ORÇAMENTO";
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.AutoSize = true;
            this.NomeEmpresa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeEmpresa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NomeEmpresa.Location = new System.Drawing.Point(12, 107);
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.Size = new System.Drawing.Size(193, 20);
            this.NomeEmpresa.TabIndex = 2;
            this.NomeEmpresa.Text = "Empresa: Martelinho do Ouro";
            // 
            // CNPJ_Empresa
            // 
            this.CNPJ_Empresa.AutoSize = true;
            this.CNPJ_Empresa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPJ_Empresa.Location = new System.Drawing.Point(12, 140);
            this.CNPJ_Empresa.Name = "CNPJ_Empresa";
            this.CNPJ_Empresa.Size = new System.Drawing.Size(193, 20);
            this.CNPJ_Empresa.TabIndex = 3;
            this.CNPJ_Empresa.Text = "CNPJ: XX.XXX.XXX/XXXX-XX";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(12, 240);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(47, 20);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(177, 242);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(95, 20);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor Orçado:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 211);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 20);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 570);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "_________________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 594);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Assinatura Aprovação Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 234);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição de Orçamento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(514, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(278, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(310, 20);
            this.textBox3.TabIndex = 14;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 178);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(112, 20);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data Orçamento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 665);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.CNPJ_Empresa);
            this.Controls.Add(this.NomeEmpresa);
            this.Controls.Add(this.TituloOrcamento);
            this.Controls.Add(this.TituloEmpresa);
            this.Name = "Form1";
            this.Text = "Orçamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloEmpresa;
        private System.Windows.Forms.Label TituloOrcamento;
        private System.Windows.Forms.Label NomeEmpresa;
        private System.Windows.Forms.Label CNPJ_Empresa;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblData;
    }
}

