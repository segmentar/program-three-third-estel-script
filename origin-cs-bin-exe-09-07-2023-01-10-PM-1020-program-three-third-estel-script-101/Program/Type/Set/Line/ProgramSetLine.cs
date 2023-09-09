using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static IList<String> ProgramLineSet(String text)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var split = text.Split(new String[] { "\r\n" }, StringSplitOptions.None);

            foreach (String stringItem in split)
            {
                collectionResult.Add(stringItem);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
