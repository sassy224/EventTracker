namespace EventTracker
{
    partial class Form1
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
            this.lstCtrl = new EventTracker.UserControls.ListingControl();
            this.evtCtrl = new EventTracker.UserControls.EventControl();
            this.SuspendLayout();
            // 
            // lstCtrl
            // 
            this.lstCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCtrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCtrl.Location = new System.Drawing.Point(13, 234);
            this.lstCtrl.Name = "lstCtrl";
            this.lstCtrl.Size = new System.Drawing.Size(457, 202);
            this.lstCtrl.TabIndex = 1;
            // 
            // evtCtrl
            // 
            this.evtCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evtCtrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.evtCtrl.Location = new System.Drawing.Point(13, 13);
            this.evtCtrl.Name = "evtCtrl";
            this.evtCtrl.Size = new System.Drawing.Size(457, 215);
            this.evtCtrl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 448);
            this.Controls.Add(this.lstCtrl);
            this.Controls.Add(this.evtCtrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.EventControl evtCtrl;
        private UserControls.ListingControl lstCtrl;
    }
}