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
    public partial class DocumentQuery : Form
    {
        public DocumentQuery()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.Fill(this.pisLabUpdated.DataTable1, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.Fill(this.pisLabUpdated.DataTable1, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
