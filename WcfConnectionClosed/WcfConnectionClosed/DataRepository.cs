using System.Collections.Generic;

namespace WcfConnectionClosed
{
    public class DataRepository
    {
        public IEnumerable<int> GetDeferredData()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
    }
}