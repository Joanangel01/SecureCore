﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class SwCodi : UserControl
    {
        public SwCodi()
        {
            InitializeComponent();
        }

        private bool _required;
        public bool Required
        {
            get { return _required; }
            set { _required = value; }
        }

        private string _nomTaula;

        public string NomTaula
        {
            get { return _nomTaula; }
            set { _nomTaula = value; }
        }

        private string _nomCodi;

        public string NomCodi
        {
            get { return _nomCodi; }
            set { _nomCodi = value; }
        }

        private string _nomDesc;

        public string NomDesc
        {
            get { return _nomDesc; }
            set { _nomDesc = value; }
        }

        private string _nomID;

        public string NomID
        {
            get { return _nomID; }
            set { _nomID = value; }
        }

        private string _formCS;

        public string FormCS
        {
            get { return _formCS; }
            set { _formCS = value; }
        }

        private string _classeCS;

        public string ClasseCS
        {
            get { return _classeCS; }
            set { _classeCS = value; }
        }

        private string _controlId;

        public string ControlID
        {
            get { return _controlId; }
            set { _controlId = value; }
        }

        private void TextBoxCode_Leave(object sender, EventArgs e)
        {
            if (_required && textBoxCode.Text.Length > 0) textBoxDesc.Text = ValidaCodi(textBoxCode.Text);
            else textBoxCode.Focus();
        }

        private string ValidaCodi(string code)
        {
            string text = "";

            
            return text;
        }

   

        private void TextBoxCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                try
                {
                    Assembly ensamblat = Assembly.LoadFrom($@"{_classeCS}.dll");

                    Type tipus = ensamblat.GetType($"{_classeCS}.{_formCS}");
                    Object dllBD = Activator.CreateInstance(tipus);

                    ((Form)dllBD).Show();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Reflection error: " + exception.ToString());
                }
            }
        }
    }
}