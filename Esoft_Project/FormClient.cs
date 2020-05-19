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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;

                textBoxFirstName.Text = clientSet.FirstName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxPhone.Text = clientSet.Phone;
                textBoxEmail.Text = clientSet.Email;

            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        void ShowClient()
        {
            listViewClient.Items.Clear();

            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        clientsSet.Id.ToString(), clientsSet.FirstName, clientsSet.MiddleName,
                        clientsSet.LastName, clientsSet.Phone, clientsSet.Email
                });
                item.Tag = clientsSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            ClientsSet clientSet = new ClientsSet();

            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.Phone = textBoxPhone.Text;
            clientSet.Email = textBoxEmail.Text;

            Program.wftDb.ClientsSet.Add(clientSet);

            Program.wftDb.SaveChanges();
            ShowClient();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.Phone = textBoxPhone.Text;
                clientSet.Email = textBoxEmail.Text;

                Program.wftDb.SaveChanges();

                ShowClient();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    Program.wftDb.ClientsSet.Remove(clientSet);
                    Program.wftDb.SaveChanges();
                    ShowClient();
                }

                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        } //
    }
}
