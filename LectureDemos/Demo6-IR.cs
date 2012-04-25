/*
 * Written By Shay Friedman (@ironshay, http://IronShay.com), CodeValue (http://CodeValue.com)
 *
 * The is no license for this code - use it, change it, 
 * distribute it, delete it or do whatever you want with it.
*/

using System;
using System.Collections.Generic;

namespace LectureDemos
{
	public class Demo6
	{
		public void Run()
		{
			// Load the recorder IronRuby file
			var engine = IronRuby.Ruby.CreateEngine();
			engine.ExecuteFile("../../recorder.rb");
			dynamic ruby = engine.Runtime.Globals;

			// Initialize IronRuby's recorder class
			dynamic recorder = ruby.Recorder.@new();

			// Record
			recorder.Add(1);
			recorder.Add(2);

			// Playback on CLR's List object
			List<int> list = new List<int>();
			recorder.playback(list);

			// Print the results!
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}

			// Record console printing
			recorder = ruby.Recorder.@new();
			recorder.Write("IronRuby");
			recorder.WriteLine(" and .Net {0}", 4);
			recorder.WriteLine("ARE DA BOMB!!!!!!!!!!");

			// Playback on console
			recorder.playback(Console.Out);
		}		
	}	
}
