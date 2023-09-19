using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void DuplexHandler(String[] split)
        {
            var boolean_safe__EQUAL_OR_MORE_THAN = (split.Length >= 2);

            Boolean shouldReturn;

            shouldReturn = boolean_safe__EQUAL_OR_MORE_THAN is false;

            if (boolean_safe__EQUAL_OR_MORE_THAN is false)
            {
                return;
            }
            else
                "false".ToString();

            var first = split[0];

            var second = split[1];

            String name, value;

            name = first;

            value = second;

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
                    break;
            }

            return;
        }
    }
}
