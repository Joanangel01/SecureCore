using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class AppLauncher : UserControl
    {
        public AppLauncher()
        {
            InitializeComponent();
        }

        private string _classe;
        public string Classe
        {
            get { return _classe; }
                
            set { _classe = value; }
        }

        private string _form;
        public string Form
        {
            get { return _form; }

            set { _form = value; }
        }
        private string _nomTaula;
        public string NomTaula
        {
            get { return _nomTaula; }

            set { _nomTaula = value; }
        }

        private string _labelText;
        public string LabelText
        {
            get { return _labelText; }

            set { _labelText = value; }
        }

        private string _imageUrl;
        public string ImageUrl
        {
            get { return _imageUrl; }

            set { _imageUrl = value; }
        }

        private int _range;
        public int Range
        {
            get { return _range; }

            set { _range = value; }
        }

        private void AppLauncher_Load(object sender, EventArgs e)
        {
            LoadLabel();
            LoadIcon();
            
        }

        void LoadLabel()
        {
            button.Text = _labelText;
        }

        
        void LoadIcon()
        {
            if (_imageUrl is null || _imageUrl.Length == 0) _imageUrl = "https://i.blogs.es/594843/chrome/450_1000.jpg";
            WebRequest request = WebRequest.Create(_imageUrl);
            try
            {
                using (WebResponse response = request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                {
                    Bitmap original = (Bitmap)Bitmap.FromStream(stream);
                    button.Image = ResizeBitmap(original);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("LoadIcon error: " + exception.ToString());
            }
        }

        Bitmap ResizeBitmap(Bitmap original)
        {
            return new Bitmap(original, new Size(20, 20));
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Assembly ensamblat = Assembly.LoadFrom($@"{_classe}.exe");

                Type tipus = ensamblat.GetType($"{_classe}.{_form}");
                Object dllBD = Activator.CreateInstance(tipus, NomTaula);

                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "MenuScreen")
                    {
                        foreach (Control ctr in item.Controls)
                        {
                            if (ctr.Name == "panelMain")
                            {
                                ((Form)dllBD).TopLevel = false;
                                ((Form)dllBD).AutoScroll = true;
                                ctr.Controls.Add(((Form)dllBD));
                                ((Form)dllBD).WindowState = FormWindowState.Maximized;
                            }
                        }
                    }
                }

                ((Form)dllBD).Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Reflection error: " + exception.ToString());
            }
        }
    }
}
