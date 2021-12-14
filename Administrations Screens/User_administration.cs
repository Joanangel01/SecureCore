using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForms;
using ConnectionLibrary;
using CustomControls;
namespace Administrations_Screens
{
    public partial class User_administration : FrmBase
    {
        public User_administration(String nomTaula)
        {
            InitializeComponent();
            NomTaula = nomTaula;
        }
    }
}
