using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    internal partial class Program
    {
        internal static void Free(String[] directoryArray)
        {
            ArrayList arrayList;

            arrayList = new ArrayList();

            foreach (String directory in directoryArray)
            {
                foreach (String stringItem in Enum.GetNames(typeof(ProgramLinkCode.ProgramObservableDirectory)))
                {
                    Tuple<String, String> tuple;

                    tuple = new Tuple<String, String>(directory, stringItem);

                    arrayList.Add(tuple);

                    continue;
                }

                continue;
            }
            
            foreach (Tuple<String, String> tuple in arrayList)
            {
                String directory, name;

                directory = tuple.Item1;

                name = tuple.Item2;

                var path_NAME_directory = new DirectoryInfo(directory).Name;

                var match = true;

                match = match && (path_NAME_directory == name) is true;

                match = match && Directory.Exists(directory) is true;

                if (match is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                Directory.Delete(directory, true);

                continue;
            }

            return;
        }
    }
}
