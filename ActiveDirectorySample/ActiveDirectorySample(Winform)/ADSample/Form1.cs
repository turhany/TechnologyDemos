using System;
using System.Windows.Forms;

using System.DirectoryServices.AccountManagement;

namespace ADSample
{
    public partial class Form1 : Form
    {
        //PrincipalContext insPrincipalContext = new PrincipalContext(ContextType.Machine, "Makineİsmi", "KullanıcıAdı", "KullanıcınınŞifresi");

        PrincipalContext insPrincipalContext = new PrincipalContext(ContextType.Domain);
        public Form1()
        {
            InitializeComponent();
        }

        private void ListGroups()
        {
            GroupPrincipal ObjectGroupPrincipal = new GroupPrincipal(insPrincipalContext);
            ObjectGroupPrincipal.Name = "*";
            PrincipalSearcher ObjectPrincipalSearcher = new PrincipalSearcher();
            ObjectPrincipalSearcher.QueryFilter = ObjectGroupPrincipal;
            PrincipalSearchResult<Principal> SearchResults = ObjectPrincipalSearcher.FindAll();
            ADGroupsComboBox.Items.Clear();
            foreach (Principal p in SearchResults)
            {
                ADGroupsComboBox.Items.Add(p);
            }
        }
        private void ListUsers()
        {
            UserPrincipal ObjectUserPrincipal = new UserPrincipal(insPrincipalContext);
            ObjectUserPrincipal.Name = "*";
            PrincipalSearcher ObjectPrincipalSearcher = new PrincipalSearcher();
            ObjectPrincipalSearcher.QueryFilter = ObjectUserPrincipal;
            PrincipalSearchResult<Principal> SearchResults = ObjectPrincipalSearcher.FindAll();
            ADUsersComboBox.Items.Clear();
            foreach (Principal p in SearchResults)
            {
                ADUsersComboBox.Items.Add(p);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListGroups();
            ListUsers();
        }
        private void UsersInGroupButton_Click(object sender, EventArgs e)
        {
            if (ADGroupsComboBox.SelectedItem == null)
            {
                MessageBox.Show("Bir Grup seçiniz!");
                return;
            }
            else
            {
                GroupPrincipal ObjectGroupPrincipal = (GroupPrincipal)ADGroupsComboBox.SelectedItem;
                foreach (Principal p in ObjectGroupPrincipal.Members)
                {
                    SelectedGroupUsersComboBox.Items.Add(p);
                }
            }
        }
        private void GetUsersGroupsButton_Click(object sender, EventArgs e)
        {
            if (ADUsersComboBox.SelectedItem == null)
            {
                MessageBox.Show("Bir Kullanıcı seçiniz!");
                return;
            }
            else
            {
                UserPrincipal UserPrincipal = (UserPrincipal)ADUsersComboBox.SelectedItem;
                foreach (Principal ppp in UserPrincipal.GetGroups())
                {
                    SelectedUserGroupsComboBox.Items.Add(ppp);
                }
            }
        }
    }
}
