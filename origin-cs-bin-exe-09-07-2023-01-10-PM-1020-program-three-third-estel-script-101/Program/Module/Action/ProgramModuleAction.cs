using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleAction()
        {
            ProgramModule module;

            Program.Free(Program.ProgramFolderSetSurface(Directory.GetCurrentDirectory()));

            module = ProgramModuleDefault();

            foreach (String stringItem in Specialized.GetAutoCommandStringBuilder())
            {
                String stringEntry;

                stringEntry = Program.SafeString(stringItem, true);

                var split = stringEntry.Split();

                Program.CallHandler(split);

                continue;
            }

            Program.Explorer(module.First.CurrentDirectory, 1);

            return module;
        }
    }
}
