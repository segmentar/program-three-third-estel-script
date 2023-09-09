using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static Tuple<String[], String[]> ForgeObservableTuple__FILE_DIRECTORY(String directory)
        {
            Tuple<String[], String[]> tupleResult = default;

            String[] directoryArray, fileArray;

            directoryArray = ProgramFolderSetSurface(directory);

            fileArray = ProgramFileSetSurface(directoryArray);

            Tuple<String[], String[]> tuple;

            tuple = new Tuple<String[], String[]>(fileArray, directoryArray);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
