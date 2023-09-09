using Core;

namespace Core
{
	using System;

	public partial struct ProgramModule
	{
		public static ProgramModule ProgramModuleFunctionFour(ProgramModule module)
		{
			ProgramModuleFunctionFourth fourth;

			fourth = new ProgramModuleFunctionFourth();

			module.Fourth = fourth;

			return module;
		}
	}
}