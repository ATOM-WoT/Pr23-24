namespace Практическая_23
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblDevelopers = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblInformationAboutProgram = new System.Windows.Forms.Label();
            this.lblInformations = new System.Windows.Forms.Label();
            this.lblDevelopers_2 = new System.Windows.Forms.Label();
            this.lblVersion_number = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDevelopers
            // 
            this.lblDevelopers.AutoSize = true;
            this.lblDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDevelopers.Location = new System.Drawing.Point(40, 41);
            this.lblDevelopers.Name = "lblDevelopers";
            this.lblDevelopers.Size = new System.Drawing.Size(154, 25);
            this.lblDevelopers.TabIndex = 0;
            this.lblDevelopers.Text = "Разработчики: ";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVersion.Location = new System.Drawing.Point(40, 97);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(89, 25);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Версия: ";
            // 
            // lblInformationAboutProgram
            // 
            this.lblInformationAboutProgram.AutoSize = true;
            this.lblInformationAboutProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblInformationAboutProgram.Location = new System.Drawing.Point(40, 219);
            this.lblInformationAboutProgram.Name = "lblInformationAboutProgram";
            this.lblInformationAboutProgram.Size = new System.Drawing.Size(139, 25);
            this.lblInformationAboutProgram.TabIndex = 2;
            this.lblInformationAboutProgram.Text = "О программе";
            // 
            // lblInformations
            // 
            this.lblInformations.AutoSize = true;
            this.lblInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInformations.Location = new System.Drawing.Point(42, 270);
            this.lblInformations.Name = "lblInformations";
            this.lblInformations.Size = new System.Drawing.Size(610, 17);
            this.lblInformations.TabIndex = 3;
            this.lblInformations.Text = "Простой растровый графический редактор,  в нём можно рисовать интересные картинки" +
    ". ";
            // 
            // lblDevelopers_2
            // 
            this.lblDevelopers_2.AutoSize = true;
            this.lblDevelopers_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDevelopers_2.Location = new System.Drawing.Point(200, 45);
            this.lblDevelopers_2.Name = "lblDevelopers_2";
            this.lblDevelopers_2.Size = new System.Drawing.Size(109, 17);
            this.lblDevelopers_2.TabIndex = 4;
            this.lblDevelopers_2.Text = "Ядыкин Сергей";
            this.lblDevelopers_2.Click += new System.EventHandler(this.lblDevelopers_2_Click);
            // 
            // lblVersion_number
            // 
            this.lblVersion_number.AutoSize = true;
            this.lblVersion_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVersion_number.Location = new System.Drawing.Point(148, 101);
            this.lblVersion_number.Name = "lblVersion_number";
            this.lblVersion_number.Size = new System.Drawing.Size(48, 17);
            this.lblVersion_number.TabIndex = 5;
            this.lblVersion_number.Text = "1.20.1";
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblConnection.Location = new System.Drawing.Point(40, 160);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(191, 25);
            this.lblConnection.TabIndex = 6;
            this.lblConnection.Text = "Связаться с мной: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmail.Location = new System.Drawing.Point(236, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(202, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "serega.yadikcin890@yandex.u";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 462);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.lblVersion_number);
            this.Controls.Add(this.lblDevelopers_2);
            this.Controls.Add(this.lblInformations);
            this.Controls.Add(this.lblInformationAboutProgram);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDevelopers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Информация о программе";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDevelopers;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblInformationAboutProgram;
        private System.Windows.Forms.Label lblInformations;
        private System.Windows.Forms.Label lblDevelopers_2;
        private System.Windows.Forms.Label lblVersion_number;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblEmail;
    }
}