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
                String.Empty + '\t' + $"This is `{ImmutablePageOneFirst.ProgramName}`" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + "Enter `escape` to run and exit" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + '\t' + $"(call) ([escape]) ([terminator]) ([shared]) ([native]) ([file]) [(argument)] [escape] [argument]",
                String.Empty,
                String.Empty + '\t' + '\t' + $"{{escape}}{{{{+::0}}}} {{terminator}}{{{{*::0}}}} {{shared}}{{{{-::0}}}} {{native}}{{{{/::0}}}} {{file}}{{{{...::..}}}} <argument><<+::32>>",
                String.Empty,
                String.Empty + '\t' + '\t' + $"(add-auto-command) (::) ([auto-command]) `Setting File`",
                String.Empty,
                String.Empty + '\t' + ",,,,,",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageOneFirst.PathProgramOneFirst) + ':' + ' ' + ArchitecturePageOneFirst.PathProgramOneFirst,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageOneFirst.PathProgramTwoSecond) + ':' + ' ' + ArchitecturePageOneFirst.PathProgramTwoSecond,
                String.Empty,
                String.Empty + '\t' + ",,,,,",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageOneFirst.InputPathProgramOneFirst) + ':' + ' ' + ArchitecturePageOneFirst.InputPathProgramOneFirst,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageOneFirst.InputPathProgramTwoSecond) + ':' + ' ' + ArchitecturePageOneFirst.InputPathProgramTwoSecond,
                String.Empty,
                String.Empty + '\t' + ",,,,,",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageOneFirst.OutputPathProgramOneFirst) + ':' + ' ' + ArchitecturePageOneFirst.OutputPathProgramOneFirst,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitecturePageOneFirst.OutputPathProgramTwoSecond) + ':' + ' ' + ArchitecturePageOneFirst.OutputPathProgramTwoSecond,
                String.Empty,
                String.Empty + '\t' + ",,,,,",
                String.Empty,
                String.Empty + '\t' + "Prompt" + ':' + ' ',
                String.Empty,
                String.Empty + ArchitecturePageOneFirst.AutoCommandStringBuilder.ToString(),
                String.Empty,
            });

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
