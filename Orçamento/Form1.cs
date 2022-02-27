using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orçamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
          
       

        private void imprimirButton_Click(object sender, EventArgs e)
        {

            
            using (var printDocument = new System.Drawing.Printing.PrintDocument())
            {
                

                printDocument.PrintPage += printDocument_PrintPage;
                //printDocument.PrinterSettings.PrinterName = impressoraComboBox.SelectedItem.ToString();
                printDocument.Print();

                
            }
        }

        void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String DadosIMG, DadosEMP, DadosCLI, DadosSER;

            DadosIMG = $"{pictureBox1.Image}";
            DadosEMP = $"\n\n{lblEmpresa.Text} {lblCNPJ.Text}\n\n{lblEndereco.Text}";
            DadosCLI = $"\n\n{lblDadosCliente.Text}\n\n{lblCliente.Text} {txtCliente.Text}\n\n{lblPlaca.Text} {txtPlaca.Text} {lblModelo.Text} {txtModelo.Text} {lblTelefone.Text} {txtTelefone.Text}\n\n{lblData.Text} {dateData.Value} {lblPrevisao.Text} {txtPrevisao.Text}";
            DadosSER = $"\n\n{lblServico.Text}\n\n{lblDescricao.Text}\n\n{lblDescricao.Text}\n\n{lblValorPecas.Text} {txtValorPecas.Text}\n\n{lblValorServico.Text} {txtValorServico.Text}\n\n{lblValorDesconto.Text} {txtValorDesconto.Text}\n\n{lblValorTotal.Text} {txtValorTotal.Text}\n\n{lblParcelamento.Text}\n\n\n____________________________________\n\nAssinatura Aprovação Cliente";
            var printDocument = sender as System.Drawing.Printing.PrintDocument;

            if (printDocument != null)
            {
                using (var font = new Font("Arial", 14))
                using (var brush = new SolidBrush(Color.Black))
                
                {
                    e.Graphics.DrawString(
                        DadosIMG,
                font,
                brush,
                new RectangleF(40, 100, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }

                using (var font = new Font("Arial", 12))
                using (var brush = new SolidBrush(Color.Black))

                {
                    e.Graphics.DrawString(
                        DadosEMP,
                font,
                brush,
                new RectangleF(40, 200, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }

                using (var font = new Font("Arial", 12))
                using (var brush = new SolidBrush(Color.Black))

                {
                    e.Graphics.DrawString(
                        DadosCLI,
                font,
                brush,
                new RectangleF(40, 350, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }

                using (var font = new Font("Arial", 12))
                using (var brush = new SolidBrush(Color.Black))

                {
                    e.Graphics.DrawString(
                        DadosSER,
                font,
                brush,
                new RectangleF(40, 500, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }
            }
        }
    }
}


        