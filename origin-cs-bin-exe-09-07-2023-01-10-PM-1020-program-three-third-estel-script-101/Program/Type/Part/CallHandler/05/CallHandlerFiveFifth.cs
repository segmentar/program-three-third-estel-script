using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void CallHandlerFiveFifth(String[] split, String call, String escape, String terminator, String shared, String native, Char character_ESCAPE, Char character_TERMINATOR, Char character_SHARED, Tuple<String, String>[] tupleArray, String[] array_PORTAL, String[] array_ESCAPE)
        {
            var array = ProgramEscapeSharedSetSurface(array_ESCAPE, native, character_TERMINATOR, character_SHARED);

            var seventh = array[6];

            String file;

            file = seventh;

            var ordinal = 7;

            var size = (array.Length - ordinal);

            String[] stringArray;

            stringArray = new String[size];

            Array.Copy(array, ordinal, stringArray, 0, size);

            Console.Clear();

            Console.Out.WriteLine($"\t\t{nameof(split)}<{split.Length}>");

            Console.Out.WriteLine($"{String.Join('\n'.ToString(), split as Object[])}");

            Console.Out.WriteLine($"\t\t{nameof(call)}: {call}");

            Console.Out.WriteLine($"\t\t{nameof(escape)}: {escape}");

            Console.Out.WriteLine($"\t\t{nameof(terminator)}: {terminator}");

            Console.Out.WriteLine($"\t\t{nameof(shared)}: {shared}");

            Console.Out.WriteLine($"\t\t{nameof(native)}: {native}");

            Console.Out.WriteLine($"\t\t{nameof(character_ESCAPE)}: {character_ESCAPE}");

            Console.Out.WriteLine($"\t\t{nameof(character_TERMINATOR)}: {character_TERMINATOR}");

            Console.Out.WriteLine($"\t\t{nameof(character_SHARED)}: {character_SHARED}");

            Console.Out.WriteLine($"\t\t{nameof(tupleArray)}<{tupleArray.Length}>");

            Console.Out.WriteLine($"{String.Join('\n'.ToString(), tupleArray as Object[])}");

            Console.Out.WriteLine($"\t\t{nameof(array_PORTAL)}<{array_PORTAL.Length}>");

            Console.Out.WriteLine($"{String.Join('\n'.ToString(), array_PORTAL as Object[])}");

            Console.Out.WriteLine($"\t\t{nameof(array_ESCAPE)}<{array_ESCAPE.Length}>");

            Console.Out.WriteLine($"{String.Join('\n'.ToString(), array_ESCAPE as Object[])}");

            Console.Out.WriteLine($"\t\t{nameof(array)}<{array.Length}>");

            Console.Out.WriteLine($"{String.Join('\n'.ToString(), array as Object[])}");

            Console.Out.WriteLine($"\t\t{nameof(stringArray)}<{stringArray.Length}>");

            Console.Out.WriteLine($"{String.Join('\n'.ToString(), stringArray as Object[])}");

            Console.In.ReadLine();

            Interop.Calf01(1, file, stringArray);

            return;
        }
    }
}
