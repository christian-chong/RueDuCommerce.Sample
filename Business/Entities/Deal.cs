using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Deal
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Reference { get; set; }

        protected bool Equals(Deal other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Deal) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
