using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String SafeString(Object objectItem)
        {
            String stringResult = default;

            String stringitem;

            stringitem = objectItem.ToString();

            Char[] characterArray;

            characterArray = stringitem.ToCharArray();

            var zeroth = -1;

            foreach (Char character in characterArray)
            {
                zeroth = zeroth + 1;

                Boolean shouldContinue;

                shouldContinue = Char.IsControl(character) is false;

                if (shouldContinue is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var whitespace = Convert.ToChar(32);

                characterArray[zeroth] = whitespace;

                continue;
            }

            String stringEntry;

            stringEntry = new String(characterArray);

            stringResult = stringEntry;

            return stringResult;
        }
    }
}
