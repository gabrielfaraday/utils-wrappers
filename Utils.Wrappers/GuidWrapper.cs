using System;

namespace Utils.Wrappers
{
    public class GuidWrapper
    {
        public virtual string NewGuid()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}