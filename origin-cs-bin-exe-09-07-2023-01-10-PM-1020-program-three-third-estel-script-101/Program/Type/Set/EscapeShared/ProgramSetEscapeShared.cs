using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static IList<String> ProgramEscapeSharedSet(String[] stringArray, String native, Char character_TERMINATOR, Char character_SHARED)
        {
            IList<String> collectionResult = default;

            collectionResult = new Collection<String>();

            foreach (String stringItem in stringArray)
            {
                String[] splitArray;

                splitArray = new String[] { native };

                var split = stringItem.Split(splitArray, StringSplitOptions.None);

                var boolean_contagiuous_SHARED_is = true;

                boolean_contagiuous_SHARED_is = boolean_contagiuous_SHARED_is && (split.Length > 1) is true;

                boolean_contagiuous_SHARED_is = boolean_contagiuous_SHARED_is && (stringItem.Length == 2) is false;

                Boolean isSharedCheck;

                isSharedCheck = boolean_contagiuous_SHARED_is is true;

                String stringEntry;

                if (isSharedCheck)
                {
                    var whitespace = Convert.ToChar(32);

                    Char[] characterArray;

                    characterArray = new Char[] { character_SHARED, whitespace };

                    var separator = new String(characterArray);

                    stringEntry = stringItem.Replace(whitespace.ToString(), separator);
                }
                else
                {
                    stringEntry = stringItem;
                }

                var result = stringEntry.TrimEnd(character_TERMINATOR);

                collectionResult.Add(result);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
