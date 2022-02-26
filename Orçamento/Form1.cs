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
            String Dados, Dados1, Dados2, Dados3;

            Dados = $"\n\nEmpresa: Martelinho do Ouro\n\nCNPJ: XX.XXX.XXX/XXXX-XX\n\nData Orçamento:{dateTimePicker1.MaxDate}\n\nCliente: {textBox1.Text}\n\nPlaca: {textBox2.Text} Valor Orçado: {textBox3.Text}\n\nDescrição do Orçamento:\n\n{txtDesc.Text}";
            Dados1 = $"{pictureBox1.Image}\n{TituloEmpresa.Text}";
            Dados2 = $"\n\nORÇAMENTO";
            Dados3 = $"\n\n\n____________________________________\n\nAssinatura Aprovação Cliente";
            var printDocument = sender as System.Drawing.Printing.PrintDocument;

            if (printDocument != null)
            {
                using (var font = new Font("Arial", 14))
                using (var brush = new SolidBrush(Color.Black))
                
                {
                    e.Graphics.DrawString(
                        Dados,
                font,
                brush,
                new RectangleF(60, 300, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }

                using (var font = new Font("Arial", 14))
                using (var brush = new SolidBrush(Color.Black))

                {
                    e.Graphics.DrawString(
                        Dados1,
                font,
                brush,
                new RectangleF(270, 150, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }

                using (var font = new Font("Arial", 14))
                using (var brush = new SolidBrush(Color.Black))

                {
                    e.Graphics.DrawString(
                        Dados2,
                font,
                brush,
                new RectangleF(310, 180, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }

                using (var font = new Font("Arial", 14))
                using (var brush = new SolidBrush(Color.Black))

                {
                    e.Graphics.DrawString(
                        Dados3,
                font,
                brush,
                new RectangleF(120, 700, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }
            }
        }
    }
}


        