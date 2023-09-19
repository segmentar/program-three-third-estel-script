using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramSettingTupleContainer(String text, Char character_LEFT, Char character_RIGHT)
        {
            ArrayList listResult = default;

            var list = new ArrayList();

            foreach (String stringItem in ProgramLineSetSurface(text))
            {
                String stringEntry;

                stringEntry = (String.Empty + character_LEFT + character_RIGHT);

                var split = stringItem.Split(new String[] { stringEntry }, StringSplitOptions.RemoveEmptyEntries);

                var boolean__EQUAL_THAN = (split.Length == 2);

                Boolean hasLength;

                hasLength = boolean__EQUAL_THAN is true;

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
