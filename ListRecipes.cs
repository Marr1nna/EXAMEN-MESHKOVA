using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_MESHKOVA
{
    internal class ListRecipes
    {
        internal List<Recipes> Recipes
        {
            get;
            private set;
        }
        internal List<Ingredients> PotatoOfFrance
        {
            get;
            private set;
        }
        internal List<Ingredients> Ratatuy
        {
            get;
            private set;
        }
        public void Initialize()
        {
            PotatoOfFrance = new List<Ingredients>
            {
                new Ingredients("Картошка","Хорошая картошка",Kinds.Vegetables),
                new Ingredients("Мясо","Хорошее мясо",Kinds.Meat)
            };
            Ratatuy = new List<Ingredients>
            {
                new Ingredients("Морковка","Хорошая морковка",Kinds.Vegetables),
                new Ingredients("Баклажан","Хорошый баклажан",Kinds.Vegetables),
                new Ingredients("Помидор","Хорошый помидор",Kinds.Vegetables),
            };
            Recipes = new List<Recipes>
            {
                new Recipes("Картошка по французски", 120, PotatoOfFrance),
                new Recipes("Рататуй", 220,Ratatuy)
            };
        }
    }
}
