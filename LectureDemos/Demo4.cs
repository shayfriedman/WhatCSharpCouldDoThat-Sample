/*
 * Written By Shay Friedman (@ironshay, http://IronShay.com), CodeValue (http://CodeValue.com)
 *
 * The is no license for this code - use it, change it, 
 * distribute it, delete it or do whatever you want with it.
*/

using System;
using System.Xml.Linq;
using AmazedSaint.Elastic;
using AmazedSaint.Elastic.Lib;

namespace LectureDemos
{
	public class Demo4
	{
		public void Run()
		{
			string xml = @"
<People>
  <Person Name=""Shay Friedman"" TwitterHandle=""@IronShay"" Blog=""http://IronShay.com"" />
  <Person Name=""John Doe"" TwitterHandle=""@JohnDoe"" Blog=""http://Anonymous.com"" />
</People>
";
			dynamic people = XElement.Parse(xml).ToElastic();
			foreach (dynamic person in people["Person"])
			{
				Console.WriteLine("{0}, {1}, {2}", person.Name, person.TwitterHandle, person.Blog);
			}


			dynamic band = new ElasticObject("Band");
			band.Name = "The Scropions";
			dynamic song1 = band.Songs.Song();
			song1.Name = "Winds of Change";
			song1.Length = "5:12";
			dynamic song2 = band.Songs.Song();
			song2.Name = "Still Loving You";
			song2.Length = "6:26";

			XElement element = band > FormatType.Xml;
			Console.WriteLine(element.ToString());

		}
	}
}
