using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Windows.Forms;

namespace SecureCore
{
    public partial class UserCard : Form
    {
        public UserCard()
        {
            InitializeComponent();
        }

        private void UserCard_Load(object sender, EventArgs e)
        {
            var cryRpt = new ReportDocument();
            cryRpt.Load(@"userAdminsitration.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            cryRpt.RecordSelectionFormula = "{Users.idUser} = "+ LoginScreen.idUser;    
            crystalReportViewer1.Refresh();
        }

    }
}
