using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String ForgeWorkingDirectoryName()
        {
            String stringResult = default;

            var path_NAME__DIRECTORY = $"{Immutable.ProgramName}-{Immutable.WorkingDirectoryName}-{Immutable.WorkingDirectoryIdentity}";

            var lower = path_NAME__DIRECTORY.ToLower();

            var result = lower;

            stringResult = result;

            return stringResult;
        }
    }
}
