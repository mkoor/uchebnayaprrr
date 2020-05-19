namespace Esoft_Project
{
    partial class FormDemand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemand));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelAgent = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.listViewDemandSet_Apartment = new System.Windows.Forms.ListView();
            this.IDAgent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOagent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOclient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinRooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxRooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.labelMinArea = new System.Windows.Forms.Label();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinArea = new System.Windows.Forms.TextBox();
            this.textBoxMaxArea = new System.Windows.Forms.TextBox();
            this.labelMaxArea = new System.Windows.Forms.Label();
            this.labelMinRooms = new System.Windows.Forms.Label();
            this.labelMaxRooms = new System.Windows.Forms.Label();
            this.textBoxMinRooms = new System.Windows.Forms.TextBox();
            this.textBoxMaxRooms = new System.Windows.Forms.TextBox();
            this.labelMinFloor = new System.Windows.Forms.Label();
            this.textBoxMinFloor = new System.Windows.Forms.TextBox();
            this.labelMaxFloor = new System.Windows.Forms.Label();
            this.textBoxMaxFloor = new System.Windows.Forms.TextBox();
            this.labelMinFloors = new System.Windows.Forms.Label();
            this.textBoxMinFloors = new System.Windows.Forms.TextBox();
            this.labelMaxFloors = new System.Windows.Forms.Label();
            this.textBoxMaxFloors = new System.Windows.Forms.TextBox();
            this.listViewDemandSet_Land = new System.Windows.Forms.ListView();
            this.IDagent_L = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOagent_L = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDclient_L = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOclient_L = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinPrice_L = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxPrice_L = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinArea_L = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxArea_L = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDemandSet_House = new System.Windows.Forms.ListView();
            this.IDAgent_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOagent_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDclient_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIOclient_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinPrice_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxPrice_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinArea_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxArea_H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinFloors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxFloors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDel.Location = new System.Drawing.Point(845, 520);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(181, 46);
            this.buttonDel.TabIndex = 32;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(585, 520);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(181, 46);
            this.buttonEdit.TabIndex = 31;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(332, 520);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(181, 46);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(15, 74);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(214, 21);
            this.comboBoxClients.TabIndex = 36;
            this.comboBoxClients.SelectedIndexChanged += new System.EventHandler(this.comboBoxClients_SelectedIndexChanged);
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(15, 34);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(214, 21);
            this.comboBoxAgents.TabIndex = 35;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(12, 58);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(58, 15);
            this.labelClient.TabIndex = 34;
            this.labelClient.Text = "Клиент *";
            this.labelClient.Click += new System.EventHandler(this.labelClient_Click);
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgent.Location = new System.Drawing.Point(12, 16);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(65, 15);
            this.labelAgent.TabIndex = 33;
            this.labelAgent.Text = "Риелтор *";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(15, 116);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(214, 21);
            this.comboBoxType.TabIndex = 38;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(12, 98);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(181, 15);
            this.labelType.TabIndex = 37;
            this.labelType.Text = "Тип объекта недвижимости *";
            // 
            // listViewDemandSet_Apartment
            // 
            this.listViewDemandSet_Apartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDAgent,
            this.FIOagent,
            this.IDClient,
            this.FIOclient,
            this.MinPrice,
            this.MaxPrice,
            this.MinArea,
            this.MaxArea,
            this.MinRooms,
            this.MaxRooms,
            this.MinFloor,
            this.MaxFloor});
            this.listViewDemandSet_Apartment.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDemandSet_Apartment.FullRowSelect = true;
            this.listViewDemandSet_Apartment.GridLines = true;
            this.listViewDemandSet_Apartment.HideSelection = false;
            this.listViewDemandSet_Apartment.Location = new System.Drawing.Point(256, 12);
            this.listViewDemandSet_Apartment.MultiSelect = false;
            this.listViewDemandSet_Apartment.Name = "listViewDemandSet_Apartment";
            this.listViewDemandSet_Apartment.Size = new System.Drawing.Size(832, 489);
            this.listViewDemandSet_Apartment.TabIndex = 42;
            this.listViewDemandSet_Apartment.UseCompatibleStateImageBehavior = false;
            this.listViewDemandSet_Apartment.View = System.Windows.Forms.View.Details;
            this.listViewDemandSet_Apartment.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Apartment_SelectedIndexChanged);
            // 
            // IDAgent
            // 
            this.IDAgent.Text = "Id риелтора";
            this.IDAgent.Width = 88;
            // 
            // FIOagent
            // 
            this.FIOagent.Text = "ФИО риелтора";
            this.FIOagent.Width = 104;
            // 
            // IDClient
            // 
            this.IDClient.Text = "Id клиента";
            this.IDClient.Width = 82;
            // 
            // FIOclient
            // 
            this.FIOclient.Text = "ФИО клиента";
            this.FIOclient.Width = 100;
            // 
            // MinPrice
            // 
            this.MinPrice.Text = "Мин цена";
            this.MinPrice.Width = 83;
            // 
            // MaxPrice
            // 
            this.MaxPrice.Text = "Макс цена";
            this.MaxPrice.Width = 83;
            // 
            // MinArea
            // 
            this.MinArea.Text = "Мин площадь";
            this.MinArea.Width = 98;
            // 
            // MaxArea
            // 
            this.MaxArea.Text = "Макс площадь";
            this.MaxArea.Width = 107;
            // 
            // MinRooms
            // 
            this.MinRooms.Text = "Мин кол-во комнат";
            // 
            // MaxRooms
            // 
            this.MaxRooms.Text = "Макс кол-во комнат";
            // 
            // MinFloor
            // 
            this.MinFloor.Text = "Мин этаж";
            // 
            // MaxFloor
            // 
            this.MaxFloor.Text = "Макс этаж";
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinPrice.Location = new System.Drawing.Point(12, 140);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(122, 15);
            this.labelMinPrice.TabIndex = 44;
            this.labelMinPrice.Text = "Минимальная цена";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxPrice.Location = new System.Drawing.Point(12, 181);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(129, 15);
            this.labelMaxPrice.TabIndex = 45;
            this.labelMaxPrice.Text = "Максимальная цена";
            // 
            // labelMinArea
            // 
            this.labelMinArea.AutoSize = true;
            this.labelMinArea.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinArea.Location = new System.Drawing.Point(12, 222);
            this.labelMinArea.Name = "labelMinArea";
            this.labelMinArea.Size = new System.Drawing.Size(146, 15);
            this.labelMinArea.TabIndex = 46;
            this.labelMinArea.Text = "Минимальная площадь";
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(15, 158);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(214, 20);
            this.textBoxMinPrice.TabIndex = 47;
            this.textBoxMinPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(15, 199);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(214, 20);
            this.textBoxMaxPrice.TabIndex = 48;
            // 
            // textBoxMinArea
            // 
            this.textBoxMinArea.Location = new System.Drawing.Point(15, 240);
            this.textBoxMinArea.Name = "textBoxMinArea";
            this.textBoxMinArea.Size = new System.Drawing.Size(214, 20);
            this.textBoxMinArea.TabIndex = 49;
            // 
            // textBoxMaxArea
            // 
            this.textBoxMaxArea.Location = new System.Drawing.Point(15, 281);
            this.textBoxMaxArea.Name = "textBoxMaxArea";
            this.textBoxMaxArea.Size = new System.Drawing.Size(214, 20);
            this.textBoxMaxArea.TabIndex = 50;
            // 
            // labelMaxArea
            // 
            this.labelMaxArea.AutoSize = true;
            this.labelMaxArea.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxArea.Location = new System.Drawing.Point(12, 263);
            this.labelMaxArea.Name = "labelMaxArea";
            this.labelMaxArea.Size = new System.Drawing.Size(153, 15);
            this.labelMaxArea.TabIndex = 51;
            this.labelMaxArea.Text = "Максимальная площадь";
            // 
            // labelMinRooms
            // 
            this.labelMinRooms.AutoSize = true;
            this.labelMinRooms.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinRooms.Location = new System.Drawing.Point(12, 304);
            this.labelMinRooms.Name = "labelMinRooms";
            this.labelMinRooms.Size = new System.Drawing.Size(210, 15);
            this.labelMinRooms.TabIndex = 52;
            this.labelMinRooms.Text = "Минимальное количество комнат";
            // 
            // labelMaxRooms
            // 
            this.labelMaxRooms.AutoSize = true;
            this.labelMaxRooms.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxRooms.Location = new System.Drawing.Point(12, 345);
            this.labelMaxRooms.Name = "labelMaxRooms";
            this.labelMaxRooms.Size = new System.Drawing.Size(217, 15);
            this.labelMaxRooms.TabIndex = 53;
            this.labelMaxRooms.Text = "Максимальное количество комнат";
            // 
            // textBoxMinRooms
            // 
            this.textBoxMinRooms.Location = new System.Drawing.Point(15, 322);
            this.textBoxMinRooms.Name = "textBoxMinRooms";
            this.textBoxMinRooms.Size = new System.Drawing.Size(214, 20);
            this.textBoxMinRooms.TabIndex = 54;
            // 
            // textBoxMaxRooms
            // 
            this.textBoxMaxRooms.Location = new System.Drawing.Point(15, 363);
            this.textBoxMaxRooms.Name = "textBoxMaxRooms";
            this.textBoxMaxRooms.Size = new System.Drawing.Size(214, 20);
            this.textBoxMaxRooms.TabIndex = 55;
            // 
            // labelMinFloor
            // 
            this.labelMinFloor.AutoSize = true;
            this.labelMinFloor.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinFloor.Location = new System.Drawing.Point(12, 386);
            this.labelMinFloor.Name = "labelMinFloor";
            this.labelMinFloor.Size = new System.Drawing.Size(126, 15);
            this.labelMinFloor.TabIndex = 56;
            this.labelMinFloor.Text = "Минимальный этаж";
            // 
            // textBoxMinFloor
            // 
            this.textBoxMinFloor.Location = new System.Drawing.Point(15, 404);
            this.textBoxMinFloor.Name = "textBoxMinFloor";
            this.textBoxMinFloor.Size = new System.Drawing.Size(214, 20);
            this.textBoxMinFloor.TabIndex = 57;
            // 
            // labelMaxFloor
            // 
            this.labelMaxFloor.AutoSize = true;
            this.labelMaxFloor.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxFloor.Location = new System.Drawing.Point(12, 427);
            this.labelMaxFloor.Name = "labelMaxFloor";
            this.labelMaxFloor.Size = new System.Drawing.Size(133, 15);
            this.labelMaxFloor.TabIndex = 58;
            this.labelMaxFloor.Text = "Максимальный этаж";
            // 
            // textBoxMaxFloor
            // 
            this.textBoxMaxFloor.Location = new System.Drawing.Point(15, 445);
            this.textBoxMaxFloor.Name = "textBoxMaxFloor";
            this.textBoxMaxFloor.Size = new System.Drawing.Size(214, 20);
            this.textBoxMaxFloor.TabIndex = 59;
            // 
            // labelMinFloors
            // 
            this.labelMinFloors.AutoSize = true;
            this.labelMinFloors.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinFloors.Location = new System.Drawing.Point(12, 304);
            this.labelMinFloors.Name = "labelMinFloors";
            this.labelMinFloors.Size = new System.Drawing.Size(157, 15);
            this.labelMinFloors.TabIndex = 60;
            this.labelMinFloors.Text = "Минимальная этажность";
            this.labelMinFloors.Visible = false;
            // 
            // textBoxMinFloors
            // 
            this.textBoxMinFloors.Location = new System.Drawing.Point(15, 322);
            this.textBoxMinFloors.Name = "textBoxMinFloors";
            this.textBoxMinFloors.Size = new System.Drawing.Size(214, 20);
            this.textBoxMinFloors.TabIndex = 61;
            this.textBoxMinFloors.Visible = false;
            // 
            // labelMaxFloors
            // 
            this.labelMaxFloors.AutoSize = true;
            this.labelMaxFloors.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxFloors.Location = new System.Drawing.Point(12, 345);
            this.labelMaxFloors.Name = "labelMaxFloors";
            this.labelMaxFloors.Size = new System.Drawing.Size(164, 15);
            this.labelMaxFloors.TabIndex = 62;
            this.labelMaxFloors.Text = "Максимальная этажность";
            this.labelMaxFloors.Visible = false;
            // 
            // textBoxMaxFloors
            // 
            this.textBoxMaxFloors.Location = new System.Drawing.Point(15, 362);
            this.textBoxMaxFloors.Name = "textBoxMaxFloors";
            this.textBoxMaxFloors.Size = new System.Drawing.Size(214, 20);
            this.textBoxMaxFloors.TabIndex = 63;
            this.textBoxMaxFloors.Visible = false;
            // 
            // listViewDemandSet_Land
            // 
            this.listViewDemandSet_Land.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDagent_L,
            this.FIOagent_L,
            this.IDclient_L,
            this.FIOclient_L,
            this.MinPrice_L,
            this.MaxPrice_L,
            this.MinArea_L,
            this.MaxArea_L});
            this.listViewDemandSet_Land.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDemandSet_Land.FullRowSelect = true;
            this.listViewDemandSet_Land.GridLines = true;
            this.listViewDemandSet_Land.HideSelection = false;
            this.listViewDemandSet_Land.Location = new System.Drawing.Point(256, 12);
            this.listViewDemandSet_Land.MultiSelect = false;
            this.listViewDemandSet_Land.Name = "listViewDemandSet_Land";
            this.listViewDemandSet_Land.Size = new System.Drawing.Size(832, 489);
            this.listViewDemandSet_Land.TabIndex = 64;
            this.listViewDemandSet_Land.UseCompatibleStateImageBehavior = false;
            this.listViewDemandSet_Land.View = System.Windows.Forms.View.Details;
            this.listViewDemandSet_Land.Visible = false;
            this.listViewDemandSet_Land.SelectedIndexChanged += new System.EventHandler(this.listViewDemandSet_Land_SelectedIndexChanged);
            // 
            // IDagent_L
            // 
            this.IDagent_L.Text = "Id риелтора";
            this.IDagent_L.Width = 95;
            // 
            // FIOagent_L
            // 
            this.FIOagent_L.Text = "ФИО риелтора";
            this.FIOagent_L.Width = 106;
            // 
            // IDclient_L
            // 
            this.IDclient_L.Text = "Id клиента";
            this.IDclient_L.Width = 82;
            // 
            // FIOclient_L
            // 
            this.FIOclient_L.Text = "ФИО клиента";
            this.FIOclient_L.Width = 98;
            // 
            // MinPrice_L
            // 
            this.MinPrice_L.Text = "Мин цена";
            this.MinPrice_L.Width = 79;
            // 
            // MaxPrice_L
            // 
            this.MaxPrice_L.Text = "Макс цена";
            this.MaxPrice_L.Width = 81;
            // 
            // MinArea_L
            // 
            this.MinArea_L.Text = "Мин площадь";
            this.MinArea_L.Width = 97;
            // 
            // MaxArea_L
            // 
            this.MaxArea_L.Text = "Макс площадь";
            this.MaxArea_L.Width = 120;
            // 
            // listViewDemandSet_House
            // 
            this.listViewDemandSet_House.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDAgent_H,
            this.FIOagent_H,
            this.IDclient_H,
            this.FIOclient_H,
            this.MinPrice_H,
            this.MaxPrice_H,
            this.MinArea_H,
            this.MaxArea_H,
            this.MinFloors,
            this.MaxFloors});
            this.listViewDemandSet_House.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDemandSet_House.FullRowSelect = true;
            this.listViewDemandSet_House.GridLines = true;
            this.listViewDemandSet_House.HideSelection = false;
            this.listViewDemandSet_House.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewDemandSet_House.Location = new System.Drawing.Point(256, 12);
            this.listViewDemandSet_House.MultiSelect = false;
            this.listViewDemandSet_House.Name = "listViewDemandSet_House";
            this.listViewDemandSet_House.Size = new System.Drawing.Size(832, 489);
            this.listViewDemandSet_House.TabIndex = 65;
            this.listViewDemandSet_House.UseCompatibleStateImageBehavior = false;
            this.listViewDemandSet_House.View = System.Windows.Forms.View.Details;
            this.listViewDemandSet_House.Visible = false;
            this.listViewDemandSet_House.SelectedIndexChanged += new System.EventHandler(this.listViewDemandSet_House_SelectedIndexChanged);
            // 
            // IDAgent_H
            // 
            this.IDAgent_H.Text = "Id риелтора";
            this.IDAgent_H.Width = 91;
            // 
            // FIOagent_H
            // 
            this.FIOagent_H.Text = "ФИО риелтора";
            this.FIOagent_H.Width = 103;
            // 
            // IDclient_H
            // 
            this.IDclient_H.Text = "Id клиента";
            this.IDclient_H.Width = 108;
            // 
            // FIOclient_H
            // 
            this.FIOclient_H.Text = "ФИО клиента";
            this.FIOclient_H.Width = 107;
            // 
            // MinPrice_H
            // 
            this.MinPrice_H.Text = "Мин цена";
            this.MinPrice_H.Width = 77;
            // 
            // MaxPrice_H
            // 
            this.MaxPrice_H.Text = "Макс цена";
            this.MaxPrice_H.Width = 88;
            // 
            // MinArea_H
            // 
            this.MinArea_H.Text = "Мин площадь";
            this.MinArea_H.Width = 97;
            // 
            // MaxArea_H
            // 
            this.MaxArea_H.Text = "Макс площадь";
            this.MaxArea_H.Width = 92;
            // 
            // MinFloors
            // 
            this.MinFloors.Text = "Мин этажность";
            this.MinFloors.Width = 79;
            // 
            // MaxFloors
            // 
            this.MaxFloors.Text = "Макс этажность";
            this.MaxFloors.Width = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 485);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // FormDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewDemandSet_Apartment);
            this.Controls.Add(this.listViewDemandSet_House);
            this.Controls.Add(this.listViewDemandSet_Land);
            this.Controls.Add(this.textBoxMaxFloors);
            this.Controls.Add(this.labelMaxFloors);
            this.Controls.Add(this.textBoxMinFloors);
            this.Controls.Add(this.labelMinFloors);
            this.Controls.Add(this.textBoxMaxFloor);
            this.Controls.Add(this.labelMaxFloor);
            this.Controls.Add(this.textBoxMinFloor);
            this.Controls.Add(this.labelMinFloor);
            this.Controls.Add(this.textBoxMaxRooms);
            this.Controls.Add(this.textBoxMinRooms);
            this.Controls.Add(this.labelMaxRooms);
            this.Controls.Add(this.labelMinRooms);
            this.Controls.Add(this.labelMaxArea);
            this.Controls.Add(this.textBoxMaxArea);
            this.Controls.Add(this.textBoxMinArea);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.labelMinArea);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.comboBoxAgents);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDemand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потребности";
            this.Load += new System.EventHandler(this.FormDemand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ListView listViewDemandSet_Apartment;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.Label labelMinArea;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMinArea;
        private System.Windows.Forms.TextBox textBoxMaxArea;
        private System.Windows.Forms.Label labelMaxArea;
        private System.Windows.Forms.Label labelMinRooms;
        private System.Windows.Forms.Label labelMaxRooms;
        private System.Windows.Forms.TextBox textBoxMinRooms;
        private System.Windows.Forms.TextBox textBoxMaxRooms;
        private System.Windows.Forms.Label labelMinFloor;
        private System.Windows.Forms.TextBox textBoxMinFloor;
        private System.Windows.Forms.Label labelMaxFloor;
        private System.Windows.Forms.TextBox textBoxMaxFloor;
        private System.Windows.Forms.Label labelMinFloors;
        private System.Windows.Forms.TextBox textBoxMinFloors;
        private System.Windows.Forms.Label labelMaxFloors;
        private System.Windows.Forms.TextBox textBoxMaxFloors;
        private System.Windows.Forms.ColumnHeader IDAgent;
        private System.Windows.Forms.ColumnHeader FIOagent;
        private System.Windows.Forms.ColumnHeader IDClient;
        private System.Windows.Forms.ColumnHeader FIOclient;
        private System.Windows.Forms.ColumnHeader MinPrice;
        private System.Windows.Forms.ColumnHeader MaxPrice;
        private System.Windows.Forms.ColumnHeader MinArea;
        private System.Windows.Forms.ColumnHeader MaxArea;
        private System.Windows.Forms.ColumnHeader MinRooms;
        private System.Windows.Forms.ColumnHeader MaxRooms;
        private System.Windows.Forms.ColumnHeader MinFloor;
        private System.Windows.Forms.ColumnHeader MaxFloor;
        private System.Windows.Forms.ListView listViewDemandSet_Land;
        private System.Windows.Forms.ColumnHeader IDagent_L;
        private System.Windows.Forms.ColumnHeader FIOagent_L;
        private System.Windows.Forms.ColumnHeader IDclient_L;
        private System.Windows.Forms.ColumnHeader FIOclient_L;
        private System.Windows.Forms.ColumnHeader MinPrice_L;
        private System.Windows.Forms.ColumnHeader MaxPrice_L;
        private System.Windows.Forms.ColumnHeader MinArea_L;
        private System.Windows.Forms.ColumnHeader MaxArea_L;
        private System.Windows.Forms.ListView listViewDemandSet_House;
        private System.Windows.Forms.ColumnHeader IDAgent_H;
        private System.Windows.Forms.ColumnHeader FIOagent_H;
        private System.Windows.Forms.ColumnHeader IDclient_H;
        private System.Windows.Forms.ColumnHeader FIOclient_H;
        private System.Windows.Forms.ColumnHeader MinPrice_H;
        private System.Windows.Forms.ColumnHeader MaxPrice_H;
        private System.Windows.Forms.ColumnHeader MinArea_H;
        private System.Windows.Forms.ColumnHeader MaxArea_H;
        private System.Windows.Forms.ColumnHeader MinFloors;
        private System.Windows.Forms.ColumnHeader MaxFloors;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}