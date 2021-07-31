using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> campaign;

        public Campaign() 
        {
            campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a) 
        {
            campaign.Add(a);
        }

        public double GetCost()
        {
            return campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            string output = "";
            foreach (var item in campaign)
            {
                output += "\n" + item;
            }
            return "Advert Campaign" + output + "\nTotal Cost: "+ GetCost();
        }
    }
}