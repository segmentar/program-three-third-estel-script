using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] ProgramEscapeJoinContainerSurface(String[] stringArray, Char character_ESCAPE)
        {
            String[] arrayResult = default;

            var list = ProgramEscapeJoinSet(stringArray, character_ESCAPE);

            String[] array;

            array = new String[list.Count];

            list.CopyTo(array, 0);

            arrayResult = array;

            return arrayResult;
        }
    }
}
