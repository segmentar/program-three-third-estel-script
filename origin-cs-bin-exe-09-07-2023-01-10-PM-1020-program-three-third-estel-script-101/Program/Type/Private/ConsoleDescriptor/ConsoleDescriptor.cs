using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String ConsoleDescriptor()
        {
            String stringResult = default;

            var join = String.Join('\n'.ToString(), new String[] {
            
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + $"This is `{Immutable.ProgramName}`" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + $"(call) ([escape]) ([file]) <argument><<32>> {{^}}{{{{}}}}",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageOneFirst.PathToProgramOneFirst) + ':' + ' ' + ArchitecturePageOneFirst.PathToProgramOneFirst,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageOneFirst.PathToProgramTwoSecond) + ':' + ' ' + ArchitecturePageOneFirst.PathToProgramTwoSecond,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageOneFirst.OutputPathProgramOneFirst) + ':' + ' ' + ArchitecturePageOneFirst.OutputPathProgramOneFirst,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageOneFirst.OutputPathProgramTwoSecond) + ':' + ' ' + ArchitecturePageOneFirst.OutputPathProgramTwoSecond,
                String.Empty,
                String.Empty + '\t' + "Prompt" + ':' + ' ',
                String.Empty
            });

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
