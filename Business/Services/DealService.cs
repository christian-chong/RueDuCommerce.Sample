using System.Collections.Generic;
using System.Linq;
using Business.Entities;

namespace Business.Services
{
    public class DealService
    {
        private readonly IList<Deal> deals = new List<Deal>(); 

        public Deal Get(int id)
        {
            return (from g in deals where g.Id == id select g).FirstOrDefault();
        }

        public void Add(Deal deal)
        {
            deal.Id = deals.Count + 1;
            deals.Add(deal);
        }

        public void Remove(int id)
        {
            var deal = Get(id);
            if (deal != null) deals.Remove(deal);
        }

        public void Init()
        {
            deals.Add(new Deal { Id = 1, Amount = 123, Reference = "123-456-789" });
            deals.Add(new Deal { Id = 2, Amount = 456, Reference = "465-456-789" });
            deals.Add(new Deal { Id = 3, Amount = 789, Reference = "123-234-789" });
        }

        public object GetAll()
        {
            return deals;
        }
    }
}
