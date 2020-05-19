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
    public partial class FormDeal : Form
    {
        public FormDeal()
        {
            InitializeComponent();
            ShowSupply();
            ShowDemand();
            ShowDealSet();
        }

        void ShowSupply()
        {
            comboBoxSupply.Items.Clear();
            foreach (SupplySet supplySet in Program.wftDb.SupplySet)
            {
                string[] item = {supplySet.Id.ToString()+". ", "Риелтор: "+
                supplySet.AgentSet.LastName+" "+ supplySet.AgentSet.FirstName.Remove(1)
                +"."+ supplySet.AgentSet.MiddleName.Remove(1)+".", "Клиент: "+supplySet.ClientsSet.LastName+" "
                +supplySet.ClientsSet.FirstName.Remove(1)+"."+supplySet.ClientsSet.MiddleName.Remove(1)+"."};
                comboBoxSupply.Items.Add(string.Join(" ", item));
            }
        }

        void ShowDemand()
        {
            comboBoxDemand.Items.Clear();
            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                string[] item =
                {
                 demand.Id.ToString()+". ","Риелтор: "+
                 demand.AgentSet.LastName+" "+demand.AgentSet.FirstName.Remove(1)
                 +"."+demand.AgentSet.MiddleName.Remove(1)+".", "Клиент: "+
                 demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName.Remove(1)+"."
                 +demand.ClientsSet.MiddleName.Remove(1)+"."
                };
                comboBoxDemand.Items.Add(string.Join(" ", item));
            }
        }

        void ShowDealSet()
        {
            listViewDealSet.Items.Clear();
            foreach (DealSet deal in Program.wftDb.DealSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    deal.SupplySet.ClientsSet.LastName+" "+deal.SupplySet.ClientsSet.FirstName.Remove(1)+
                    "."+deal.SupplySet.ClientsSet.MiddleName.Remove(1)+".",
                    deal.SupplySet.AgentSet.LastName+" "+ deal.SupplySet.AgentSet.FirstName.Remove(1)
                    +"."+ deal.SupplySet.AgentSet.MiddleName.Remove(1)+".", 
                    
                    deal.DemandSet.ClientsSet.LastName+" "+deal.DemandSet.ClientsSet.FirstName.Remove(1)+
                    "."+deal.DemandSet.ClientsSet.MiddleName.Remove(1)+".",
                    deal.DemandSet.AgentSet.LastName+" "+ deal.DemandSet.AgentSet.FirstName.Remove(1)
                    +"."+ deal.DemandSet.AgentSet.MiddleName.Remove(1)+".",
                   

                    "г. " +deal.SupplySet.RealEstateSet.Address_City+", ул. "+
                    deal.SupplySet.RealEstateSet.Address_Street+", д. "+
                    deal.SupplySet.RealEstateSet.Address_House+", кв. "+
                    deal.SupplySet.RealEstateSet.Address_Number, deal.SupplySet.Price.ToString()
                });
                item.Tag = deal;
                listViewDealSet.Items.Add(item);
            }    
        }

        void Deductions()
        {
            if (comboBoxSupply.SelectedItem != null && comboBoxDemand.SelectedItem !=null)
            {
                SupplySet supplySet = Program.wftDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                DemandSet demand = Program.wftDb.DemandSet.Find(Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]));

                double customerCompanyDeductions = supplySet.Price * 0.03;
                textBoxCustomerCompanyDeductions.Text = customerCompanyDeductions.ToString("0.00");

                if (demand.AgentSet.DealShare != null)
                {
                    double agentCustomerDeductions = customerCompanyDeductions * Convert.ToDouble(demand.AgentSet.DealShare) / 100.00;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
                else
                {
                    double agentCustomerDeductions = customerCompanyDeductions * 0.45;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }

            }
            if (comboBoxSupply.SelectedItem != null)
            {
                SupplySet supplySet = Program.wftDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));

                double sellerCompanyDeductions;
                if (supplySet.RealEstateSet.Type == 0)
                {
                    sellerCompanyDeductions = 36000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                else if (supplySet.RealEstateSet.Type == 1)
                {
                    sellerCompanyDeductions = 38000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                else
                {
                    sellerCompanyDeductions = 38000 + supplySet.Price * 0.02;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                if(supplySet.AgentSet.DealShare != null)
                {
                    double agentSellerDeductions = sellerCompanyDeductions * Convert.ToDouble(supplySet.AgentSet.DealShare) / 100.00;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
                else
                {
                    double agentSellerDeductions = sellerCompanyDeductions * 0.45;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
            }
            else
            {
                textBoxSellerCompanyDeductions.Text = "";
                textBoxAgentSellerDeductions.Text = "";
                textBoxCustomerCompanyDeductions.Text = "";
                textBoxAgentCustomerDeductions.Text = "";
            }
        }



            private void FormDeal_Load(object sender, EventArgs e)
            {

            }

        private void comboBoxSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        private void comboBoxDemand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDemand.SelectedItem != null && comboBoxSupply.SelectedItem != null)
            {
                DealSet deal = new DealSet();
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);

                Program.wftDb.DealSet.Add(deal);
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDealSet.SelectedItems.Count == 1)
            {
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                if (comboBoxSupply.Text != "")
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                else MessageBox.Show("Данные не выбраны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (comboBoxDemand.Text != "")
                    deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                else MessageBox.Show("Данные не выбраны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
        }

        private void listViewDealSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDealSet.SelectedItems.Count == 1)
            {
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                comboBoxSupply.SelectedIndex = comboBoxSupply.FindString(deal.IdSupply.ToString());
                comboBoxDemand.SelectedIndex = comboBoxDemand.FindString(deal.IdDemand.ToString());
            }
            else
            {
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDealSet.SelectedItems.Count == 1)
                {
                    DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                    Program.wftDb.DealSet.Remove(deal);
                    Program.wftDb.SaveChanges();
                    ShowDealSet();
                }
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
            catch {MessageBox.Show("Невозможно удалить, эта запись используется"
                ,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }
    }
}