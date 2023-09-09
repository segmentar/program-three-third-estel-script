using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal partial class ProgramDefaultPageOneFirst
    {
        internal static ConsoleColor BackgroundColor;

        internal static ConsoleColor ForegroundColor;

        internal static String PathToProgramOneFirstDefault;

        internal static String PathToProgramTwoSecondDefault;

        internal static String OutputPathProgramOneFirstDefault;

        internal static String OutputPathProgramTwoSecondDefault;

        internal static String ProgramNameDefault;

        internal static String WorkingDirectoryNameDefault;

        internal static String WorkingDirectoryIdentityDefault;

        static ProgramDefaultPageOneFirst()
        {
            BackgroundColor = ConsoleColor.Blue;

            ForegroundColor = ConsoleColor.Yellow;

            PathToProgramOneFirstDefault = String.Empty;

            PathToProgramTwoSecondDefault = String.Empty;

            OutputPathProgramOneFirstDefault = String.Empty;

            OutputPathProgramTwoSecondDefault = String.Empty;

            ProgramNameDefault = Assembly.GetEntryAssembly().GetName().Name;

            WorkingDirectoryNameDefault = "Working Directory";

            WorkingDirectoryIdentityDefault = Path.GetRandomFileName();

            return;
        }
    }
}
