namespace SimpleFactoryPattern;
public class OperationFactory
{
    public static Operation CreateOperation(string @operator)
    {
        Operation oper;
        switch (@operator)
        {
            case "+":
                oper = new AddOperation();
                break;
            default:
                throw new Exception($"Invlid operator {@operator}");
                
        }
        return oper;
    }
}
