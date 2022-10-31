namespace Fall2020_CSC403_Project
{
    partial class EnemyFormPopup
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
            this.popupimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.popupimage)).BeginInit();
            this.SuspendLayout();
            // 
            // popupimage
            // 
            this.popupimage.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemydead;
            this.popupimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.popupimage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupimage.Location = new System.Drawing.Point(0, 0);
            this.popupimage.Name = "popupimage";
            this.popupimage.Size = new System.Drawing.Size(800, 450);
            this.popupimage.TabIndex = 0;
            this.popupimage.TabStop = false;
            // 
            // EnemyFormPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.popupimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnemyFormPopup";
            this.Text = "EnemyFormPopup";
            ((System.ComponentModel.ISupportInitialize)(this.popupimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox popupimage;
    }
}