using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void CallHandlerTwoSecond(String[] split, String call, String escape, String terminator, String shared, String native, Char character_ESCAPE, Char character_TERMINATOR, Char character_SHARED)
        {
            var array = ProgramEscapeTupleContainerSurface<Tuple<String, String>>(split);

            CallHandlerThreeThird(split, call, escape, terminator, shared, native, character_ESCAPE, character_TERMINATOR, character_SHARED, array);

            return;
        }
    }
}
