using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] ProgramLineSetSurface(String text)
        {
            String[] arrayResult = default;

            var list = ProgramLineSet(text);

            String[] stringArray;

            stringArray = new String[list.Count];

            list.CopyTo(stringArray, 0);

            arrayResult = stringArray;

            return arrayResult;
        }
    }
}
