using System.Collections.Generic;

namespace DynamicProgramming.GridTraveler
{
    public class MemoizedGridTraveler : GridTravelerBase
    {
        private Dictionary<string, long> _lookup;

        public MemoizedGridTraveler()
        {
            _lookup = new Dictionary<string, long>();
        }
        
        public override long GridTraveler(long w, long h)
        {
            long value = BaseCase(w, h);
            if (value > -1) return value;
            
            string key = string.Format("{0},{1}", w, h);
            
            if (_lookup.ContainsKey(key))
            {
                return _lookup[key];
            }
            
            _lookup[key] = value = GridTraveler(w - 1, h) + GridTraveler(w, h - 1);
            return value;
        }
    }
}
