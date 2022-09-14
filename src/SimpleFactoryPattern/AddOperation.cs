namespace SimpleFactoryPattern
{
    internal class AddOperation : Operation
    {
        public override decimal GetResult()
        {
            return OperandA + OperandB;
        }
    }
}