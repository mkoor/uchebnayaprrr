using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormDemand : Form
    {
        public FormDemand()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowDemandSet();
            ShowAgents();
            ShowClients();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewRealEstateSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;

                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demand.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMinRooms.Text = demand.MinRooms.ToString();
                textBoxMaxRooms.Text = demand.MaxRooms.ToString();
                textBoxMinFloor.Text = demand.MinFloor.ToString();
                textBoxMaxFloor.Text = demand.MaxFloor.ToString();
            }
            else
            {
                comboBoxClients.SelectedItem = null;
                comboBoxAgents.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
            }
        }

        private void FormDemand_Load(object sender, EventArgs e)
        {

        }

        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                string[] item = { agentSet.Id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }

        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewDemandSet_Apartment.Visible = true;                
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                labelMinFloor.Visible = true;
                textBoxMinFloor.Visible = true;
                labelMaxFloor.Visible = true;
                textBoxMaxFloor.Visible = true;

                listViewDemandSet_House.Visible = false;
                listViewDemandSet_Land.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewDemandSet_House.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMaxFloors.Visible = true;
                labelMinFloors.Visible = true;
                textBoxMinFloors.Visible = true;

                listViewDemandSet_Apartment.Visible = false;
                listViewDemandSet_Land.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewDemandSet_Land.Visible = true;

                listViewDemandSet_House.Visible = false;
                listViewDemandSet_Apartment.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;

                comboBoxClients.SelectedItem = null;
                comboBoxAgents.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxType.SelectedItem != null)
            {
                DemandSet demand = new DemandSet();
              
                demand.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                demand.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                if (textBoxMaxArea.Text != "")
                { demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text); }
                else  demand.MaxArea = null; 
                if (textBoxMaxPrice.Text != "")
                { demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text); }
                else demand.MaxPrice = null;
                if (textBoxMinArea.Text != "")
                { demand.MinArea = Convert.ToInt32(textBoxMinArea.Text); }
                else demand.MinArea = null;
                if (textBoxMinPrice.Text != "")
                { demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text); }
                else demand.MinPrice = null;

                if (comboBoxType.SelectedIndex == 0)
                {
                    demand.Type = 0;
                    if (textBoxMinRooms.Text != "")
                    { demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text); }
                    else demand.MinRooms = null;
                    if (textBoxMaxRooms.Text != "")
                    { demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text); }
                    else demand.MaxRooms = null;
                    if (textBoxMinFloor.Text != "")
                    { demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text); }
                    else demand.MinFloor = null;
                    if (textBoxMaxFloor.Text != "")
                    { demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text); }
                    else demand.MaxFloor = null;
                }
                else if (comboBoxType.SelectedIndex == 1) 
                {
                    demand.Type = 1;
                    if (textBoxMinFloors.Text != "")
                    { demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text); }
                    else demand.MinFloors = null;
                    if (textBoxMaxFloors.Text != "")
                    { demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text); }
                    else demand.MaxFloors = null;
                }
                else
                {
                    demand.Type = 2;
                }

                Program.wftDb.DemandSet.Add(demand);
                Program.wftDb.SaveChanges();
                ShowDemandSet();
            } else MessageBox.Show("Обязательные поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }
        void ShowDemandSet()
        {
            listViewDemandSet_Apartment.Items.Clear();
            listViewDemandSet_House.Items.Clear();
            listViewDemandSet_Land.Items.Clear();

            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                if (demand.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                            demand.IdAgent.ToString(), 
                            demand.AgentSet.LastName+" "+demand.AgentSet.FirstName.Remove(1)+"."+demand.AgentSet.MiddleName.Remove(1)+".",
                            demand.IdClient.ToString(),
                            demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName.Remove(1)+"."+demand.ClientsSet.MiddleName.Remove(1)+".",
                            demand.MinPrice.ToString(), demand.MaxPrice.ToString(), demand.MinArea.ToString(),
                            demand.MaxArea.ToString(), demand.MinRooms.ToString(), demand.MaxRooms.ToString(), demand.MinFloor.ToString(),
                            demand.MaxFloor.ToString()
                    });
                    item.Tag = demand;
                    listViewDemandSet_Apartment.Items.Add(item);
                }
                else if (demand.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                            demand.IdAgent.ToString(),
                            demand.AgentSet.LastName+" "+demand.AgentSet.FirstName.Remove(1)+"."+demand.AgentSet.MiddleName.Remove(1)+".",
                            demand.IdClient.ToString(),
                            demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName.Remove(1)+"."+demand.ClientsSet.MiddleName.Remove(1)+".",
                            demand.MinPrice.ToString(), demand.MaxPrice.ToString(), demand.MinArea.ToString(),
                            demand.MaxArea.ToString(), demand.MinFloors.ToString(), demand.MaxFloors.ToString()
                    });
                    item.Tag = demand;
                    listViewDemandSet_House.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                            demand.IdAgent.ToString(),
                            demand.AgentSet.LastName+" "+demand.AgentSet.FirstName.Remove(1)+"."+demand.AgentSet.MiddleName.Remove(1)+".",
                            demand.IdClient.ToString(),
                            demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName.Remove(1)+"."+demand.ClientsSet.MiddleName.Remove(1)+".",
                            demand.MinPrice.ToString(), demand.MaxPrice.ToString(), demand.MinArea.ToString(),
                            demand.MaxArea.ToString()
                    });
                    item.Tag = demand;
                    listViewDemandSet_Land.Items.Add(item);
                }
                listViewDemandSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewDemandSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewDemandSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }
        }

        private void labelClient_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
                {
                    try
                    {
                        DemandSet demand = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;

                        if (comboBoxAgents.Text == "" || comboBoxClients.Text == "" || comboBoxType.Text == "")
                        {
                            throw new Exception("Обязательные поля не заполнены!");
                        }

                        if (textBoxMinPrice.Text != "")
                        { demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text); }
                        else demand.MinPrice = null;

                        if (textBoxMaxPrice.Text != "")
                        { demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text); }
                        else demand.MaxPrice = null;

                        if (textBoxMinArea.Text != "")
                        { demand.MinArea = Convert.ToInt64(textBoxMinArea.Text); }
                        else demand.MinArea = null;

                        if (textBoxMaxArea.Text != "")
                        { demand.MaxArea = Convert.ToInt64(textBoxMaxArea.Text); }
                        else demand.MaxArea = null;

                        if (textBoxMinRooms.Text != "")
                        { demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text); }
                        else demand.MinRooms = null;

                        if (textBoxMaxRooms.Text != "")
                        { demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text); }
                        else demand.MaxRooms = null;

                        if (textBoxMinFloor.Text != "")
                        { demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text); }
                        else demand.MinFloor = null;

                        if (textBoxMaxFloor.Text != "")
                        { demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text); }
                        else demand.MaxFloor = null;

                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewDemandSet_House.SelectedItems.Count == 1)
                {
                    try
                    {
                        DemandSet demand = listViewDemandSet_House.SelectedItems[0].Tag as DemandSet;

                        if (comboBoxAgents.Text == "" || comboBoxClients.Text == "" || comboBoxType.Text == "")
                        {
                            throw new Exception("Обязательные поля не заполнены!");
                        }

                        if (textBoxMinPrice.Text != "")
                        { demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text); }
                        else demand.MinPrice = null;

                        if (textBoxMaxPrice.Text != "")
                        { demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text); }
                        else demand.MaxPrice = null;

                        if (textBoxMinArea.Text != "")
                        { demand.MinArea = Convert.ToInt64(textBoxMinArea.Text); }
                        else demand.MinArea = null;

                        if (textBoxMaxArea.Text != "")
                        { demand.MaxArea = Convert.ToInt64(textBoxMaxArea.Text); }
                        else demand.MaxArea = null;

                        if (textBoxMinFloors.Text != "")
                        { demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text); }
                        else demand.MinFloors = null;

                        if (textBoxMaxFloors.Text != "")
                        { demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text); }
                        else demand.MaxFloors = null;

                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                }
            }
            else
            {
                if (listViewDemandSet_Land.SelectedItems.Count == 1)
                {
                    try
                    {
                        DemandSet demand = listViewDemandSet_Land.SelectedItems[0].Tag as DemandSet;

                        if (comboBoxAgents.Text == "" || comboBoxClients.Text == "" || comboBoxType.Text == "")
                        {
                            throw new Exception("Обязательные поля не заполнены!");
                        }

                        if (textBoxMinPrice.Text != "")
                        { demand.MinPrice = Convert.ToInt64(textBoxMinPrice.Text); }
                        else demand.MinPrice = null;

                        if (textBoxMaxPrice.Text != "")
                        { demand.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text); }
                        else demand.MaxPrice = null;

                        if (textBoxMinArea.Text != "")
                        { demand.MinArea = Convert.ToInt64(textBoxMinArea.Text); }
                        else demand.MinArea = null;

                        if (textBoxMaxArea.Text != "")
                        { demand.MaxArea = Convert.ToInt64(textBoxMaxArea.Text); }
                        else demand.MaxArea = null;

                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        private void listViewDemandSet_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDemandSet_House.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewDemandSet_House.SelectedItems[0].Tag as DemandSet;

                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demand.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();
                textBoxMinFloors.Text = demand.MinFloors.ToString();
                textBoxMaxFloors.Text = demand.MaxFloors.ToString();
            }
            else
            {
                comboBoxClients.SelectedItem = null;
                comboBoxAgents.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
        }

        private void listViewDemandSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDemandSet_Land.SelectedItems.Count == 1)
            {
                DemandSet demand = listViewDemandSet_Land.SelectedItems[0].Tag as DemandSet;

                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(demand.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(demand.IdClient.ToString());
                textBoxMinPrice.Text = demand.MinPrice.ToString();
                textBoxMaxPrice.Text = demand.MaxPrice.ToString();
                textBoxMinArea.Text = demand.MinArea.ToString();
                textBoxMaxArea.Text = demand.MaxArea.ToString();                
            }
            else
            {
                comboBoxClients.SelectedItem = null;
                comboBoxAgents.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxClients.SelectedItem = null;
                    comboBoxAgents.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";             
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewDemandSet_House.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewDemandSet_House.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxClients.SelectedItem = null;
                    comboBoxAgents.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                }
                else
                {
                    if (listViewDemandSet_Land.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewDemandSet_Land.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxClients.SelectedItem = null;
                    comboBoxAgents.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                }
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись использутеся", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
