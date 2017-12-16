using Projet_ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projet_ORM.Model
{
    class CAD : ICAD
    {
        private BdContext bd;

        public CAD()
        {
            bd = new BdContext();
        }

        public List<Contact> ObtenirContacts()
        {
            return bd.Contacts.ToList();
        }
    }
}
