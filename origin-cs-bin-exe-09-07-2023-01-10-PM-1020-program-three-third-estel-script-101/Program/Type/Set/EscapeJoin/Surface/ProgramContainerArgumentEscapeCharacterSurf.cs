using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramArgumentEscapeCharacterContainerSurface<T>(Char character, String[] stringArray, Tuple<String, String>[] tupleArray)
        {
            T[] arrayResult = default;

            var list = ProgramArgumentEscapeCharacterContainer(character, stringArray, tupleArray);

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            T[] array;

            array = reflect;

            arrayResult = array;

            return arrayResult;
        }
    }
}
