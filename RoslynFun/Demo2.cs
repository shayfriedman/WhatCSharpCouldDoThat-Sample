/*
 * Written By Shay Friedman (@ironshay, http://IronShay.com), CodeValue (http://CodeValue.com)
 *
 * The is no license for this code - use it, change it, 
 * distribute it, delete it or do whatever you want with it.
*/

using System;
using System.Collections.Generic;
using Roslyn.Compilers.CSharp;

namespace RoslynFun
{
	public class Demo2
	{
		public void Start()
		{
			SyntaxTree tree = SyntaxTree.ParseCompilationUnit(
@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;
 
namespace TopLevel
{
    using Microsoft;
    using System.ComponentModel;
 
    namespace Child1
    {
        using Microsoft.Win32;
        using System.Runtime.InteropServices;
 
        class Foo { }
    }
 
    namespace Child2
    {
        using System.CodeDom;
        using Microsoft.CSharp;
 
        class Bar { }
    }
}");

			var root = (CompilationUnitSyntax)tree.Root;

			var collector = new UsingCollector();
			collector.Visit(root);

			foreach (var directive in collector.Usings)
			{
				Console.WriteLine(directive.Name);
			}
		}



		class UsingCollector : SyntaxWalker
		{
			public readonly List<UsingDirectiveSyntax> Usings = new List<UsingDirectiveSyntax>();

			protected override void VisitUsingDirective(UsingDirectiveSyntax node)
			{
				if (node.Name.GetText() != "System" &&
					!node.Name.GetText().StartsWith("System."))
				{
					Usings.Add(node);
				}
			}
		}
	}
}
