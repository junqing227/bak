using System;
namespace UIDLL
{
    public class BusinessCls
    {
        public BusinessCls()
        {
        }

        public static long Cal(long a, long b)
        {
            return a + b;
        }

        public static long Cal(string a,string b)
        {
            return Cal(Convert.ToInt64(a), Convert.ToInt64(b));
        }

    }
}
