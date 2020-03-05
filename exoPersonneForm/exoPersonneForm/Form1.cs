using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exoPersonneForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Personne> mesPersonnes = new List<Personne>();


            
            for (int i = 1; i < 6; i++)
            {
                mesPersonnes.Add(new Personne("Nom"+i,"Prneom"+i,new DateTime(2000,1,i)));
            }

            personneBindingSource.DataSource = mesPersonnes;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
