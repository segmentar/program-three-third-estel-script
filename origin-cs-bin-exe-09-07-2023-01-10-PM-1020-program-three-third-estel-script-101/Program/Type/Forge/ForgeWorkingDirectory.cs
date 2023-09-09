using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static String ForgeWorkingDirectory(String directory)
        {
            String stringResult = default;

            var path_DIRECTORY_full_name = Path.Combine(directory, ForgeWorkingDirectoryName());

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var result = path_DIRECTORY_full_name;

            stringResult = result;

            return stringResult;
        }
    }
}
