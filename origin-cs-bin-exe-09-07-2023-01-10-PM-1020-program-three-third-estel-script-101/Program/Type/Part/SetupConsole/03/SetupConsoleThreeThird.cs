using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void SetupConsoleTreeThird(String lower, String[] split, Boolean hasLength)
        {
            var length_TWO_least = (split.Length >= 3) is true;

            if (length_TWO_least is true)
            {
                var first = split[0];

                var second = split[1];

                var third = split[2];

                String call, escape, file;

                call = first;

                escape = second;

                file = third;

                var boolean_CALL_is = true;

                boolean_CALL_is = boolean_CALL_is && (call == "call") is true;

                boolean_CALL_is = boolean_CALL_is && (escape.Length == 1) is true;

                Boolean isCall;

                isCall = boolean_CALL_is is true;

                if (isCall is true)
                {
                    Char character;

                    character = escape[0];

                    String[] stringArray;

                    stringArray = ProgramArgumentEscapeContainerSurface<String>(character, file);

                    Console.Clear();

                    Console.Out.WriteLine($"[{file} {String.Join(' '.ToString(), stringArray)}]");

                    Console.In.ReadLine();
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            return;
        }
    }
}
