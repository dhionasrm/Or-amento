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
            String Dados;

            Dados = $"{TituloEmpresa.Text}\n\n\nORÇAMENTO\nEmpresa: Martelinho do Ouro\nCNPJ: XX.XXX.XXX/XXXX-XX\nData Orçamento:{dateTimePicker1.MaxDate}\nCliente: {textBox1.Text}\nPlaca: {textBox2.Text} Valor Orçado: {textBox3.Text}\nDescrição do Orçamento:\n{txtDesc.Text}\n_________________________________________\nAssinatura Aprovação Cliente";

            var printDocument = sender as System.Drawing.Printing.PrintDocument;

            if (printDocument != null)
            {
                using (var font = new Font("Times New Roman", 14))
                using (var brush = new SolidBrush(Color.Black))
                
                {
                    e.Graphics.DrawString(
                        Dados,
                font,
                brush,
                new RectangleF(20, 20, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
                }
            }
        }
    }
}


        