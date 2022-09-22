using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern;
public class GameRoleMemento : IMementoMeta
{
    public GameRoleMemento(string tag, int hitPoitns, int manaPoints, int damage)
    {
        HitPoitns = hitPoitns;
        ManaPoints = manaPoints;
        Damage = damage;
        Tag = tag;
        CreateTime = DateTime.Now;
    }

    public int HitPoitns { get; set; }
    public int ManaPoints { get; set; }
    public int Damage { get; set; }

    public string Tag { get; set; }

    public DateTime CreateTime { get; set; }
}
