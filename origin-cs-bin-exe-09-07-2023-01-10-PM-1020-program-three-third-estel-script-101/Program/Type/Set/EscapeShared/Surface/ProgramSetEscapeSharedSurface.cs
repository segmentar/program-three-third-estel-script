using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    internal partial class Program
    {
        internal static String[] ProgramEscapeSharedSetSurface(String[] stringArray, String native, Char character_TERMINATOR, Char character_SHARED)
        {
            String[] arrayResult = default;

            var list = ProgramEscapeSharedSet(stringArray, native, character_TERMINATOR, character_SHARED);

            String[] array;

            array = new String[list.Count];

            list.CopyTo(array, 0);

            arrayResult = array;

            return arrayResult;
        }
    }
}
