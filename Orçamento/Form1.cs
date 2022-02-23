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
            //printDocument.Print();
            using (var pd = new System.Drawing.Printing.PrintDocument())
            {
                //pd.PrinterSettings.PrinterName = impressoraComboBox.SelectedItem.ToString();
                pd.PrintPage += printDocument_PrintPage;
                pd.Print();
            }
        }


        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (var font = new Font("Times New Roman", 14))
            using (var brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(TituloEmpresa.Text, font, brush, e.MarginBounds);
                
            }

            using (var font = new Font("Times New Roman", 14))
            using (var brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(TituloEmpresa.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(TituloOrcamento.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(NomeEmpresa.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(CNPJ_Empresa.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(lblData.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(dateTimePicker1.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(lblCliente.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(textBox1.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(textBox2.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(textBox3.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(lblDesc.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(label9.Text, font, brush, e.MarginBounds);
                e.Graphics.DrawString(label10.Text, font, brush, e.MarginBounds);

            }

            /*var image = new Bitmap(this.Width, this.Height);
            var graphics = Graphics.FromImage(image);
            graphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            e.Graphics.DrawImage(image, 20, 20);*/   
        }

        
    }
}
