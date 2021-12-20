
namespace Administrations_Screens
{
    partial class SpeciesAdministration
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
            this.SuspendLayout();
            // 
            // swTextBox1
            // 
            this.swTextBox1.DadaPermesa = CustomControls.SwTextBox.TipusDada.num;
            this.swTextBox1.Empty = false;
            this.swTextBox1.FieldBinding = "DescSpecie";
            this.swTextBox1.ForeignKey = false;
            this.swTextBox1.Location = new System.Drawing.Point(423, 34);
            this.swTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(148, 31);
            this.swTextBox1.TabIndex = 11;
            // 
            // swTextBox2
            // 
            this.swTextBox2.DadaPermesa = CustomControls.SwTextBox.TipusDada.text;
            this.swTextBox2.Empty = false;
            this.swTextBox2.FieldBinding = "CodeSpecie";
            this.swTextBox2.ForeignKey = false;
            this.swTextBox2.Location = new System.Drawing.Point(219, 34);
            this.swTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(148, 31);
            this.swTextBox2.TabIndex = 12;
            // 
            // swTextBox3
            // 
            this.swTextBox3.DadaPermesa = CustomControls.SwTextBox.TipusDada.num;
            this.swTextBox3.Empty = false;
            this.swTextBox3.FieldBinding = "idSpecie";
            this.swTextBox3.ForeignKey = false;
            this.swTextBox3.Location = new System.Drawing.Point(40, 34);
            this.swTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.Size = new System.Drawing.Size(148, 31);
            this.swTextBox3.TabIndex = 13;
            // 
            // SpeciesAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "SpeciesAdministration";
            this.Text = "SpeciesAdministration";
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.Controls.SetChildIndex(this.swTextBox3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SwTextBox swTextBox1;
        private CustomControls.SwTextBox swTextBox2;
        private CustomControls.SwTextBox swTextBox3;
    }
}