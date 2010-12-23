namespace TypedFactoryExample.Views
{
    partial class MainForm : IMainView
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
            this.linkLabelShowSubForm = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelShowSubForm
            // 
            this.linkLabelShowSubForm.AutoSize = true;
            this.linkLabelShowSubForm.Location = new System.Drawing.Point(85, 63);
            this.linkLabelShowSubForm.Name = "linkLabelShowSubForm";
            this.linkLabelShowSubForm.Size = new System.Drawing.Size(88, 13);
            this.linkLabelShowSubForm.TabIndex = 0;
            this.linkLabelShowSubForm.TabStop = true;
            this.linkLabelShowSubForm.Text = "Show SubForm...";
            this.linkLabelShowSubForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelShowSubFormLinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 603);
            this.Controls.Add(this.linkLabelShowSubForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelShowSubForm;
    }
}

