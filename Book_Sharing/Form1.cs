using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Sharing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BindingSource bindingSource1 = new BindingSource();
            var context = new BookSharingEntities();
            var query = context.KSIAZKA.ToList();
            bindingSource1.DataSource = query;
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
