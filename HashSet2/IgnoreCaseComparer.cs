using System.Collections.Generic;

namespace HashSet2
{
    public class IgnoreCaseComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y) //equals - jednako
        {
            return x.ToUpper().Equals(y.ToUpper());
        }

        public int GetHashCode(string obj)
        {
            return obj.ToUpper().GetHashCode();
        }
    }
}