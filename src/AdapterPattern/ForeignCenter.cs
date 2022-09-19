using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// A foreign player who understands only Chinese,
    /// also needs to be assigned a name outside of constructor
    /// </summary>
    public class ForeignCenter
    {
        public string 姓名 { get; set; } = null!;

        public string 进攻()
        {
            return $"{姓名} to attack as center";
        }

        public string 防守()
        {
            return $"{姓名} to defense as center";
        }
    }
}
