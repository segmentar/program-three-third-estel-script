using Core;

namespace Core
{
    using System;

    using System.Diagnostics;

    public partial class Interop
    {
        public static void Calf01(Int32 ordinal, String file, params String[] argumentArray)
        {
            var whitespace = Convert.ToChar(32);

            var join = String.Join(whitespace.ToString(), argumentArray);

            ProcessStartInfo processStartInfo;

            processStartInfo = new ProcessStartInfo(file, join);

            Process process;

            process = new Process();

            process.StartInfo = processStartInfo;

            using (process)
            {
                if (process.Start())
                {
                    goto skip;
                }
                else
                {
                    var next = (ordinal + 1);

                    Calf01(next, file, argumentArray);
                }

            skip:
                {
                    process.Close();

                    process.Dispose();
                }
            }
            
            return;
        }
    }
}
