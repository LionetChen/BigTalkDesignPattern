namespace AdapterPattern
{
    public class ShootingGuard : PlayerBase
    {
        public ShootingGuard(string name) : base(name)
        {
            _name = name;
        }

        public override string Defense()
        {
            return $"{_name} to defense as shooting guard";
        }

        public override string Attack()
        {
            return $"{_name} to attack as shooting guard";
        }
    }
}