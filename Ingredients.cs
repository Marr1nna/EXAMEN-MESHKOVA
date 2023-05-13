using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_MESHKOVA
{
    public enum Kinds
    {
        Fruits, 
        Vegetables, 
        Meat, 
        Seafood
    }
    internal class Ingredients
    {
        private string _name;
        private string _description;
        private Kinds _kind = Kinds.Fruits;
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            private set { _description = value; }
        }
        public Kinds Kind
        {
            get { return _kind; }
            private set { _kind = value; }
        }
        public Ingredients(string name, string description, Kinds kind)
        {
            Name = name;
            Description = description;
            Kind = kind;
        }
    }
}
