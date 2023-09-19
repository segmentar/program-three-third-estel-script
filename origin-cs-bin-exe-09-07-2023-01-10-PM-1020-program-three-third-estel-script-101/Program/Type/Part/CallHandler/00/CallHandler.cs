using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void CallHandler(String[] split)
        {
            var boolean_safe__EQUAL_OR_MORE_THAN = (split.Length >= 6);

            Boolean shouldReturn, isLengthCheck;

            isLengthCheck = boolean_safe__EQUAL_OR_MORE_THAN is true;

            shouldReturn = isLengthCheck is false;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            var first = split[0];

            var second = split[1];

            var third = split[2];

            var fourth = split[3];

            var fifth = split[4];

            String call, escape, terminator, shared, native;

            call = first;

            escape = second;

            terminator = third;

            shared = fourth;

            native = fifth;

            CallHandlerOneFirst(split, call, escape, terminator, shared, native);

            return;
        }
    }
}
