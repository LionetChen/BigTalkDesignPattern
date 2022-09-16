namespace BuilderPattern;
public class Chef
{
    public void StirFry(StirFryRecipe recipe)
    {
        recipe.PutMaterialA();
        recipe.PutMaterialB();
        recipe.PutIngredient();
    }
}
