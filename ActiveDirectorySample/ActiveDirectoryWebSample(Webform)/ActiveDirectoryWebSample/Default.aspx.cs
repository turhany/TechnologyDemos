using System;
using System.Web;

using System.DirectoryServices;
using System.Collections;
using System.Security.Principal;

namespace ActiveDirectoryWebSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList2.DataSource = getGroupsFromUser("LDAP://corporate.local", "", "", "turhanyildirim");
            DropDownList2.DataBind();
        }

        void Page_PreRender(object sender, EventArgs e)
        {
            String NameForUserPrincipal = HttpContext.Current.User.Identity.Name;
            DropDownList1.Items.Add("1" + NameForUserPrincipal );
            //Boş

            string strUsr = WindowsIdentity.GetCurrent().Name;
            DropDownList1.Items.Add("2" + strUsr);
            //NT Autherity/NetworkService

            String username = Environment.UserName;
            DropDownList1.Items.Add("3" + username);
            //NetworkService

            String username1 = Page.User.Identity.Name;
            DropDownList1.Items.Add("4" + username1);

            WindowsPrincipal p = System.Threading.Thread.CurrentPrincipal as WindowsPrincipal;
            string username2 = p.Identity.Name;
            DropDownList1.Items.Add("5" + username2);

            String username3 = Request.ServerVariables["AUTH_USER"];
            DropDownList1.Items.Add("6" + username3);

            String username4 = WindowsIdentity.GetCurrent().Name;
            DropDownList1.Items.Add("7" + username4);

            String username5 = Environment.GetEnvironmentVariable("USERNAME");
            DropDownList1.Items.Add("8" + username5);

            String username6 = System.Net.CredentialCache.DefaultNetworkCredentials.UserName;
            DropDownList1.Items.Add("10" + username6);

            String username7 = System.Net.CredentialCache.DefaultCredentials.ToString();
            DropDownList1.Items.Add("11" + username7);

        }
          
        private ArrayList getGroupsFromUser(string rootpath, string userName, string pwd, string strUser)
        {
            ArrayList groupMembers = new ArrayList();
            DirectoryEntry de;
            DirectorySearcher ds;
            if (userName != "")
            {
                de = new DirectoryEntry(rootpath, userName, pwd);
                ds = new DirectorySearcher(de);
            }
            else
            {
                ds = new DirectorySearcher(rootpath);
            }

            // find all users in this group  

            ds.Filter = String.Format("(&(samaccountname={0})(objectClass=person))", strUser);
            ds.PropertiesToLoad.Add("memberof");
            try
            {
                foreach (SearchResult sr in ds.FindAll())
                {
                    foreach (string str in sr.Properties["memberof"])
                    {
                        string str2 = str.Substring(str.IndexOf("=") + 1, str.IndexOf(",") - str.IndexOf("=") - 1);
                        groupMembers.Add(str2);
                        Response.Write(str2 + "  ");
                    }
                }
            }
            catch
            {
                //ignore if any properties found in AD  
            }
            return groupMembers;
        }
    }
}