using Core;

namespace Core
{
    using System;

    internal static class Immutable
    {
        internal static String ProgramName;

        internal static String WorkingDirectoryName;

        internal static String WorkingDirectoryIdentity;

        static Immutable()
        {
            ProgramName = ProgramDefaultPageOneFirst.ProgramNameDefault;

            WorkingDirectoryName = ProgramDefaultPageOneFirst.WorkingDirectoryNameDefault;

            WorkingDirectoryIdentity = ProgramDefaultPageOneFirst.WorkingDirectoryIdentityDefault;

            return;
        }
    }
}
