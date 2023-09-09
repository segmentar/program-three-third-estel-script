using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static String RenderFolderName(String path)
        {
            String stringResult = default;

            var path_NAME_directory = String.Empty;

            var dash = Convert.ToChar(45);

            var split = path.Split(new String[] { dash.ToString() }, StringSplitOptions.None);

            foreach (String stringItem in split)
            {
                path_NAME_directory = Path.Combine(path_NAME_directory, stringItem);

                continue;
            }

            var result = path_NAME_directory;

            stringResult = result;

            return stringResult;
        }
    }
}
