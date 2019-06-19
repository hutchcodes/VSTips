using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TestValues
{
    public static class RandomValues
    {
        private static readonly Dictionary<Type, Func<string, object>> @switch;
        private static Random _rand = new Random();

        static RandomValues()
        {
            @switch = new Dictionary<Type, Func<string, object>> {
                { typeof(int), (seed) => { return GetStandardInt(seed); } },
                { typeof(int?), (seed) => { return GetStandardInt(seed); } },
                { typeof(string), (seed) => { return GetStandardString(seed); } },
                { typeof(DateTime), (seed) => { return GetStandardDateTime(seed); } },
                { typeof(DateTime?), (seed) => { return GetStandardDateTime(seed); } },
            };
        }
        public static T Get<T>(Expression<Func<T>> property, string additionalValue = "")
        {
            var memberExpression = property.Body as MemberExpression;
            var propertyName = memberExpression.Member.Name;

            return Get<T>(propertyName, additionalValue);
        }

        public static T Get<T>(string propertyName, string additionalValue = "")
        {
            var seed = propertyName + additionalValue;

            if (!@switch.ContainsKey(typeof(T)))
            {
                throw new ArgumentException($"The type of {typeof(T).Name} is not supported");
            }

            return (T)@switch[typeof(T)](seed);
        }

        private static int GetStandardInt(string seed)
        {
            return _rand.Next();
        }
        private static string GetStandardString(string seed)
        {
            return $"Test_{_rand.Next()}";
        }

        private static DateTime GetStandardDateTime(string seed)
        {
            var testValue = new DateTime((long)Math.Abs(seed.GetHashCode()) * 1000000000);
            return testValue;
        }
    }
}
