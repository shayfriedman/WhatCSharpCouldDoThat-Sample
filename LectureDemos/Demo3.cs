/*
 * Written By Shay Friedman (@ironshay, http://IronShay.com), CodeValue (http://CodeValue.com)
 *
 * The is no license for this code - use it, change it, 
 * distribute it, delete it or do whatever you want with it.
*/

using System;
using System.Reflection;
using System.IO;

namespace LectureDemos
{
	public class Demo3
	{
		public void Run()
		{
			Assembly assembly = Assembly.LoadFile(Path.GetFullPath("../../../SamplePlugin/bin/Debug/SamplePlugin.dll"));
			Type t = assembly.GetType("ExternalPlugin.Plugin");
			dynamic obj = Activator.CreateInstance(t);
			
			string messageFromPlugin = obj.CreateMessage();
			
			Console.WriteLine(messageFromPlugin);
		}
	}
}
