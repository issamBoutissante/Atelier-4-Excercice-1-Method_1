using System;
using System.Windows.Forms;

namespace Atelier_4_Excercice_1
{
    public partial class Form1 : Form
    {
        Products products;
        Employes employes;
        Customers customers;

        public Form1()
        {
            InitializeComponent();
        }
        private void employesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employes = new Employes();
            Afficher_form(employes);
        }       
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products = new Products();
            Afficher_form(products);
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customers = new Customers();
            Afficher_form(customers);
        }
        void Afficher_form(Form form)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
