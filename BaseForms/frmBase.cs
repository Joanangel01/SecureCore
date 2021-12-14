using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using ConnectionLibrary;


namespace BaseForms
{
    public partial class FrmBase : Form
    {
        private bool isNewRow = false;

        class ConnectionToDB : Connection  { }

        DataSet dataSet;
       
        private string _nomTaula;
        public string NomTaula
        {
            get => _nomTaula;
            set => _nomTaula = value;
        }

        private string _nomBD;
        public string NomBD
        {
            get => _nomBD;
            set => _nomBD = value;
        }

        public FrmBase()
        {
            InitializeComponent();
        }
      
        private void Form_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            RefreshData();
            InitBindings();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            RefreshData();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            isNewRow = true;

            DataBindingClear();
            ClearFields();
        }

        private void InitBindings()
        {
            DataBindingClear();
            DataBindingAdd();
        }

        private void DataBindingClear()
        {
            foreach (Control control in this.Controls)
            {
                if (control is SwTextBox textBox) textBox.DataBindings.Clear(); 
            }
        }

        private void DataBindingAdd()
        {
            foreach (Control control in this.Controls)
            {
                if (control is SwTextBox textBox)
                {
                    textBox.DataBindings.Add("Text", dataSet.Tables[0], textBox.FieldBinding);
                    textBox.Validated += new EventHandler(this.ValidarTextBox);
                }
            }
        }

        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (((TextBox)sender).DataBindings.Count > 0)
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void AddRow()
        {
            DataRow dataRow = dataSet.Tables[0].NewRow();

            foreach (Control control in this.Controls)
            {
                if (control is SwTextBox txtBox) dataRow[txtBox.FieldBinding] = txtBox.Text;
            }

            dataSet.Tables[0].Rows.Add(dataRow);
            isNewRow = false;

            DataBindingAdd();
        }

        private void UpdateData()
        {
            int updateAmount;
            Connection _connection = new ConnectionToDB();

            if (isNewRow) AddRow();

            if (dataSet.HasChanges())
            {
                updateAmount = _connection.Actualitzar(dataSet, "select * from " + _nomTaula);

                if (updateAmount > 0) MessageBox.Show("Data modified amount: " + updateAmount.ToString());
                else MessageBox.Show("Unable to do the action!");
            }

            else MessageBox.Show("No changes found");
        }

        private void RefreshData()
        {
            Connection _connection = new ConnectionToDB();
            _connection.Conectar();

            dataSet = _connection.PortarTaula(_nomTaula);
            dataGridViewAgencies.DataSource = dataSet.Tables[0];
        }

        private void ClearFields()
        {
            foreach (Control control in this.Controls)
            {
                if (control is SwTextBox txtBox) txtBox.Text = "";
            }
        }
    }
}
