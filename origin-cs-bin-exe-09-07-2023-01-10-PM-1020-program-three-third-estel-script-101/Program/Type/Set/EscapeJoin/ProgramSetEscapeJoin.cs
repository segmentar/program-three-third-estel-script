using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal partial class Program
    {
        internal static IList<String> ProgramEscapeJoinSet(String[] stringArray, Char character_ESCAPE)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var enumerator = stringArray.GetEnumerator();

            var zeroth = -1;

            do
            {
                zeroth = zeroth + 1;

                Boolean shouldBreak;

                shouldBreak = enumerator.MoveNext() is false;

                if (shouldBreak is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var item_REFLECT__ONE_FIRST = enumerator.Current as String;

                var boolean_contagious__MORE_THAN = (item_REFLECT__ONE_FIRST.Length > 1);

                Boolean isLengthCheck;

                isLengthCheck = boolean_contagious__MORE_THAN is true;

                if (isLengthCheck)
                {
                    var roth = (item_REFLECT__ONE_FIRST.Length - 1);

                    var last = item_REFLECT__ONE_FIRST[roth];

                    var boolean_contagious__EQUAL_THAN = (last == character_ESCAPE);

                    Boolean isEscapeCheck;

                    isEscapeCheck = boolean_contagious__EQUAL_THAN is true;

                    if (isEscapeCheck)
                    {
                        var safe_BREAK_should = enumerator.MoveNext() is false;

                        if (safe_BREAK_should is true)
                        {
                            break;
                        }
                        else
                        {
                            var ordinal = roth;

                            var length = ordinal;

                            Char[] characterArray;

                            characterArray = item_REFLECT__ONE_FIRST.ToCharArray();

                            Array.Resize(ref characterArray, length);

                            String stringItem;

                            stringItem = new String(characterArray);

                            var item_REFLECT__TWO_SECOND = enumerator.Current as String;

                            var whitespace = Convert.ToChar(32);

                            String stringEntry;

                            stringEntry = (stringItem + whitespace + item_REFLECT__TWO_SECOND);

                            collectionResult.Add(stringEntry);
                        }
                    }
                    else
                    {
                        collectionResult.Add(item_REFLECT__ONE_FIRST);
                    }
                }
                else
                {
                    collectionResult.Add(item_REFLECT__ONE_FIRST);
                }

                continue;

            } while (true);

            return new List<String>(collectionResult);
        }
    }
}
