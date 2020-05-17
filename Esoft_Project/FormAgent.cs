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
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
            ShowAgent();
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {
            
        }
     
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                AgentSet agentSet = new AgentSet();


                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.LastName = textBoxLastName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;

                if (agentSet.FirstName == "" || agentSet.MiddleName == "" || agentSet.LastName == "")
                {
                    throw new Exception("Поля ФИО не заполнены!");
                }
                

                if (textBoxDealShare.Text == "")
                {
                    textBoxDealShare.Text = agentSet.DealShare.ToString();
                }
                else
                {
                    agentSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                }

                if (agentSet.DealShare < 0 || agentSet.DealShare > 100)
                {
                    throw new Exception("Доля от комиссии не соответствутет диапозону от 0 до 100");
                }
                Program.wftDb.AgentSet.Add(agentSet);
                Program.wftDb.SaveChanges();
                ShowAgent();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                textBoxFirstName.Text = agentSet.FirstName;
                textBoxLastName.Text = agentSet.LastName; 
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxDealShare.Text = agentSet.DealShare.ToString();
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxDealShare.Text = "";
            }
        }
        void ShowAgent()
        {
            listViewAgent.Items.Clear();

            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        agentSet.Id.ToString(), agentSet.FirstName, agentSet.MiddleName,
                        agentSet.LastName, agentSet.DealShare.ToString()
                });
                item.Tag = agentSet;
                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                try
                {
                    AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;

                    agentSet.FirstName = textBoxFirstName.Text;
                    agentSet.LastName = textBoxLastName.Text;
                    agentSet.MiddleName = textBoxMiddleName.Text;
                    agentSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                    if (agentSet.DealShare < 0 || agentSet.DealShare > 100)
                    {
                        throw new Exception("Доля от комиссии не соответствутет диапозону от 0 до 100");
                    }
                    if (agentSet.FirstName == "" || agentSet.MiddleName == "" || agentSet.LastName == "")
                    {
                        throw new Exception("Поля ФИО не заполнены!");
                    }
                    Program.wftDb.SaveChanges();
                    ShowAgent();
                }
                catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                    Program.wftDb.AgentSet.Remove(agentSet);
                    Program.wftDb.SaveChanges();
                    ShowAgent();
                }

                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxFirstName.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
