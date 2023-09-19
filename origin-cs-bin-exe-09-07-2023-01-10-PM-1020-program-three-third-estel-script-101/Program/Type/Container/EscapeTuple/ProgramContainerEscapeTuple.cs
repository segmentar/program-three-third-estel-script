using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramEscapeTupleContainer(String[] stringArray)
        {
            ArrayList listResult = default;

            var list = new ArrayList();

            var zeroth = -1;

            do
            {
                var hrot = (zeroth + 2);

                Boolean shouldBreak;

                shouldBreak = (hrot == stringArray.Length) is true;

                if (shouldBreak is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var hroth_FIRST = (zeroth + 1);

                var hroth_SECOND = (zeroth + 2);

                var first = stringArray[hroth_FIRST];

                var second = stringArray[hroth_SECOND];

                String key, value;

                key = first;

                value = second;

                Tuple<String, String> tuple;

                tuple = new Tuple<String, String>(key, value);

                list.Add(tuple);

                zeroth = zeroth + 1;

                continue;

            } while (true);

            listResult = list;

            return listResult;
        }
    }
}
