using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_MESHKOVA
{
    internal class Recipes
    {
        private string _name;
        private uint _price;
        private List<Ingredients> _ingredients = new List<Ingredients> ();
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public uint Price
        {
            get { return _price; }
            private set { _price = value; }
        }
        public List<Ingredients> Ingredients
        {
            get { return _ingredients; }
            private set { _ingredients = value; }
        }
        public Recipes(string name, uint price, List<Ingredients> ingredients)
        {
            Name = name;
            Price = price;
            Ingredients = ingredients;
        }
    }
}
