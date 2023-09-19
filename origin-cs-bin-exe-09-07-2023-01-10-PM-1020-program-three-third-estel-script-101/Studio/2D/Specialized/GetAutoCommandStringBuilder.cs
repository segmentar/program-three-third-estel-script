using Core;

namespace Core
{
    using System;

    internal partial class Specialized
    {
        internal static String[] GetAutoCommandStringBuilder()
        {
            String[] arrayResult = default;

            var line_feed = Convert.ToChar(10);

            String stringReflect;

            stringReflect = ArchitecturePageOneFirst.AutoCommandStringBuilder.ToString();

            var split = stringReflect.Split(new String[] { line_feed.ToString() }, StringSplitOptions.None);

            var eoth = 1;

            var roth = (split.Length - eoth);

            var length = roth;

            String[] stringArray;

            stringArray = new String[length];;

            Array.Copy(split, eoth, stringArray, 0, length);

            arrayResult = stringArray;

            return arrayResult;
        }
    }
}
