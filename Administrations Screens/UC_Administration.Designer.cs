
namespace Administrations_Screens
{
    partial class UC_Administration
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.swTextBox2 = new CustomControls.SwTextBox();
            this.swTextBox3 = new CustomControls.SwTextBox();
            this.swTextBox4 = new CustomControls.SwTextBox();
            this.swTextBox1 = new CustomControls.SwTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 456);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(808, 600);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 44);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(930, 600);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 44);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // swTextBox2
            // 
            this.swTextBox2.DadaPermesa = CustomControls.SwTextBox.TipusDada.text;
            this.swTextBox2.Empty = false;
            this.swTextBox2.FieldBinding = "CodeCategory";
            this.swTextBox2.ForeignKey = false;
            this.swTextBox2.Location = new System.Drawing.Point(230, 58);
            this.swTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(148, 31);
            this.swTextBox2.TabIndex = 14;
            // 
            // swTextBox3
            // 
            this.swTextBox3.DadaPermesa = CustomControls.SwTextBox.TipusDada.text;
            this.swTextBox3.Empty = false;
            this.swTextBox3.FieldBinding = "DescCategory";
            this.swTextBox3.ForeignKey = false;
            this.swTextBox3.Location = new System.Drawing.Point(422, 58);
            this.swTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.Size = new System.Drawing.Size(148, 31);
            this.swTextBox3.TabIndex = 15;
            // 
            // swTextBox4
            // 
            this.swTextBox4.DadaPermesa = CustomControls.SwTextBox.TipusDada.num;
            this.swTextBox4.Empty = false;
            this.swTextBox4.FieldBinding = "AccessLevel";
            this.swTextBox4.ForeignKey = false;
            this.swTextBox4.Location = new System.Drawing.Point(596, 58);
            this.swTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.Size = new System.Drawing.Size(148, 31);
            this.swTextBox4.TabIndex = 16;
            // 
            // swTextBox1
            // 
            this.swTextBox1.DadaPermesa = CustomControls.SwTextBox.TipusDada.text;
            this.swTextBox1.Empty = false;
            this.swTextBox1.FieldBinding = "idUserCategory";
            this.swTextBox1.ForeignKey = false;
            this.swTextBox1.Location = new System.Drawing.Point(793, 58);
            this.swTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(148, 31);
            this.swTextBox1.TabIndex = 17;
            this.swTextBox1.Visible = false;
            // 
            // UC_Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.swTextBox1);
            this.Controls.Add(this.swTextBox4);
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_Administration";
            this.Text = "UC_Administration";
            this.Load += new System.EventHandler(this.UC_Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private CustomControls.SwTextBox swTextBox2;
        private CustomControls.SwTextBox swTextBox3;
        private CustomControls.SwTextBox swTextBox4;
        private CustomControls.SwTextBox swTextBox1;
    }
}