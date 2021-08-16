using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooty
{
    public class ScooterService: IScooterService
    {
        protected List<Scooter> _scooterList = new List<Scooter>();

        public void AddScooter(string id, decimal pricePerMinute)
        {
            _scooterList.Add(new Scooter(id, pricePerMinute));
        }

        public void RemoveScooter(string id)
        {
            _scooterList.Remove(_scooterList.Find(x => x.Id == id && x.IsRented == false));
        }

        public IList<Scooter> GetScooters()
        {
            return _scooterList;
        }

        public Scooter GetScooterById(string id)
        {
            return _scooterList.Find(x => x.Id == id);
        }
    }
}
