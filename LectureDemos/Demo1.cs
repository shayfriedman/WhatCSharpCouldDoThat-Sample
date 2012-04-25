/*
 * Written By Shay Friedman (@ironshay, http://IronShay.com), CodeValue (http://CodeValue.com)
 *
 * The is no license for this code - use it, change it, 
 * distribute it, delete it or do whatever you want with it.
*/

using System;

namespace LectureDemos
{
	public class Demo1
	{
		public void Run()
		{
			Console.WriteLine(Add<int>(1, 2));
			Console.WriteLine(Add<double>(1.5, 5));
			Console.WriteLine(Add<string>("Hello", " World!"));
			Console.WriteLine(Add<FunClass>(new FunClass {Data = "First"}, new FunClass {Data = "Second"}));
		}

		private T Add<T>(dynamic a, dynamic b)
		{
			return a + b;
		}
	}

	public class FunClass
	{
		public string Data { get; set; }
		public static FunClass operator +(FunClass a, FunClass b)
		{
			return new FunClass {Data = a.Data + b.Data};
		}

		public override string ToString()
		{
			return Data;
		}
	}
}
