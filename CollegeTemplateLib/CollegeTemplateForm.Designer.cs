namespace CollegeTemplateLib
{
    partial class CollegeTemplateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollegeTemplateForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cenColLinkLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cenColLinkLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 207);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(413, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cenColLinkLabel
            // 
            this.cenColLinkLabel.Image = ((System.Drawing.Image)(resources.GetObject("cenColLinkLabel.Image")));
            this.cenColLinkLabel.Name = "cenColLinkLabel";
            this.cenColLinkLabel.Size = new System.Drawing.Size(68, 17);
            this.cenColLinkLabel.Text = "LinkedIn";
            this.cenColLinkLabel.Click += new System.EventHandler(this.cenColLinkLabel_Click);
            // 
            // CollegeTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 229);
            this.Controls.Add(this.statusStrip1);
            this.Name = "CollegeTemplateForm";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel cenColLinkLabel;
    }
}

