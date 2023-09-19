using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void CallHandlerThreeThird(String[] split, String call, String escape, String terminator, String shared, String native, Char character_ESCAPE, Char character_TERMINATOR, Char character_SHARED, Tuple<String, String>[] tupleArray)
        {
            var array = ProgramEscapePortalSetSurface(split, tupleArray, character_ESCAPE, character_TERMINATOR);

            CallHandlerFourFourth(split, call, escape, terminator, shared, native, character_ESCAPE, character_TERMINATOR, character_SHARED, tupleArray, array);

            return;
        }
    }
}
