using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static void Render(String path, params Object[] objectArray)
        {
            var path_DIRECTORY_full_name = Path.Combine(Directory.GetCurrentDirectory(), RenderFolderName(path));

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var path_NAME_directory = new DirectoryInfo(path_DIRECTORY_full_name).Name;

            var ordinal = 1;

            foreach (Object objectItem in objectArray)
            {
                String stringItem = objectItem.ToString();

                var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, RenderFileName(path_NAME_directory, ordinal, objectArray.Length));

                var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "txt");

                if (File.Exists(path_FILE_filename_with_extension) is false)
                {
                    StreamWriter streamWriter;

                    using (streamWriter = File.CreateText(path_FILE_filename_with_extension))
                    {
                        streamWriter.Write(stringItem);

                        streamWriter.Flush();

                        streamWriter.Close();

                        streamWriter.Dispose();
                    }
                }
                else
                    "false".ToString();

                ordinal = ordinal + 1;

                continue;
            }

            return;
        }
    }
}
