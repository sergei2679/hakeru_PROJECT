namespace Inherit_abstract_Sandwich_create_ingridients    // FactoryMethod
{
    //product abstract
    abstract class Ingredient
    {
        public Ingredient() { }
    }


    //concrete product
    class Bread : Ingredient { }

    //concrete product
    class Cheese : Ingredient { }

    //concrete product
    class Mayonnaise : Ingredient { }

    //concrete product
    class Turkey : Ingredient { }

    //concrete product
    class Lettuce : Ingredient { }
    //concrete product
    class Tuna : Ingredient { }

    //concrete product
    class Avocado : Ingredient { }

    //-----------------------------------------------------

    class TurkeySandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());


        }
    }
    class TunaSandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Tuna());
            Ingredients.Add(new Lettuce());


        }
    }
}
