using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void CallHandlerOneFirst(String[] split, String call, String escape, String terminator, String shared, String native)
        {
            var boolean_safe_CALL_is = true;

            boolean_safe_CALL_is = boolean_safe_CALL_is && (call == "call") is true;

            boolean_safe_CALL_is = boolean_safe_CALL_is && (escape.Length == 1) is true;

            boolean_safe_CALL_is = boolean_safe_CALL_is && (terminator.Length == 1) is true;

            boolean_safe_CALL_is = boolean_safe_CALL_is && (shared.Length == 1) is true;

            boolean_safe_CALL_is = boolean_safe_CALL_is && (native.Length == 2) is true;

            Boolean isCallCheck, shouldReturn;

            isCallCheck = boolean_safe_CALL_is is true;

            shouldReturn = isCallCheck is false;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            var character_ESCAPE = escape[0];

            var character_TERMINATOR = terminator[0];

            var character_SHARED = shared[0];

            CallHandlerTwoSecond(split, call, escape, terminator, shared, native, character_ESCAPE, character_TERMINATOR, character_SHARED);

            return;
        }
    }
}
