/*
 * Written By Shay Friedman (@ironshay, http://IronShay.com), CodeValue (http://CodeValue.com)
 *
 * The is no license for this code - use it, change it, 
 * distribute it, delete it or do whatever you want with it.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Roslyn.Scripting;
using Roslyn.Scripting.CSharp;

namespace RoslynFun
{
	public class Demo1
	{
		public void Start()
		{
			Console.WriteLine("C# REPL Console\n\n");
			var host = new ScriptingHost();			

			string codeLine;
			Console.Write("> ");
			while ((codeLine = Console.ReadLine()) != "bye bye")
			{
				try
				{
					//Execute the code
					var res = host.Execute(codeLine);

					//Write the result back to console
					if (res != null)
						Console.WriteLine(" = " + res);
				}
				catch (Exception e)
				{
					Console.WriteLine(" !! " + e.Message);
				}

				Console.Write("> ");
			}
		}
	}

	public class ScriptingHost
	{
		private readonly ScriptEngine _engine;
		private readonly Session _session;

		public ScriptingHost()
		{
			//Create a session
			_session = Session.Create(this);

			//Create the engine, just pass the assemblies and namespaces
			_engine = new ScriptEngine(new[]
                                {
                                    typeof(Console).Assembly,
                                    typeof(ScriptingHost).Assembly,
                                    typeof(IEnumerable<>).Assembly,
                                    typeof(IQueryable).Assembly,
									typeof(System.Windows.Forms.MessageBox).Assembly
                                },
								new[] 
                                { 
                                    "System", "System.Linq", 
                                    "System.Collections",
                                    "System.Collections.Generic",
									"System.Windows.Forms"
                                }
							);

		}

		//Pass the code to the engine, nothing much here
		public object Execute(string code)
		{
			return _engine.Execute(code, _session);
		}

		public T Execute<T>(string code)
		{
			return _engine.Execute<T>(code, _session);
		}

	}
}

