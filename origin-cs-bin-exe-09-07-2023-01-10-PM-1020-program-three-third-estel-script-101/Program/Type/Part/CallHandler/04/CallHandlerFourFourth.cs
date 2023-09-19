using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void CallHandlerFourFourth(String[] split, String call, String escape, String terminator, String shared, String native, Char character_ESCAPE, Char character_TERMINATOR, Char character_SHARED, Tuple<String, String>[] tupleArray, String[] array_PORTAL)
        {
            var whitespace = Convert.ToChar(32);

            var join = String.Join(whitespace.ToString(), array_PORTAL);

            var result = join.Split();

            var array = ProgramEscapeJoinContainerSurface(result, character_ESCAPE);

            CallHandlerFiveFifth(split, call, escape, terminator, shared, native, character_ESCAPE, character_TERMINATOR, character_SHARED, tupleArray, array_PORTAL, array);

            return;
        }
    }
}
