using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public class SwTextBox : TextBox
    {
        public SwTextBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // swTextBox
            // 
            this.Enter += new System.EventHandler(this.SwTextBox_Enter);
            this.Leave += new System.EventHandler(this.SwTextBox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SwTextBox_Validating);
            this.ResumeLayout(false);
        }

        public enum TipusDada
        {
            num,
            text,
            code,
        }

        private TipusDada _DadaPermesa;
        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }

            set { _DadaPermesa = value; }
        }

        private bool _empty;
            
        public bool Empty
        {
            get { return _empty; }

            set { _empty = value; }
        }

        private bool _foreignKey;

        public bool ForeignKey
        {
            get { return _foreignKey; }

            set {_foreignKey = value; }
        }

        private string _fieldBinding;

        public string FieldBinding
        {
            get { return _fieldBinding; }

            set { _fieldBinding = value; }
        }

        private bool ValidateValues(string text)
        {
            Regex regexNum = new Regex(@"^\d*$");
            Regex regexCode = new Regex(@"^[A-Z]{4}-\d{3}/[1,3,5,7,9][AEIOU]$");

            bool resultat;


            switch (_DadaPermesa)
            {
                case TipusDada.num:
                    resultat = regexNum.IsMatch(text);
                    break;
                case TipusDada.text:
                    resultat = true;
                    break;
                case TipusDada.code:
                    resultat = regexCode.IsMatch(text);
                    break;
                default:
                    resultat = false;
                    break;
            }
            return resultat;
        }

        private void SwTextBox_Enter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightGray;
        }

        private void SwTextBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = default;
        }

        private void SwTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is SwTextBox)
                {
                    if (control.Name == _fieldBinding)
                    {
                        if (ValidateValues(this.Text)) control.Text = this.Text;
                        else{
                            control.Text = "";
                            if (this.Text.Length > 0)
                            {
                                this.Text = "";
                                this.Focus();
                            }
                        }
                    }
                }
            }
           
        }
    }
}
