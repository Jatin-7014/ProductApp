using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    internal class Product
    {
        int _id;
        string _name;
        int _price;
        int _discount;
        public int GetId() { return _id; }

        public int GetPrice() { return _price; }

        public int GetDiscount() { return _discount; }

        public string GetName() { return _name; }
        
        public void SetId(int id)
        {
            _id = id;
        }

        public void SetPrice(int price)
        {
            _price = price;
        }

        public void SetDiscount(int discount) 
        { 
            _discount = discount; 
        }

        public void SetName(string name)
        {
            _name = name;
        }
        public int SellingPrice()
        {
            int discount = _price - (_price * _discount / 100);
            return discount;
        }

    }
}
