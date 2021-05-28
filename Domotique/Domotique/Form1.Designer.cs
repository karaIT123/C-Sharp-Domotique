
namespace Domotique
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurerPortsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fermerLePortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerLapplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurerPortsToolStripMenuItem1,
            this.fermerLePortToolStripMenuItem,
            this.fermerLapplicationToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(109, 38);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // configurerPortsToolStripMenuItem1
            // 
            this.configurerPortsToolStripMenuItem1.Name = "configurerPortsToolStripMenuItem1";
            this.configurerPortsToolStripMenuItem1.Size = new System.Drawing.Size(360, 44);
            this.configurerPortsToolStripMenuItem1.Text = "Configurer Ports";
            this.configurerPortsToolStripMenuItem1.Click += new System.EventHandler(this.configurerPortsToolStripMenuItem1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(486, 31);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(486, 31);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 252);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(486, 31);
            this.textBox3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(486, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Envoyer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fermerLePortToolStripMenuItem
            // 
            this.fermerLePortToolStripMenuItem.Name = "fermerLePortToolStripMenuItem";
            this.fermerLePortToolStripMenuItem.Size = new System.Drawing.Size(360, 44);
            this.fermerLePortToolStripMenuItem.Text = "Fermer le port";
            this.fermerLePortToolStripMenuItem.Click += new System.EventHandler(this.fermerLePortToolStripMenuItem_Click);
            // 
            // fermerLapplicationToolStripMenuItem
            // 
            this.fermerLapplicationToolStripMenuItem.Name = "fermerLapplicationToolStripMenuItem";
            this.fermerLapplicationToolStripMenuItem.Size = new System.Drawing.Size(360, 44);
            this.fermerLapplicationToolStripMenuItem.Text = "Fermer l\'application";
            this.fermerLapplicationToolStripMenuItem.Click += new System.EventHandler(this.fermerLapplicationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Domotique";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurerPortsToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem fermerLePortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerLapplicationToolStripMenuItem;
    }
}

