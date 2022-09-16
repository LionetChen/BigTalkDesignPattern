namespace BuilderPattern;

public class FryNoodlesWtihBeef : StirFryRecipe
{
    public override void PutIngredient()
    {
        _product.Add("Soy sauce");
    }

    public override void PutMaterialA()
    {
        _product.Add("Noodles");
    }

    public override void PutMaterialB()
    {
        _product.Add("Beef");
    }
}
