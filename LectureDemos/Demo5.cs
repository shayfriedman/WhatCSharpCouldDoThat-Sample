/*
 * Written By Shay Friedman (@ironshay, http://IronShay.com), CodeValue (http://CodeValue.com)
 *
 * The is no license for this code - use it, change it, 
 * distribute it, delete it or do whatever you want with it.
*/

using System;
using System.Dynamic;
using System.Data;

namespace LectureDemos
{
	public class Demo5
	{
		public void Run()
		{
			dynamic obj = new LogMethodCalls();
			obj.Test();

			DataTable dt = CreateDataTable();
			dynamic finder = new SuperFinder(dt);
			foreach (DataRow row in finder.FindByName("Canada"))
			{
				Console.WriteLine(row["Id"] + ". " + row["Name"]);
			}
		}

		#region CreateDataTable
		
		private DataTable CreateDataTable()
		{
			DataTable table = new DataTable();

			table.Columns.Add("Id", typeof (int));
			table.Columns.Add("Name", typeof (string));

			table.Rows.Add(1, "United States");
			table.Rows.Add(2, "Canada");
			table.Rows.Add(3, "England");
			table.Rows.Add(4, "India");

			return table;
		}

		#endregion
	}

	public class LogMethodCalls : DynamicObject
	{			
		public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
		{
			Console.WriteLine("Trying to invoke {0}", binder.Name);
			result = null;
			return true; // means that the required method was found. Retuning false would lead to an exception.
		}
	}
	#region Super Finder
	
	public class SuperFinder : DynamicObject
	{
		private readonly DataTable _data;
		public SuperFinder(DataTable data)
		{
			_data = data;
		}

		public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
		{
			if (binder.Name.StartsWith("FindBy"))
			{
				string columnName = binder.Name.Substring(6);
				string value = args[0].ToString();
				
				if (_data.Columns[columnName].DataType == typeof(string))
				{
					value = "'" + value + "'";
				}

				result = _data.Select(columnName + " = " + value);
				return true;
			}
			
			return base.TryInvokeMember(binder, args, out result);
			
		}
	}

	#endregion
}

