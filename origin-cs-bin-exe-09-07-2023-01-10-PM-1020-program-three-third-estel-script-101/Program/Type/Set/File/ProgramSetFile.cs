using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static IList<String> ProgramFileSet(String[] directoryArray)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (String directory in directoryArray)
            {
                String[] fileArray;

                fileArray = Directory.GetFiles(directory);

                foreach (String file in fileArray)
                {
                    collectionResult.Add(file);

                    continue;
                }

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
