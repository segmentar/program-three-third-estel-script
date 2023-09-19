using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] ProgramEscapePortalSetSurface(String[] stringArray, Tuple<String, String>[] tupleArray, Char character_ESCAPE, Char character_TERMINATOR)
        {
            String[] arrayResult = default;

            var list = ProgramEscapePortalSet(stringArray, tupleArray, character_ESCAPE, character_TERMINATOR);

            String[] array;

            array = new String[list.Count];

            list.CopyTo(array, 0);

            arrayResult = array;

            return arrayResult;
        }
    }
}
