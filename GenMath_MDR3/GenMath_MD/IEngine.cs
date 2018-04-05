using System;
namespace GenMath_MD
{
	public interface IEngine
	{
		double GetVariable(string name);
		void SetVariable(string name, double value);
	}
}