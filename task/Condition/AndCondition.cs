namespace task
{
    public class AndCondition : IConditon
    {
        public bool _validate(bool nA, bool nB)
        {
            return (nA && nB);
        }

        public string _getName()
        {
            return @"and";
        }
    }
}
