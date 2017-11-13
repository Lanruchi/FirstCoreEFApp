using System;

namespace App.Core.DomainEntitity
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IpAddress { get; set; }
        public bool ActiveStatus { get; set; }
    }
}
