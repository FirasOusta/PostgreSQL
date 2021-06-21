using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreSQL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                PersonDbContext personDbContext = new PersonDbContext();
                var persons = personDbContext.Persons.Select(s => s.Name).ToList();
                lstNames.DataSource = persons;
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurred");
            }
        }
    }
}
