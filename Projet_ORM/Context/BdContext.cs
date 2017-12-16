using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Projet_ORM.Model;

namespace Projet_ORM.Context
{
    // Permet d'acceder aux données 
    class BdContext : DbContext
    {
        public DbSet<Contact>Contacts {get; set;} // Il s'agit du point d'entrée du contexte 
    }
}
