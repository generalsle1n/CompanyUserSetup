using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUserSetup.Model
{
    internal class RawUser
    {
        internal string FirstName { get;set; }
        internal string LastName { get;set; }
        internal string TemplateUser { get;set; }
        internal string ManagerUser { get;set; }
        internal string CostCenter { get;set; }
        internal string TokenID { get;set; }
        internal bool MSNavision { get;set; }
        internal bool MSIntune { get; set; }
        internal bool MSProject { get; set; }
        internal bool MSOffice { get; set; }


    }
}
