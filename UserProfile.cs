using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionLibrary;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace Sprint2
{
    public partial class UserProfile : Form
    {
        DataSet dts;
        class ConnectionToDB : Connection
        {

        }
        public UserProfile()
        {
            InitializeComponent();
        }


        private void UserProfile_Load(object sender, EventArgs e)
        {
            userAdminsitration user = new userAdminsitration();
            user.Load();
            user.OpenSubreport("userAdminsitration");
            string query =  "SELECT Users.Photo, Species.DescSpecie, UserCategories.DescCategory, UserRanks.DescRank, Users.CodeUser, " +
                            "Users.UserName, Planets.DescPlanet, Users.Photo "+
                            "FROM(((SecureCore.dbo.Users Users INNER JOIN SecureCore.dbo.UserRanks UserRanks ON Users.idUserRank = UserRanks.idUserRank) "+ 
                            "INNER JOIN SecureCore.dbo.UserCategories UserCategories ON Users.idUserCategory = UserCategories.idUserCategory) "+ 
                            "INNER JOIN SecureCore.dbo.Species Species ON Users.idSpecie = Species.idSpecie)"+ 
                            "INNER JOIN SecureCore.dbo.Planets Planets ON Users.idPlanet = Planets.idPlanet "+
                            "WHERE Users.idUser = "+ LoginScreen.idUser;

            Connection connexio = new ConnectionToDB();
            connexio.Conectar();
            dts = connexio.PortarPerConsulta(query);
            foreach (DataRow item in dts.Tables[0].Rows)
            {
                pictureBox1.ImageLocation = item[0].ToString();
                lblSpecie.Text = item[1].ToString();
                lblRank.Text = item[3].ToString();
                lblSurname.Text = item[4].ToString();
                lblName.Text = item[5].ToString();
                lblPlanet.Text = item[6].ToString();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string newImgUrl;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);

                    var myAccount = new Account { ApiKey = "235117647476446", ApiSecret = "0vyTICgQX0H5wFTT706Og4XQhWY", Cloud = "atlantis-it" };
                    Cloudinary _cloudinary = new Cloudinary(myAccount);

                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(dlg.FileName)
                    };
                    var uploadResult = _cloudinary.Upload(uploadParams);

                    newImgUrl = uploadResult.SecureUrl.ToString();
                    newImgUrl = "'" + newImgUrl + "'";
                    Connection connexio = new ConnectionToDB();

                    string query = "UPDATE Users Set Photo = "+ newImgUrl + " WHERE idUser = "+LoginScreen.idUser;
                    int res = connexio.Executa(query);
                    if(res != 1)
                    {
                        lblResult.Text = "ERROR";
                    }
                    else
                    {
                        lblResult.Text = "Img Uploaded Correctly";
                    }
                }
            }

        }

        private void CloseImg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
