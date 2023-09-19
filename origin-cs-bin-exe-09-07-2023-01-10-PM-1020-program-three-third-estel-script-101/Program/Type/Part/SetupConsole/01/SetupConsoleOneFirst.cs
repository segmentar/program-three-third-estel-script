using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private void SetupConsoleOneFirst()
        {
            Console.Title = ImmutablePageOneFirst.ProgramName;

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleReposition(true, true, true);

            return;
        }
    }
}
