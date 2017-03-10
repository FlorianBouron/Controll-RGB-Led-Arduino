namespace Arduino_RGB_Controller
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.arduinoPortText = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // arduinoPortText
            // 
            this.arduinoPortText.AutoSize = true;
            this.arduinoPortText.ForeColor = System.Drawing.Color.Red;
            this.arduinoPortText.Location = new System.Drawing.Point(338, 239);
            this.arduinoPortText.Name = "arduinoPortText";
            this.arduinoPortText.Size = new System.Drawing.Size(103, 13);
            this.arduinoPortText.TabIndex = 9;
            this.arduinoPortText.Text = "Searching Arduino...";
            // 
            // panelRed
            // 
            this.panelRed.Location = new System.Drawing.Point(35, 148);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(75, 23);
            this.panelRed.TabIndex = 8;
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(158, 41);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(139, 66);
            this.panelColor.TabIndex = 7;
            // 
            // panelGreen
            // 
            this.panelGreen.Location = new System.Drawing.Point(182, 148);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(75, 23);
            this.panelGreen.TabIndex = 10;
            // 
            // panelBlue
            // 
            this.panelBlue.Location = new System.Drawing.Point(329, 148);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(75, 23);
            this.panelBlue.TabIndex = 11;
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(35, 189);
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(75, 45);
            this.trackBarRed.TabIndex = 12;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(182, 189);
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(75, 45);
            this.trackBarGreen.TabIndex = 13;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(329, 189);
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(75, 45);
            this.trackBarBlue.TabIndex = 14;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 261);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.arduinoPortText);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.panelColor);
            this.Name = "Form1";
            this.Text = "Arduino RGB Controller";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arduinoPortText;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
    }
}

