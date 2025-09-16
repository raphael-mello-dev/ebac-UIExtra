using NUnit.Framework;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Random = UnityEngine.Random;

namespace Utils
{
    public static class ExtraUtils
    {
        public static string HelloWorld()
        {
            return "Hello World";
        }

        public static T GetRandom<T>(this T[] array)
        {
            if (array.Length == 0)
                return default(T);

            return array[Random.Range(0, array.Length)];
        }

        public static T GetRandom<T>(this List<T> list)
        {
            if (list.Count == 0)
                return default(T);

            return list[Random.Range(0, list.Count)];
        }
    }
}