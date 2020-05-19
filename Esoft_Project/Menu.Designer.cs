namespace Esoft_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.buttonOpenRealEstates = new System.Windows.Forms.Button();
            this.buttonOpenSupplies = new System.Windows.Forms.Button();
            this.buttonOpenDemand = new System.Windows.Forms.Button();
            this.buttonOpenDeals = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOpenClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenClients.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenClients.Location = new System.Drawing.Point(8, 135);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenClients.TabIndex = 2;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOpenAgents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenAgents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenAgents.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenAgents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenAgents.Location = new System.Drawing.Point(8, 202);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenAgents.TabIndex = 1;
            this.buttonOpenAgents.Text = "Риелторы";
            this.buttonOpenAgents.UseVisualStyleBackColor = false;
            this.buttonOpenAgents.Click += new System.EventHandler(this.buttonOpenAgents_Click);
            // 
            // buttonOpenRealEstates
            // 
            this.buttonOpenRealEstates.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOpenRealEstates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenRealEstates.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenRealEstates.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenRealEstates.Location = new System.Drawing.Point(8, 267);
            this.buttonOpenRealEstates.Name = "buttonOpenRealEstates";
            this.buttonOpenRealEstates.Size = new System.Drawing.Size(265, 89);
            this.buttonOpenRealEstates.TabIndex = 3;
            this.buttonOpenRealEstates.Text = "Объекты недвижимости";
            this.buttonOpenRealEstates.UseVisualStyleBackColor = false;
            this.buttonOpenRealEstates.Click += new System.EventHandler(this.buttonOpenRealEstates_Click);
            // 
            // buttonOpenSupplies
            // 
            this.buttonOpenSupplies.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOpenSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenSupplies.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenSupplies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenSupplies.Location = new System.Drawing.Point(8, 372);
            this.buttonOpenSupplies.Name = "buttonOpenSupplies";
            this.buttonOpenSupplies.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenSupplies.TabIndex = 4;
            this.buttonOpenSupplies.Text = "Предложения";
            this.buttonOpenSupplies.UseVisualStyleBackColor = false;
            this.buttonOpenSupplies.Click += new System.EventHandler(this.buttonOpenDemands_Click);
            // 
            // buttonOpenDemand
            // 
            this.buttonOpenDemand.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOpenDemand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenDemand.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDemand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenDemand.Location = new System.Drawing.Point(8, 436);
            this.buttonOpenDemand.Name = "buttonOpenDemand";
            this.buttonOpenDemand.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDemand.TabIndex = 5;
            this.buttonOpenDemand.Text = "Потребности";
            this.buttonOpenDemand.UseVisualStyleBackColor = false;
            this.buttonOpenDemand.Click += new System.EventHandler(this.buttonOpenSupplies_Click);
            // 
            // buttonOpenDeals
            // 
            this.buttonOpenDeals.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOpenDeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenDeals.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDeals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenDeals.Location = new System.Drawing.Point(8, 501);
            this.buttonOpenDeals.Name = "buttonOpenDeals";
            this.buttonOpenDeals.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDeals.TabIndex = 6;
            this.buttonOpenDeals.Text = "Сделки";
            this.buttonOpenDeals.UseVisualStyleBackColor = false;
            this.buttonOpenDeals.Click += new System.EventHandler(this.buttonOpenDeals_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(16, 37);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(245, 92);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(46, 6);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(50, 15);
            this.labelHello.TabIndex = 7;
            this.labelHello.Text = "Привет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenDeals);
            this.Controls.Add(this.buttonOpenDemand);
            this.Controls.Add(this.buttonOpenSupplies);
            this.Controls.Add(this.buttonOpenRealEstates);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esoft";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Button buttonOpenRealEstates;
        private System.Windows.Forms.Button buttonOpenSupplies;
        private System.Windows.Forms.Button buttonOpenDemand;
        private System.Windows.Forms.Button buttonOpenDeals;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label label1;
    }
}

