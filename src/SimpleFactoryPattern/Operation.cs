using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public abstract class Operation
    {
        public decimal OperandA { get; set; }
        public decimal OperandB { get; set; }

        public abstract decimal GetResult();
    }
}