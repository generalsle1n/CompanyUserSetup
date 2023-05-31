using CompanyUserSetup.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace CompanyUserSetup.SubForms.CreateNewUser
{
    public partial class CreateNewUserMain : Form
    {
        public CreateNewUserMain()
        {
            InitializeComponent();
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            RawUser uiUser = new RawUser()
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                TemplateUser = tempalteUserText.Text,
                ManagerUser = managerUserText.Text,
                CostCenter = costCenterText.Text,
                TokenID = tokenIDText.Text
            };
            CheckedItemCollection AllItem = extraSettingsBox.CheckedItems;

            foreach(string Item in AllItem)
            {
                switch(Item)
                {
                    case "MSNavision":
                        uiUser.MSNavision = true;
                        break;
                    case "MSIntune":
                        uiUser.MSIntune = true;
                        break;
                    case "MSProject":
                        uiUser.MSProject = true;
                        break;
                    case "MSOffice":
                        uiUser.MSOffice = true;
                        break;
                }
            }
        }
    }
}
