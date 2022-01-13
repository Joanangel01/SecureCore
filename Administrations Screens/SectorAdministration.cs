using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Administrations_Screens
{
    public partial class SectorAdministration : Form
    {
        SectorsEntities dbs;
        bool isNew = false;
        List<Sectors> sectorsList;

        public SectorAdministration(string nomTaula)
        {
            InitializeComponent();
            nomTaula.Replace(nomTaula, "");
        }

        private void SectorsAdministration_Load(object sender, EventArgs e)
        {
            CarregarDades(true);
        }

        private void CarregarDades(bool hasNew)
        {
            dbs = new SectorsEntities();

            sectorsList = dbs.Sectors.ToList();

            dataGridView1.DataSource = sectorsList;
            if (hasNew)
            {
                FerBinding();
            }
        }

        private void FerBinding()
        {
            swTextBox2.Clear();
            swTextBox2.DataBindings.Add("Text", sectorsList, swTextBox2.FieldBinding);
            swTextBox3.Clear();
            swTextBox3.DataBindings.Add("Text", sectorsList, swTextBox3.FieldBinding);
            swTextBox4.Clear();
            swTextBox4.DataBindings.Add("Text", sectorsList, swTextBox4.FieldBinding);
            swTextBox1.Clear();
            swTextBox1.DataBindings.Add("Number", sectorsList, swTextBox1.FieldBinding);
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                Sectors sector = new Sectors
                {
                    idSector = 1,
                    CodeSector = swTextBox2.Text,
                    DescSector = swTextBox3.Text,
                    Remarks = swTextBox4.Text,
                    idRegion = int.Parse(swTextBox1.Text)
                };
                dbs.Sectors.Add(sector);
            }
            dbs.SaveChanges();
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
            swTextBox1.Clear();
            swTextBox1.DataBindings.Clear();
        }
    }
}
