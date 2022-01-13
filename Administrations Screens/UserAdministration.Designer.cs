
namespace Administrations_Screens
{
    partial class UserAdministration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.swTextBox1 = new CustomControls.SwTextBox();
            this.swTextBox2 = new CustomControls.SwTextBox();
            this.swTextBox3 = new CustomControls.SwTextBox();
            this.swCodi1 = new CustomControls.SwCodi();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.swCodi2 = new CustomControls.SwCodi();
            this.SuspendLayout();
            // 
            // swTextBox1
            // 
            this.swTextBox1.DadaPermesa = CustomControls.SwTextBox.TipusDada.text;
            this.swTextBox1.Empty = false;
            this.swTextBox1.FieldBinding = "CodeUser";
            this.swTextBox1.ForeignKey = false;
            this.swTextBox1.Location = new System.Drawing.Point(207, 94);
            this.swTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(148, 31);
            this.swTextBox1.TabIndex = 11;
            // 
            // swTextBox2
            // 
            this.swTextBox2.DadaPermesa = CustomControls.SwTextBox.TipusDada.text;
            this.swTextBox2.Empty = false;
            this.swTextBox2.FieldBinding = "UserName";
            this.swTextBox2.ForeignKey = false;
            this.swTextBox2.Location = new System.Drawing.Point(381, 94);
            this.swTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(148, 31);
            this.swTextBox2.TabIndex = 12;
            // 
            // swTextBox3
            // 
            this.swTextBox3.DadaPermesa = CustomControls.SwTextBox.TipusDada.text;
            this.swTextBox3.Empty = false;
            this.swTextBox3.FieldBinding = "login";
            this.swTextBox3.ForeignKey = false;
            this.swTextBox3.Location = new System.Drawing.Point(540, 94);
            this.swTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.Size = new System.Drawing.Size(148, 31);
            this.swTextBox3.TabIndex = 13;
            // 
            // swCodi1
            // 
            this.swCodi1.ClasseCS = "CustomControls";
            this.swCodi1.ControlID = null;
            this.swCodi1.FormCS = "DataGridViewForm";
            this.swCodi1.Location = new System.Drawing.Point(396, 683);
            this.swCodi1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.NomCodi = "idUserRank";
            this.swCodi1.NomDesc = "DescRank";
            this.swCodi1.NomID = "idUserRank";
            this.swCodi1.NomTaula = "UserRanks";
            this.swCodi1.Required = false;
            this.swCodi1.Size = new System.Drawing.Size(578, 73);
            this.swCodi1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 698);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "User Ranks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 794);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Planets";
            // 
            // swCodi2
            // 
            this.swCodi2.ClasseCS = "CustomControls";
            this.swCodi2.ControlID = null;
            this.swCodi2.FormCS = "DataGridViewForm";
            this.swCodi2.Location = new System.Drawing.Point(396, 779);
            this.swCodi2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swCodi2.Name = "swCodi2";
            this.swCodi2.NomCodi = "idPlanet";
            this.swCodi2.NomDesc = "DescPlanet";
            this.swCodi2.NomID = "idPlanet";
            this.swCodi2.NomTaula = "Planets";
            this.swCodi2.Required = false;
            this.swCodi2.Size = new System.Drawing.Size(578, 73);
            this.swCodi2.TabIndex = 17;
            // 
            // UserAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 936);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.swCodi2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swCodi1);
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "UserAdministration";
            this.Text = "User_administration";
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.Controls.SetChildIndex(this.swTextBox3, 0);
            this.Controls.SetChildIndex(this.swCodi1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.swCodi2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SwTextBox swTextBox1;
        private CustomControls.SwTextBox swTextBox2;
        private CustomControls.SwTextBox swTextBox3;
        public CustomControls.SwCodi swCodi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public CustomControls.SwCodi swCodi2;
    }
}