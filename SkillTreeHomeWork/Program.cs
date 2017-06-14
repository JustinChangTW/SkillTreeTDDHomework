using SkillTreeHomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTreeHomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
        }


    }

    public class Shop
    {
        private ISummary<Product> _product;

        public Shop(ISummary<Product> product)
        {
            this._product = product;
        }
        public List<int> Calculate(string Field, int Number,List<Product> data)
        {
            var product = _product;
            //var data = product.GetProduct();

            CheckException(Field, Number, data);

            var result = product.CalculateGroupResult(Field, Number, data);
            return result;
        }

        private void CheckException(string Field, int Number, List<Product> data)
        {
            if (data.Count <= Number ) {

                throw new ArgumentException();
            }
            if (Number == 0)
            {
                throw new ArgumentException();
            }
            if (!CheckExist<Product>(Field)) throw new ArgumentException();
        }

        private bool CheckExist<T>(string Field)
        {
            var t = typeof(T).GetProperties();

            return t.Any(e => e.Name == Field);
        }
    }

    public class Summary:ISummary<Product>
    {
        public List<int> CalculateGroupResult(string Field, int Number, List<Product> product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProduct()
        {
            throw new NotImplementedException();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
        
}
