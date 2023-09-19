using Core;

namespace Core
{
	using System;

	public partial struct ProgramModule
	{
		public static ProgramModule ProgramModuleFunctionThree(ProgramModule module)
		{
			ProgramModuleFunctionThird third;

			third = new ProgramModuleFunctionThird();

			module.Third = third;

			return module;
		}
	}
}