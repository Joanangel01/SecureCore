
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
            this.textBoxCode.Location = new System.Drawing.Point(13, 12);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(54, 22);
            this.textBoxCode.TabIndex = 0;
            this.textBoxCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCode_KeyDown);
            this.textBoxCode.Leave += new System.EventHandler(this.TextBoxCode_Leave);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Enabled = false;
            this.textBoxDesc.Location = new System.Drawing.Point(73, 12);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(301, 22);
            this.textBoxDesc.TabIndex = 1;
            this.textBoxDesc.TabStop = false;
            // 
            // SwCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxCode);
            this.Name = "SwCodi";
            this.Size = new System.Drawing.Size(385, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxDesc;
    }
}
