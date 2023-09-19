using Core;

namespace Core
{
    using System;

    using System.Text;

    internal static class ArchitecturePageOneFirst
    {
        internal static String PathProgramOneFirst;

        internal static String PathProgramTwoSecond;

        internal static String InputPathProgramOneFirst;

        internal static String InputPathProgramTwoSecond;

        internal static String OutputPathProgramOneFirst;

        internal static String OutputPathProgramTwoSecond;

        internal static StringBuilder AutoCommandStringBuilder;

        static ArchitecturePageOneFirst()
        {
            PathProgramOneFirst = ProgramArchitectureDefaultPageOneFirst.PathToProgramOneFirstDefault;

            PathProgramTwoSecond = ProgramArchitectureDefaultPageOneFirst.PathToProgramTwoSecondDefault;

            InputPathProgramOneFirst = ProgramArchitectureDefaultPageOneFirst.InputPathProgramOneFirstDefault;

            InputPathProgramTwoSecond = ProgramArchitectureDefaultPageOneFirst.InputPathProgramTwoSecondDefault;

            OutputPathProgramOneFirst = ProgramArchitectureDefaultPageOneFirst.OutputPathProgramOneFirstDefault;

            OutputPathProgramTwoSecond = ProgramArchitectureDefaultPageOneFirst.OutputPathProgramTwoSecondDefault;

            AutoCommandStringBuilder = ProgramArchitectureDefaultPageOneFirst.AutoCommandStringBuilderDefault;

            return;
        }
    }
}
