using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private void SetupConsoleTwoSecond()
        {
            do
            {
                Console.Clear();

                Console.Out.WriteLine(ConsoleDescriptor());

                ConsoleReposition(false, false, false);

                var line = Console.In.ReadLine();

                var lower = line.ToLower();

                var split = line.Split();

                Boolean hasLength;

                hasLength = (split.Length > 0) is true;

                SetupConsoleTreeThird(lower, split, hasLength);

                Boolean isEscape;

                isEscape = (lower == "escape") is true;

                if (isEscape)
                {
                    ConsoleReposition(true, true, true);

                    break;
                }
                else
                    "false".ToString();

                continue;

            } while (true);

            return;
        }
    }
}
