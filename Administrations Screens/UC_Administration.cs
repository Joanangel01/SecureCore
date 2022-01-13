using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Administrations_Screens
{
    public partial class UC_Administration : Form
    {
        SecureCoreEntities db;
        bool isNew = false;
        List<UserCategories> categoriesList;

        public UC_Administration(string nomTaula)
        {
            InitializeComponent();
            nomTaula.Replace(nomTaula, ""); 
        }

        private void UC_Administration_Load(object sender, EventArgs e)
        {
            CarregarDades(true);
        }

        private void CarregarDades(bool hasNew)
        {
            db = new SecureCoreEntities();

            categoriesList = db.UserCategories.ToList();

            dataGridView1.DataSource = categoriesList;
            if (hasNew)
            {
                FerBinding();
            }
        }

        private void FerBinding()
        {
            swTextBox2.Clear();
            swTextBox2.DataBindings.Add("Text", categoriesList, swTextBox2.FieldBinding);
            swTextBox3.Clear();
            swTextBox3.DataBindings.Add("Text", categoriesList, swTextBox3.FieldBinding);
            swTextBox4.Clear();
            swTextBox4.DataBindings.Add("Text", categoriesList, swTextBox4.FieldBinding);
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
            MessageBox.Show("Canvis realitzats!");
            CarregarDades(false);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            isNew = true;
            TreuBinding();
        }

        private void TreuBinding()
        {
            swTextBox2.Clear();
            swTextBox2.DataBindings.Clear();
            swTextBox3.Clear();
            swTextBox3.DataBindings.Clear();
            swTextBox4.Clear();
            swTextBox4.DataBindings.Clear();
        }
    }
}
