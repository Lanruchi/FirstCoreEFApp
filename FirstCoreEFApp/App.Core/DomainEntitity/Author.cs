using App.Core.DomainEntitity;
using System.Collections.Generic;

namespace App.Core.DomainEntitities
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Books> Books { get; set; }
    }
}
