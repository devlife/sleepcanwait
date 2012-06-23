using System;
using System.Linq;
using System.Reflection;

namespace GetAttribute
{
    public static class MemberInfoExtensions
    {
        public static TAttribute GetAttribute<TAttribute>(this MemberInfo member, bool inherited = false, bool throwIfMissing = false) 
            where TAttribute : Attribute
        {
            TAttribute attr = member.GetCustomAttributes(typeof(TAttribute), inherited).OfType<TAttribute>().SingleOrDefault();

            if (throwIfMissing && attr == null)
                throw new ApplicationException(string.Format("Could not find Attribute of type {0} on {1}", typeof(TAttribute).FullName, member.Name));

            return attr;
        }
    }
}
