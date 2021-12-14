using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Exemple : Form
    {
        public Exemple()
        {
            InitializeComponent();
        }

        private void Exemple_Load(object sender, EventArgs e)
        {
            var cryRpt = new ReportDocument();
            cryRpt.Load(@"userAdminsitration.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            cryRpt.RecordSelectionFormula = "{Users.idUser} = "+ LoginScreen.idUser;    
            crystalReportViewer1.Refresh();
        }

    }
}
