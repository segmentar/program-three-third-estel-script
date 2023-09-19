using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String ForgeWorkingDirectoryName()
        {
            String stringResult = default;

            var path_NAME__DIRECTORY = $"{ImmutablePageOneFirst.ProgramName}-{ImmutablePageOneFirst.WorkingDirectoryName}-{ImmutablePageOneFirst.WorkingDirectoryIdentity}";

            var lower = path_NAME__DIRECTORY.ToLower();

            var result = lower;

            stringResult = result;

            return stringResult;
        }
    }
}
