using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// A translator who takes a name from constructor
    /// and can translate English instructions into Chinese
    /// </summary>
    public class TranslatorForForeignCenter : PlayerBase
    {
        private ForeignCenter _foreignCenter = new ForeignCenter();

        public TranslatorForForeignCenter(string name) : base(name)
        {
            _foreignCenter.姓名 = name;
        }

        public override string Attack()
        {
            return _foreignCenter.进攻();
        }

        public override string Defense()
        {
            return _foreignCenter.防守();
        }
    }
}
