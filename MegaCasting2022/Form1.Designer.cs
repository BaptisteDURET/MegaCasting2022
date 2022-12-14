namespace MegaCasting2022
{
    partial class MegaCasting
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.gestionClient1 = new MegaCasting2022.GestionClient();
            this.gestionCasting1 = new MegaCasting2022.GestionCasting();
            this.gestionPartenaire1 = new MegaCasting2022.GestionPartenaire();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 683);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "Partenaire";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AfficheViewPartenaire);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Casting";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AfficheViewCasting);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AfficheViewClient);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // gestionClient1
            // 
            this.gestionClient1.BackColor = System.Drawing.Color.Transparent;
            this.gestionClient1.Location = new System.Drawing.Point(197, 0);
            this.gestionClient1.Name = "gestionClient1";
            this.gestionClient1.Size = new System.Drawing.Size(866, 683);
            this.gestionClient1.TabIndex = 1;
            // 
            // gestionCasting1
            // 
            this.gestionCasting1.BackColor = System.Drawing.Color.Transparent;
            this.gestionCasting1.Location = new System.Drawing.Point(197, 0);
            this.gestionCasting1.Name = "gestionCasting1";
            this.gestionCasting1.Size = new System.Drawing.Size(866, 672);
            this.gestionCasting1.TabIndex = 2;
            // 
            // gestionPartenaire1
            // 
            this.gestionPartenaire1.BackColor = System.Drawing.Color.Transparent;
            this.gestionPartenaire1.Location = new System.Drawing.Point(197, 0);
            this.gestionPartenaire1.Name = "gestionPartenaire1";
            this.gestionPartenaire1.Size = new System.Drawing.Size(866, 672);
            this.gestionPartenaire1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "MegaCasting";
            // 
            // MegaCasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gestionClient1);
            this.Controls.Add(this.gestionPartenaire1);
            this.Controls.Add(this.gestionCasting1);
            this.Name = "MegaCasting";
            this.Text = "MegaCasting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GestionClient gestionClient1;
        private GestionCasting gestionCasting1;
        private GestionPartenaire gestionPartenaire1;
        private Label label1;
    }
}