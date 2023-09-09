using Core;

namespace Core
{
	using System;

	public partial struct ProgramModule
	{
		public static ProgramModule ProgramModuleFunctionTwo(ProgramModule module)
		{
			var tuple = Program.ForgeObservableTuple__FILE_DIRECTORY(module.First.CurrentDirectory);

			ProgramModuleFunctionSecond second;

			second = new ProgramModuleFunctionSecond(tuple.Item1, tuple.Item2);

			module.Second = second;

			return module;
		}
	}
}