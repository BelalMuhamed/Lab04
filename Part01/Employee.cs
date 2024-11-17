using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01
{
    internal class Employee
    {
        #region Id
        private int id;

		public int Id
		{
			get { return id; }
			set 
			{
				if (value.GetType() == typeof(int))
					id = value;
				else
					throw new InvalidDataException("Invalid Data");
			}
		}

        #endregion

        #region salary
        private int salary;

		public int Salary
		{
			get { return salary; }
			set 
			{
				if (value > 0)
					salary = value;
				else
					throw new ArgumentOutOfRangeException("Invalid value");
			}
			
		}
		#endregion

		#region gender
		private string gender;

		public string Gender
		{
			get { return gender; }
			set 
			{
				if (value == "male" || value == "female")
					gender = value;
				else
					throw new InvalidDataException("Invalid Gender ");
			}
		}

        #endregion

        #region hiringdate
        public HireDate HiringDate { get; set; }
        #endregion

        #region Show Employee
        public override string ToString()
        {
			return $"Employee {id} : salary = {salary},gender={gender},Hiring on = {HiringDate.ToString()} ";
        }
        #endregion

    }
}
