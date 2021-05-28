
namespace Domotique
{
    partial class Configuration_Ports
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
            this.listBoxPort = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPortName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBitsSec = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxFlowControl = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPort
            // 
            this.listBoxPort.FormattingEnabled = true;
            this.listBoxPort.ItemHeight = 25;
            this.listBoxPort.Location = new System.Drawing.Point(55, 104);
            this.listBoxPort.Name = "listBoxPort";
            this.listBoxPort.Size = new System.Drawing.Size(502, 179);
            this.listBoxPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choix du Port COM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Afficher les ports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Effacer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Configuration du port COM";
            // 
            // comboBoxPortName
            // 
            this.comboBoxPortName.FormattingEnabled = true;
            this.comboBoxPortName.Location = new System.Drawing.Point(217, 447);
            this.comboBoxPortName.Name = "comboBoxPortName";
            this.comboBoxPortName.Size = new System.Drawing.Size(340, 33);
            this.comboBoxPortName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bits / Sec:";
            // 
            // comboBoxBitsSec
            // 
            this.comboBoxBitsSec.FormattingEnabled = true;
            this.comboBoxBitsSec.Location = new System.Drawing.Point(217, 496);
            this.comboBoxBitsSec.Name = "comboBoxBitsSec";
            this.comboBoxBitsSec.Size = new System.Drawing.Size(340, 33);
            this.comboBoxBitsSec.TabIndex = 8;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(217, 550);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(340, 33);
            this.comboBoxParity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parité:";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(217, 604);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(340, 33);
            this.comboBoxStopBits.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 607);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bits d\'arrêt:";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(217, 658);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(340, 33);
            this.comboBoxDataBits.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 661);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bits de donées:";
            // 
            // comboBoxFlowControl
            // 
            this.comboBoxFlowControl.FormattingEnabled = true;
            this.comboBoxFlowControl.Location = new System.Drawing.Point(217, 710);
            this.comboBoxFlowControl.Name = "comboBoxFlowControl";
            this.comboBoxFlowControl.Size = new System.Drawing.Size(340, 33);
            this.comboBoxFlowControl.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 713);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contrôle de flux:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 798);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(502, 49);
            this.button3.TabIndex = 17;
            this.button3.Text = "Définir et ouvrir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 867);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(502, 49);
            this.button4.TabIndex = 18;
            this.button4.Text = "Fermer le port";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Configuration_Ports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 954);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxFlowControl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxBitsSec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPortName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPort);
            this.Name = "Configuration_Ports";
            this.Text = "Configuration_Ports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPortName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBitsSec;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxFlowControl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}