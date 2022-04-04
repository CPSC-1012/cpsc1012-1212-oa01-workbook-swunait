using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailItemProgram
{
    public class RetailItem
    {
        private string _description;
        private int _unitsOnHand;
        private decimal _price;

        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Description is required.");
                }
                _description = value;
            }
        }
        public int UnitsOnHand
        {
            get => _unitsOnHand;
            set
            {
                if (value < 0)
                {
                    throw new Exception($"Units on hand must be greater than or equal to 0.");
                }
                _unitsOnHand = value;
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception($"Price must be greater than or equal to 0.");
                }
                _price = value;
            }

        }

        public RetailItem()
        {

        }
        //public RetailItem(string desription)
        //{
        //    Description = desription;
        //    UnitsOnHand = 0;
        //    Price = 9999.99m;
        //}
        public RetailItem(string description, int unitsOnHand, decimal price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Description,-45} {UnitsOnHand,5} {Price,10:C} {TotalValue(), 15:C}";
        }

        public decimal TotalValue()
        {
            return UnitsOnHand * Price;
        }
    }
}