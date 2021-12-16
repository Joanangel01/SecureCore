using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class DataGridViewForm : Form
    {
        private readonly DataSet dataSet;
        private readonly SwCodi swCodi;
        
        private DataRow _selectedDataRow;
        public DataRow SelectedDataRow
        {
            get =>  _selectedDataRow; 
            set => _selectedDataRow = value; 
        }

        public DataGridViewForm(DataSet dts, SwCodi swCodiControl)
        {
            dataSet = dts;
            swCodi = swCodiControl;
            InitializeComponent();

            dataGridView.DataSource = dts.Tables[0];
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            ReturnSelectedRow();
        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ReturnSelectedRow();
        }

        private void ReturnSelectedRow()
        {
            int index = dataGridView.CurrentCell.RowIndex;

            _selectedDataRow = dataSet.Tables[0].Rows[index];

            swCodi.textBoxCode.Text = _selectedDataRow.ItemArray[0].ToString();
            swCodi.textBoxDesc.Text = _selectedDataRow.ItemArray[1].ToString();

            this.Close();
        }
    }
}
