namespace BuilderPattern;

public class FryTomatoWithEggs : StirFryRecipe
{
    public override void PutIngredient()
    {
        _product.Add("Salt");
    }

    public override void PutMaterialA()
    {
        _product.Add("Tomato");
    }

    public override void PutMaterialB()
    {
        _product.Add("Eggs");
    }
}
