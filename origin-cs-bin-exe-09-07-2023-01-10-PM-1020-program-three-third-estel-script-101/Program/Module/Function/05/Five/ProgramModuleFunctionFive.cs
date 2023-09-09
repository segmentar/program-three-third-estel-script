using Core;

namespace Core
{
	using System;

	public partial struct ProgramModule
	{
		public static ProgramModule ProgramModuleFunctionFive(ProgramModule module)
		{
			ProgramModuleFunctionFifth fifth;

			fifth = new ProgramModuleFunctionFifth();

			module.Fifth = fifth;

			return module;
		}
	}
}