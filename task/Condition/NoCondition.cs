namespace task
{
    public class NoCondition : IConditon
    {
        public bool _validate(bool nA, bool nB)
        {
            return (!nB);
        }

        public string _getName()
        {
            return @"no";
        }
    }
}
