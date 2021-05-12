using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void документToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            document.ShowDialog();
        }

        private void замовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.ShowDialog();
        }

        private void накладнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.ShowDialog();
        }

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ShowDialog();
        }

        private void акціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action action = new Action();
            action.ShowDialog();
        }

        private void типАкціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfAction typeOfAction = new TypeOfAction();
            typeOfAction.ShowDialog();
        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            personal.ShowDialog();
        }

        private void клієнтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.ShowDialog();
        }

        private void компаніяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog();
        }

        private void приватнийПідприємецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enterprenuer enterprenuer = new Enterprenuer();
            enterprenuer.ShowDialog();
        }

        private void документиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DocumentQuery documentQuery = new DocumentQuery();
            documentQuery.ShowDialog();
        }

        private void замовленняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderQuery orderQuery = new OrderQuery();
            orderQuery.ShowDialog();
        }

        private void накладнаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InvoiceQuery query = new InvoiceQuery();
            query.ShowDialog();
        }

        private void товарToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductQuery query = new ProductQuery();
            query.ShowDialog();
        }

        private void акціяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActionQuery query = new ActionQuery();
            query.ShowDialog();
        }

        private void типАкціїToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TypeOfActionQuery query = new TypeOfActionQuery();
            query.ShowDialog();
        }

        private void персоналToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonalQuery query = new PersonalQuery();
            query.ShowDialog();
        }

        private void клієнтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClientQuery query = new ClientQuery();
            query.ShowDialog();
        }

        private void приватнийПідприємецьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EnterprenuerQuery query = new EnterprenuerQuery();
            query.ShowDialog();
        }

        private void компаніяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CompanyQuery query = new CompanyQuery();
            query.ShowDialog();
        }

        private void документиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentsReport documents = new DocumentsReport();
            documents.ShowDialog();
        }

        private void звітПроКористувачівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientReport client = new ClientReport();
            client.ShowDialog();
        }

        private void звітПроПродукціюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductReport product = new ProductReport();
            product.ShowDialog();
        }

        private void звітПроЗамовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderReport order = new OrderReport();
            order.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutMe open = new AboutMe();
            open.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
