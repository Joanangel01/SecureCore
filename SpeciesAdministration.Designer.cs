
namespace Sprint2
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
            this.swTextBox1.Location = new System.Drawing.Point(282, 22);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(100, 22);
            this.swTextBox1.TabIndex = 11;
            // 
            // swTextBox2
            // 
            this.swTextBox2.DadaPermesa = CustomControls.SwTextBox.TipusDada.text;
            this.swTextBox2.Empty = false;
            this.swTextBox2.FieldBinding = "CodeSpecie";
            this.swTextBox2.ForeignKey = false;
            this.swTextBox2.Location = new System.Drawing.Point(146, 22);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(100, 22);
            this.swTextBox2.TabIndex = 12;
            // 
            // swTextBox3
            // 
            this.swTextBox3.DadaPermesa = CustomControls.SwTextBox.TipusDada.num;
            this.swTextBox3.Empty = false;
            this.swTextBox3.FieldBinding = "idSpecie";
            this.swTextBox3.ForeignKey = false;
            this.swTextBox3.Location = new System.Drawing.Point(27, 22);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.Size = new System.Drawing.Size(100, 22);
            this.swTextBox3.TabIndex = 13;
            // 
            // SpeciesAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
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