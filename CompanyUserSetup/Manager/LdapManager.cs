using CompanyUserSetup.Model;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUserSetup.Manager
{
    internal class LdapManager
    {
        internal async Task<bool> CreateUser(RawUser NewUser)
        {
            using(DirectoryEntry _ldapConnection = new DirectoryEntry())
            using (DirectorySearcher _search = new DirectorySearcher(_ldapConnection))
            {
                _search.Filter = $"UserPrincipalName={NewUser.TemplateUser}";
                SearchResult result = _search.FindOne();
                DirectoryEntry templateUser = result.GetDirectoryEntry();
            }
            return true;
        }
    }
}
