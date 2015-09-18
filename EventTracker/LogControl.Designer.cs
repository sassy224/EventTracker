namespace EventTracker
{
    partial class EventControl
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.lblKeyboardEvt = new System.Windows.Forms.Label();
            this.txtKeyboard = new System.Windows.Forms.TextBox();
            this.lblMouseEvt = new System.Windows.Forms.Label();
            this.txtMouse = new System.Windows.Forms.TextBox();
            this.lblButtonEvt = new System.Windows.Forms.Label();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnClickMe);
            this.pnlControls.Controls.Add(this.lblButtonEvt);
            this.pnlControls.Controls.Add(this.txtMouse);
            this.pnlControls.Controls.Add(this.lblMouseEvt);
            this.pnlControls.Controls.Add(this.txtKeyboard);
            this.pnlControls.Controls.Add(this.lblKeyboardEvt);
            this.pnlControls.Location = new System.Drawing.Point(13, 13);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(432, 231);
            this.pnlControls.TabIndex = 0;
            // 
            // lstLogs
            // 
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.Location = new System.Drawing.Point(13, 251);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(432, 316);
            this.lstLogs.TabIndex = 1;
            // 
            // lblKeyboardEvt
            // 
            this.lblKeyboardEvt.AutoSize = true;
            this.lblKeyboardEvt.Location = new System.Drawing.Point(23, 19);
            this.lblKeyboardEvt.Name = "lblKeyboardEvt";
            this.lblKeyboardEvt.Size = new System.Drawing.Size(134, 13);
            this.lblKeyboardEvt.TabIndex = 0;
            this.lblKeyboardEvt.Text = "Test keyboard events here";
            // 
            // txtKeyboard
            // 
            this.txtKeyboard.Location = new System.Drawing.Point(178, 16);
            this.txtKeyboard.Name = "txtKeyboard";
            this.txtKeyboard.Size = new System.Drawing.Size(222, 20);
            this.txtKeyboard.TabIndex = 1;
            this.txtKeyboard.TextChanged += new System.EventHandler(this.txtKeyboard_TextChanged);
            this.txtKeyboard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyboard_KeyDown);
            this.txtKeyboard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyboard_KeyPress);
            this.txtKeyboard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyboard_KeyUp);
            this.txtKeyboard.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtKeyboard_PreviewKeyDown);
            // 
            // lblMouseEvt
            // 
            this.lblMouseEvt.AutoSize = true;
            this.lblMouseEvt.Location = new System.Drawing.Point(36, 62);
            this.lblMouseEvt.Name = "lblMouseEvt";
            this.lblMouseEvt.Size = new System.Drawing.Size(121, 13);
            this.lblMouseEvt.TabIndex = 2;
            this.lblMouseEvt.Text = "Test mouse events here";
            // 
            // txtMouse
            // 
            this.txtMouse.Location = new System.Drawing.Point(178, 59);
            this.txtMouse.Multiline = true;
            this.txtMouse.Name = "txtMouse";
            this.txtMouse.ReadOnly = true;
            this.txtMouse.Size = new System.Drawing.Size(222, 91);
            this.txtMouse.TabIndex = 3;
            this.txtMouse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMouse_MouseClick);
            this.txtMouse.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtMouse_MouseDoubleClick);
            this.txtMouse.MouseCaptureChanged += new System.EventHandler(this.txtMouse_MouseCaptureChanged);
            this.txtMouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtMouse_MouseDown);
            this.txtMouse.MouseEnter += new System.EventHandler(this.txtMouse_MouseEnter);
            this.txtMouse.MouseLeave += new System.EventHandler(this.txtMouse_MouseLeave);
            this.txtMouse.MouseHover += new System.EventHandler(this.txtMouse_MouseHover);
            this.txtMouse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtMouse_MouseUp);
            // 
            // lblButtonEvt
            // 
            this.lblButtonEvt.AutoSize = true;
            this.lblButtonEvt.Location = new System.Drawing.Point(107, 175);
            this.lblButtonEvt.Name = "lblButtonEvt";
            this.lblButtonEvt.Size = new System.Drawing.Size(50, 13);
            this.lblButtonEvt.TabIndex = 4;
            this.lblButtonEvt.Text = "And here";
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(178, 170);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(75, 23);
            this.btnClickMe.TabIndex = 5;
            this.btnClickMe.Text = "Click me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClickMe_MouseClick);
            this.btnClickMe.MouseCaptureChanged += new System.EventHandler(this.btnClickMe_MouseCaptureChanged);
            this.btnClickMe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClickMe_MouseDown);
            this.btnClickMe.MouseEnter += new System.EventHandler(this.btnClickMe_MouseEnter);
            this.btnClickMe.MouseLeave += new System.EventHandler(this.btnClickMe_MouseLeave);
            this.btnClickMe.MouseHover += new System.EventHandler(this.btnClickMe_MouseHover);
            this.btnClickMe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClickMe_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 582);
            this.Controls.Add(this.lstLogs);
            this.Controls.Add(this.pnlControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.ListBox lstLogs;
        private System.Windows.Forms.Label lblKeyboardEvt;
        private System.Windows.Forms.Label lblMouseEvt;
        private System.Windows.Forms.TextBox txtKeyboard;
        private System.Windows.Forms.TextBox txtMouse;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblButtonEvt;
    }
}

