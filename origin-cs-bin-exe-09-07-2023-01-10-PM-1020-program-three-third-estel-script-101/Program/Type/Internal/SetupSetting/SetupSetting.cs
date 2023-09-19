using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal void SetupSetting()
        {
            var path_FILE_filename = Path.Combine(Directory.GetCurrentDirectory(), ImmutablePageOneFirst.SettingName);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, ImmutablePageOneFirst.SettingExtension);

            if (File.Exists(path_FILE_filename_with_extension) is false)
            {
                return;
            }
            else
                "false".ToString();

            var text = File.ReadAllText(path_FILE_filename_with_extension);

            var boolean_safe__MORE_OR_EQUAL_THAN = (text.Length >= 2);

            Boolean isLengthCheck, shouldReturn;

            isLengthCheck = boolean_safe__MORE_OR_EQUAL_THAN is true;

            shouldReturn = isLengthCheck is false;

            if (shouldReturn is true)
            {
                return;
            }
            else
                "false".ToString();

            var first = text[0];

            var second = text[1];

            Char left, right;

            left = first;

            right = second;

            foreach (Tuple<String, String> tuple in ProgramSettingTupleContainerSurface<Tuple<String, String>>(text, left, right))
            {
                String name, value;

                name = tuple.Item1;

                value = tuple.Item2;

                switch (name)
                {
                    case nameof(ArchitecturePageOneFirst.PathProgramOneFirst):
                        ArchitecturePageOneFirst.PathProgramOneFirst = value;
                        break;

                    case nameof(ArchitecturePageOneFirst.PathProgramTwoSecond):
                        ArchitecturePageOneFirst.PathProgramTwoSecond = value;
                        break;

                    case nameof(ArchitecturePageOneFirst.InputPathProgramOneFirst):
                        ArchitecturePageOneFirst.InputPathProgramOneFirst = value;
                        break;

                    case nameof(ArchitecturePageOneFirst.InputPathProgramTwoSecond):
                        ArchitecturePageOneFirst.InputPathProgramTwoSecond = value;
                        break;

                    case nameof(ArchitecturePageOneFirst.OutputPathProgramOneFirst):
                        ArchitecturePageOneFirst.OutputPathProgramOneFirst = value;
                        break;

                    case nameof(ArchitecturePageOneFirst.OutputPathProgramTwoSecond):
                        ArchitecturePageOneFirst.OutputPathProgramTwoSecond = value;
                        break;

                    default:
                        ArchitecturePageOneFirst.AutoCommandStringBuilder.Insert(ArchitecturePageOneFirst.AutoCommandStringBuilder.Length, '\t' + value + '\n');
                        break;
                }

                continue;
            }
            
            return;
        }
    }
}
