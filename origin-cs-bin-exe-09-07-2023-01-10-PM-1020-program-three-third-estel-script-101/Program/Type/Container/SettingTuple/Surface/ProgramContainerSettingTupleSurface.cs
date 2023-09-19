using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramSettingTupleContainerSurface<T>(String text, Char character_LEFT, Char character_RIGHT)
        {
            T[] arrayResult = default;

            var list = ProgramSettingTupleContainer(text, character_LEFT, character_RIGHT);

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
