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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "agent") buttonOpenAgents.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAuthorization.users.login;
            if (FormAuthorization.users.type == "agent")
            {
                labelHello.ForeColor = Color.Blue;
                label1.ForeColor = Color.Blue;
            }
            else
            {
                labelHello.ForeColor = Color.Red;
                label1.ForeColor = Color.Red;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenRealEstates_Click(object sender, EventArgs e)
        {
            Form formRealEstate = new FormRealEstate();
            formRealEstate.Show();
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            Form formAgent = new FormAgent();
            formAgent.Show();
        }

        private void buttonOpenDemands_Click(object sender, EventArgs e)
        {
            Form formSupply = new FormSupply();
            formSupply.Show();
        }

        private void buttonOpenSupplies_Click(object sender, EventArgs e)
        {
            Form formDemand = new FormDemand();
            formDemand.Show();
        }

        private void buttonOpenDeals_Click(object sender, EventArgs e)
        {
            Form formDeal = new FormDeal();
            formDeal.Show();
        }
    }
}
