using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static T[] ProgramArgumentEscapeContainerSurface<T>(Char escapeCharacter, String file)
        {
            T[] arrayResult = default;

            var list = ProgramArgumentEscapeContainer(escapeCharacter, file);

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            arrayResult = reflect;

            return arrayResult;
        }
    }
}
