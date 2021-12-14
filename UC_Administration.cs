using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sprint2
{
    public partial class UC_Administration : Form
    {
        SecureCoreEntities db;
        bool isNew = false;
        List<UserCategories> cat;
        public UC_Administration(string nomTaula)
        {
            InitializeComponent();
            nomTaula.Replace(nomTaula, "");
        }

        private void UC_Administration_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }

        private void CarregarDades()
        {
            db = new SecureCoreEntities();

            cat = db.UserCategories.ToList();

            dataGridView1.DataSource = cat;
            FerBinding();
        }

        private void FerBinding()
        {
            swTextBox2.Clear();
            swTextBox2.DataBindings.Add("Text", cat, swTextBox2.FieldBinding);
            swTextBox3.Clear();
            swTextBox3.DataBindings.Add("Text", cat, swTextBox3.FieldBinding);
            //swTextBox4.Clear();
            //swTextBox4.DataBindings.Add("Text", cat, swTextBox4.FieldBinding);
        }

        private void UC_Administration_Load(object sender, EventArgs e)
        {
            CarregarDades();
        }

        private void TreuBinding()
        {

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                UserCategories usc = new UserCategories
                {
                    idUserCategory = 1,
                    CodeCategory = swTextBox2.Text,
                    DescCategory = swTextBox3.Text,
                    AccessLevel = int.Parse(swTextBox4.Text)
                };
                db.UserCategories.Add(usc);
            }
            db.SaveChanges();
            MessageBox.Show("Hehe");
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            isNew = true;
            TreuBinding();
        }

        private void SwTextBox4_Validated(object sender, EventArgs e)
        {
            
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
