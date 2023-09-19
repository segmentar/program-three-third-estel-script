using Core;

namespace Core
{
    using System;

    internal static class ImmutablePageOneFirst
    {
        internal static String Title;

        internal static ConsoleColor BackgroundColor;

        internal static ConsoleColor ForegroundColor;

        internal static String ProgramName;

        internal static String SettingName;

        internal static String SettingExtension;

        internal static String WorkingDirectoryName;

        internal static String WorkingDirectoryIdentity;

        internal static String FilesystemNotationDirectoryOrigin;

        internal static String FilesystemNotationDirectoryBack;

        static ImmutablePageOneFirst()
        {
            Title = ProgramImmutableDefaultPageOneFirst.TitleDefault;
            
            BackgroundColor = ProgramImmutableDefaultPageOneFirst.BackgroundColorDefault;

            ForegroundColor = ProgramImmutableDefaultPageOneFirst.ForegroundColorDefault;

            ProgramName = ProgramImmutableDefaultPageOneFirst.ProgramNameDefault;

            SettingName = ProgramImmutableDefaultPageOneFirst.SettingNameDefault;

            SettingExtension = ProgramImmutableDefaultPageOneFirst.SettingExtensionDefault;

            WorkingDirectoryName = ProgramImmutableDefaultPageOneFirst.WorkingDirectoryNameDefault;

            WorkingDirectoryIdentity = ProgramImmutableDefaultPageOneFirst.WorkingDirectoryIdentityDefault;

            FilesystemNotationDirectoryOrigin = ProgramArchitectureDefaultPageOneFirst.FilesystemNotationDirectoryOriginDefault;

            FilesystemNotationDirectoryBack = ProgramArchitectureDefaultPageOneFirst.FilesystemNotationDirectoryBackDefault;

            return;
        }
    }
}
