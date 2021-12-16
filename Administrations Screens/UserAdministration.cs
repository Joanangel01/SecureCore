using System;
using System.Collections.Generic;
using System.ComponentModel;

using BaseForms;

namespace Administrations_Screens
{
    public partial class UserAdministration : FrmBase
    {
        public UserAdministration(string nomTaula)
        {
            InitializeComponent();
            NomTaula = nomTaula;
        }
    }
}
