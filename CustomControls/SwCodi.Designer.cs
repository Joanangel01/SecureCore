
namespace CustomControls
{
    partial class SwCodi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(20, 19);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(79, 31);
            this.textBoxCode.TabIndex = 0;
            this.textBoxCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCode_KeyDown);
            this.textBoxCode.Leave += new System.EventHandler(this.TextBoxCode_Leave);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Enabled = false;
            this.textBoxDesc.Location = new System.Drawing.Point(110, 19);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(450, 31);
            this.textBoxDesc.TabIndex = 1;
            this.textBoxDesc.TabStop = false;
            // 
            // SwCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxCode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SwCodi";
            this.Size = new System.Drawing.Size(578, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxCode;
        public System.Windows.Forms.TextBox textBoxDesc;
    }
}
