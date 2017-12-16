using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_ORM.Model
{
    // Creation d'un contact où chacun possede un identifiant 
    class Contact
    {
       public int Id { get; set; }
       public string Nom { get; set; }
       public string Prenom { get; set; }
       public string Adresse { get; set; }
       public DateTime Datenaissannce { get; set; }
    }
}
