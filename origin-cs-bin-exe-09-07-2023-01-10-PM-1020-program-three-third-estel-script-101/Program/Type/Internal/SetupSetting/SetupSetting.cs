using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal void SetupSetting()
        {
            var path_FILE_filename = Path.Combine(Directory.GetCurrentDirectory(), "Setting");

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "txt");

            if (File.Exists(path_FILE_filename_with_extension) is false)
            {
                return;
            }
            else
                "false".ToString();

            var text = File.ReadAllText(path_FILE_filename_with_extension);

            foreach (Tuple<String, String> tuple in DictionaryFromText(text))
            {
                String stringItem;

                stringItem = tuple.Item2;

                switch (tuple.Item1)
                {
                    case nameof(ArchitecturePageOneFirst.PathToProgramOneFirst):
                        ArchitecturePageOneFirst.PathToProgramOneFirst = stringItem;
                        break;

                    case nameof(ArchitecturePageOneFirst.PathToProgramTwoSecond):
                        ArchitecturePageOneFirst.PathToProgramTwoSecond = stringItem;
                        break;

                    case nameof(ArchitecturePageOneFirst.OutputPathProgramOneFirst):
                        ArchitecturePageOneFirst.OutputPathProgramOneFirst = stringItem;
                        break;

                    case nameof(ArchitecturePageOneFirst.OutputPathProgramTwoSecond):
                        ArchitecturePageOneFirst.OutputPathProgramTwoSecond = stringItem;
                        break;

                    default:
                        break;
                }

                continue;
            }
            
            return;
        }
    }
}
