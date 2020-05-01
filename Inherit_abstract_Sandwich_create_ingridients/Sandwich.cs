using System.Collections.Generic;

namespace Inherit_abstract_Sandwich_create_ingridients
{
    abstract class Sandwich
    {
        public Sandwich()
        {
            CreateIngredients();
        }

        public abstract void CreateIngredients();

        public List<Ingredient> Ingredients { get; } = new List<Ingredient>();
    }
}
