using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;
using Roslyn.Scripting;
using Roslyn.Scripting.CSharp;

namespace RoslynFun
{
	class Program
	{
		static void Main(string[] args)
		{
			var d = new Demo1();
			d.Start();
		}
	}

	
}
