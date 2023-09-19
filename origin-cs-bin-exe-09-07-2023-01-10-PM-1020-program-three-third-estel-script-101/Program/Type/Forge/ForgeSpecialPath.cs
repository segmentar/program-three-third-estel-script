using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial class Program
    {
        internal static String ForgeSpecialPath(String stringItem, Boolean createPath)
        {
            String stringResult = default;

            var back_swash = Convert.ToChar(92);

            var split = stringItem.Split(new String[] { back_swash.ToString() }, StringSplitOptions.None);

            var path_DIRECTORY_full_name__ORIGIN = Directory.GetCurrentDirectory();

            var path__FILE_DIRECTORY = path_DIRECTORY_full_name__ORIGIN;

            var enumerator = split.GetEnumerator();

            do
            {
                if (enumerator.MoveNext() is false)
                {
                    break;
                }
                else
                    "false".ToString();

                String reflectString;

                reflectString = enumerator.Current as String;

                var boolean_safe_EQUAL_THAN_origin = (reflectString == ImmutablePageOneFirst.FilesystemNotationDirectoryOrigin);

                var boolean_safe_EQUAL_THAN_back = (reflectString == ImmutablePageOneFirst.FilesystemNotationDirectoryBack);

                Boolean isMoveOriginCheck, isMoveBackCheck;

                isMoveOriginCheck = boolean_safe_EQUAL_THAN_origin is true;

                isMoveBackCheck = boolean_safe_EQUAL_THAN_back is true;

                if (isMoveOriginCheck is true)
                {
                    path__FILE_DIRECTORY = path_DIRECTORY_full_name__ORIGIN;

                    continue;
                }
                else
                    "false".ToString();

                if (isMoveBackCheck is true)
                {
                    path__FILE_DIRECTORY = Path.GetDirectoryName(path__FILE_DIRECTORY);

                    continue;
                }
                else
                    "false".ToString();

                path__FILE_DIRECTORY = Path.Combine(path__FILE_DIRECTORY, reflectString);

                continue;

            } while (true);

            var boolean_CREATE_PATH_should = true;

            boolean_CREATE_PATH_should = boolean_CREATE_PATH_should && createPath is true;

            boolean_CREATE_PATH_should = boolean_CREATE_PATH_should && File.Exists(path__FILE_DIRECTORY) is false;

            boolean_CREATE_PATH_should = boolean_CREATE_PATH_should && Directory.Exists(path__FILE_DIRECTORY) is false;

            Boolean shouldCreatePathCheck;

            shouldCreatePathCheck = boolean_CREATE_PATH_should is true;

            if (shouldCreatePathCheck is true)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path__FILE_DIRECTORY);

                path__FILE_DIRECTORY = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var result = path__FILE_DIRECTORY;

            stringResult = result;

            return stringResult;
        }
    }
}
