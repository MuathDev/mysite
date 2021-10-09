using System;
using System.Collections.Generic;

namespace Core.Entities
{
   public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Profil { get; set; }
        public Address Address { get; set; }
        public Images images { get; set; }
    }

}
