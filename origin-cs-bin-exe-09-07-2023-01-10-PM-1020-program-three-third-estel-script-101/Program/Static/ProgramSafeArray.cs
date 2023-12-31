﻿using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] SafeArray(Boolean trimWhitespace, params Object[] objectArray)
        {
            String[] arrayResult = default;

            String[] stringArray;

            stringArray = new String[objectArray.Length];

            var indexer = 0;

            foreach (Object objectItem in objectArray)
            {
                String stringEntry;

                stringEntry = SafeString(objectItem, trimWhitespace);

                stringArray[indexer] = stringEntry;

                indexer = indexer + 1;

                continue;
            }

            arrayResult = stringArray;

            return arrayResult;
        }
    }
}
