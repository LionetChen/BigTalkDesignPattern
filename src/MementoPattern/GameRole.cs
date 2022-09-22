namespace MementoPattern;
public class GameRole
{
    public GameRole(string roleType, string name, int hitPoitns, int manaPoints, int damage)
    {
        RoleType = roleType;
        Name = name;
        HitPoitns = hitPoitns;
        ManaPoints = manaPoints;
        Damage = damage;
    }

    public string RoleType { get; set; }
    public string Name { get; set; }
    public int HitPoitns {get;set; }
    public int ManaPoints { get; set; }
    public int Damage { get; set; }

    public IMementoMeta TakeSnapshot(string tag)
    {
        return new GameRoleMemento(tag, HitPoitns, ManaPoints, Damage);
    }

    public void RestoreSnapshot(IMementoMeta memo)
    {
        GameRoleMemento concreteMemo = (GameRoleMemento)memo;
        HitPoitns = concreteMemo.HitPoitns;
        ManaPoints = concreteMemo.ManaPoints;
        Damage = concreteMemo.Damage;
    }
}
