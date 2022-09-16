namespace BuilderPattern;

public abstract class StirFryRecipe
{
    protected Product _product = new Product();

    public abstract void PutMaterialA();
    public abstract void PutMaterialB();
    public abstract void PutIngredient();

    public Product GetResult(){
        return _product;
    }
}
