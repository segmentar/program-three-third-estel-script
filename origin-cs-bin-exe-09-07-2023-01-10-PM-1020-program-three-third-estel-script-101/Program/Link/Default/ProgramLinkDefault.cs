using Core;

namespace Core
{
    using System;

    using System.Text;

    internal static class ProgramArchitectureDefaultPageOneFirst
    {
        internal static String FilesystemNotationDirectoryOriginDefault;

        internal static String FilesystemNotationDirectoryBackDefault;

        internal static String PathToProgramOneFirstDefault;

        internal static String PathToProgramTwoSecondDefault;

        internal static String InputPathProgramOneFirstDefault;

        internal static String InputPathProgramTwoSecondDefault;

        internal static String OutputPathProgramOneFirstDefault;

        internal static String OutputPathProgramTwoSecondDefault;

        internal static StringBuilder AutoCommandStringBuilderDefault;

        static ProgramArchitectureDefaultPageOneFirst()
        {
            FilesystemNotationDirectoryOriginDefault = "...";

            FilesystemNotationDirectoryBackDefault = "..";

            PathToProgramOneFirstDefault = default(String);

            PathToProgramTwoSecondDefault = default(String);

            InputPathProgramOneFirstDefault = default(String);

            InputPathProgramTwoSecondDefault = default(String);

            OutputPathProgramOneFirstDefault = default(String);

            OutputPathProgramTwoSecondDefault = default(String);

            AutoCommandStringBuilderDefault = new StringBuilder('\t' + "Auto Command" + ':' + '\n');

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal static class ProgramImmutableDefaultPageOneFirst
    {
        internal static String TitleDefault;

        internal static ConsoleColor BackgroundColorDefault;

        internal static ConsoleColor ForegroundColorDefault;

        internal static String ProgramNameDefault;

        internal static String SettingNameDefault;

        internal static String SettingExtensionDefault;

        internal static String WorkingDirectoryNameDefault;

        internal static String WorkingDirectoryIdentityDefault;

        static ProgramImmutableDefaultPageOneFirst()
        {
            TitleDefault = Assembly.GetEntryAssembly().GetName().Name;

            BackgroundColorDefault = ConsoleColor.Blue;

            ForegroundColorDefault = ConsoleColor.Yellow;

            ProgramNameDefault = Assembly.GetEntryAssembly().GetName().Name;

            SettingNameDefault = "Setting";

            SettingExtensionDefault = "txt";

            WorkingDirectoryNameDefault = "Working Directory";

            WorkingDirectoryIdentityDefault = Path.GetRandomFileName();

            return;
        }
    }
}