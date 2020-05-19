﻿using System;
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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }

        private void buttonDel_Click(object sender, EventArgs e) //
        {
            try
            {
                if (listViewSupplySet.SelectedItems.Count == 1)
                {
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    Program.wftDb.SupplySet.Remove(supply);
                    Program.wftDb.SaveChanges();
                    ShowSupplySet();
                }
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            catch { MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FormSupply_Load(object sender, EventArgs e)
        {

        }

        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                string[] item = { agentSet.Id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName};
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }
        
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName};
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }

        void ShowRealEstate()
        {
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstateSet in Program.wftDb.RealEstateSet)
            {
                string[] item = { realEstateSet.Id.ToString() + ".", realEstateSet.Address_City + ",",
                realEstateSet.Address_Street + ",", "д. " + realEstateSet.Address_House + ",",
                "кв. " + realEstateSet.Address_Number + ",", "широта: " + realEstateSet.Coordinate_latitude + ",",
                "долгота: " + realEstateSet.Coordinate_longitude };
                comboBoxRealEstate.Items.Add(string.Join(" ", item));         
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null &&
                comboBoxRealEstate != null && textBoxPrice.Text != "")
            {
                SupplySet supply = new SupplySet();
                supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.wftDb.SupplySet.Add(supply);
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ShowSupplySet()
        {
            listViewSupplySet.Items.Clear();
            foreach(SupplySet supply in Program.wftDb.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    supply.IdAgent.ToString(), 
                    supply.AgentSet.LastName+" "+supply.AgentSet.FirstName+" "+supply.AgentSet.MiddleName,
                    supply.IdClient.ToString(), 
                    supply.ClientsSet.LastName+" "+supply.ClientsSet.FirstName+" "+supply.ClientsSet.MiddleName,
                    supply.IdRealEstate.ToString(), 
                    "г. "+supply.RealEstateSet.Address_City+", ул. "+supply.RealEstateSet.Address_Street+
                    ", д. "+supply.RealEstateSet.Address_House+", кв. "+supply.RealEstateSet.Address_Number,
                    supply.Price.ToString()
                });
                item.Tag = supply;
                listViewSupplySet.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                try
                {
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    if (comboBoxAgents.Text == "" || comboBoxClients.Text == "" || comboBoxRealEstate.Text == "" ||textBoxPrice.Text == "")
                    {
                        throw new Exception("Обязательные поля не были заполнены!");
                    }
                    supply.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                    supply.Price = Convert.ToInt64(textBoxPrice.Text);
                    
                    Program.wftDb.SaveChanges();
                    ShowSupplySet();
                }
                catch (Exception ex) { MessageBox.Show("" + ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }   

        private void listViewSupplySet_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(supply.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supply.IdClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supply.IdRealEstate.ToString());
                textBoxPrice.Text = supply.Price.ToString();
            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }
    }
    
}
