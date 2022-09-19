namespace AdapterPattern
{
    /// <summary>
    /// A player who understands English and needs to be named using an constructor
    /// </summary>
    public abstract class PlayerBase
    {
        protected string _name;

        public PlayerBase(string name)
        {
            _name = name;
        }

        public abstract string Defense();
        public abstract string Attack();
    }
}