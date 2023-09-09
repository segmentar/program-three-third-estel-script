using Core;

namespace Core
{
    using System;

    internal static class ArchitecturePageOneFirst
    {
        internal static ConsoleColor BackgroundColor;

        internal static ConsoleColor ForegroundColor;

        internal static String PathToProgramOneFirst;

        internal static String PathToProgramTwoSecond;

        internal static String OutputPathProgramOneFirst;

        internal static String OutputPathProgramTwoSecond;

        static ArchitecturePageOneFirst()
        {
            BackgroundColor = ProgramDefaultPageOneFirst.BackgroundColor;

            ForegroundColor = ProgramDefaultPageOneFirst.ForegroundColor;

            PathToProgramOneFirst = ProgramDefaultPageOneFirst.PathToProgramOneFirstDefault;

            PathToProgramTwoSecond = ProgramDefaultPageOneFirst.PathToProgramTwoSecondDefault;

            OutputPathProgramOneFirst = ProgramDefaultPageOneFirst.OutputPathProgramOneFirstDefault;

            OutputPathProgramTwoSecond = ProgramDefaultPageOneFirst.OutputPathProgramTwoSecondDefault;

            return;
        }
    }
}
