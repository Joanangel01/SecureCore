
namespace Administrations_Screens
{
    partial class SectorAdministration
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
            this.swTextBox4 = new CustomControls.SwTextBox();
            this.swTextBox3 = new CustomControls.SwTextBox();
            this.swTextBox2 = new CustomControls.SwTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.swTextBox1 = new CustomControls.SwTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // swTextBox4
            // 
            this.swTextBox4.DadaPermesa = CustomControls.SwTextBox.TipusDada.num;
            this.swTextBox4.Empty = false;
            this.swTextBox4.FieldBinding = "Remarks";
            this.swTextBox4.ForeignKey = false;
            this.swTextBox4.Location = new System.Drawing.Point(512, 157);
            this.swTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.Size = new System.Drawing.Size(148, 31);
            this.swTextBox4.TabIndex = 22;
            // 
            // swTextBox3
            // 
            this.swTextBox3.DadaPermesa = CustomControls.SwTextBox.TipusDada.text;
            this.swTextBox3.Empty = false;
            this.swTextBox3.FieldBinding = "DescSector";
            this.swTextBox3.ForeignKey = false;
            this.swTextBox3.Location = new System.Drawing.Point(328, 157);
            this.swTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.Size = new System.Drawing.Size(148, 31);
            this.swTextBox3.TabIndex = 21;
            // 
            // swTextBox2
            // 
            this.swTextBox2.DadaPermesa = CustomControls.SwTextBox.TipusDada.text;
            this.swTextBox2.Empty = false;
            this.swTextBox2.FieldBinding = "CodeSector";
            this.swTextBox2.ForeignKey = false;
            this.swTextBox2.Location = new System.Drawing.Point(146, 157);
            this.swTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(148, 31);
            this.swTextBox2.TabIndex = 20;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(912, 680);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 44);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(1034, 680);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 44);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 456);
            this.dataGridView1.TabIndex = 17;
            // 
            // swTextBox1
            // 
            this.swTextBox1.DadaPermesa = CustomControls.SwTextBox.TipusDada.num;
            this.swTextBox1.Empty = false;
            this.swTextBox1.FieldBinding = "idRegion";
            this.swTextBox1.ForeignKey = false;
            this.swTextBox1.Location = new System.Drawing.Point(699, 157);
            this.swTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(148, 31);
            this.swTextBox1.TabIndex = 23;
            // 
            // SectorAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 862);
            this.Controls.Add(this.swTextBox1);
            this.Controls.Add(this.swTextBox4);
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SectorAdministration";
            this.Text = "SectorAdministration";
            this.Load += new System.EventHandler(this.SectorsAdministration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SwTextBox swTextBox4;
        private CustomControls.SwTextBox swTextBox3;
        private CustomControls.SwTextBox swTextBox2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.SwTextBox swTextBox1;
    }
}