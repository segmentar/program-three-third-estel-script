using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList DictionaryFromText(String text)
        {
            ArrayList listResult = default;

            var list = new ArrayList();

            foreach (String stringItem in ProgramLineSetSurface(text))
            {
                var split = stringItem.Split(new String[] { "::" }, StringSplitOptions.RemoveEmptyEntries);

                Boolean hasLength;

                hasLength = (split.Length == 2) is true;

                if (hasLength is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                var first = split[0];

                var second = split[1];

                Tuple<String, String> tuple;

                tuple = new Tuple<String, String>(first, second);

                list.Add(tuple);

                continue;
            }

            listResult = list;

            return listResult;
        }
    }
}
