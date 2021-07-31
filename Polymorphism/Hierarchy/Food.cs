using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    abstract class Food
    {
        public int quantity = 0;

        protected Food(int quantity)
        {
            this.quantity = quantity;
        }

        public abstract string GetFoodType();
    }
}
