namespace FinalProject.App.Main
{
    partial class UCTB
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
            this.menuNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // menuNotification
            // 
            this.menuNotification.AutoScroll = true;
            this.menuNotification.Location = new System.Drawing.Point(37, 24);
            this.menuNotification.Name = "menuNotification";
            this.menuNotification.Size = new System.Drawing.Size(1183, 773);
            this.menuNotification.TabIndex = 0;
            // 
            // UCTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.menuNotification);
            this.Name = "UCTB";
            this.Size = new System.Drawing.Size(1220, 800);
            this.Load += new System.EventHandler(this.UCTB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menuNotification;
    }
}
