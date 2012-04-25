/*
 * Written By Shay Friedman (@ironshay, http://IronShay.com), CodeValue (http://CodeValue.com)
 *
 * The is no license for this code - use it, change it, 
 * distribute it, delete it or do whatever you want with it.
*/

using System;
using System.Dynamic;

namespace LectureDemos
{
	public class Demo2
	{
		public void Run()
		{
			dynamic expando = new ExpandoObject();
			expando.Message = "Hello from the dynamic world";
			expando.Print = (Action<string>)((message) =>  Console.WriteLine("Yea " + message));

			Console.WriteLine(expando.Message);
			expando.Print("Howdy!");
		}
	}
}
