using Core;

namespace Core
{
	using System;

    internal partial class Program
	{
		internal static String[] ArgumentArray;

		internal static void Main(params String[] array_ARGUMENT)
		{
			ArgumentArray = array_ARGUMENT;

			Bundle();

			return;
		}

		internal static void Procedure()
		{
			ProgramPolicy.ProgramDebugPolicy = true;

			ProgramPolicy.ProgramInfoPolicy = true;

			return;
		}

		internal static void Manual()
		{
			ProgramModule programModule = ProgramModule.ProgramModuleAction();

			return;
		}

		internal static void Raise()
		{
			if (ProgramPolicy.ProgramInfoPolicy is true)
			{
				Render($"{ProgramLinkCode.ProgramObservableDirectory.Core}-{ProgramLinkCode.ProgramObservableDirectory.Info}-ProgramInfo", ProgramPolicy.ProgramArrayList.ToArray());
			}
			else
				"false".ToString();

			return;
		}

		internal static void Bundle()
		{
#if DEBUG
			Procedure();
#endif
			Manual();
#if DEBUG
			Raise();
#endif
			return;
		}

		static Program()
		{
			return;
		}
	}
}