using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01
{
    internal struct HireDate
    {
        #region DayFullProperty
        private int day;

		public int Day
		{
			get { return day; }
			set 
			{ 
				if(value>0 && value<32)
				{
					day = value;
				}
				else 
				{
					throw new ArgumentOutOfRangeException("Out Of Range");
				}
			}
		}
		#endregion

		#region MonthFullProperty
		private int month;

		public int Month
		{
			get { return month; }
			set 
			{
				if(value>0 && value<13)
					month = value;
				else
                    throw new ArgumentOutOfRangeException("Out Of Range");

            }
		}

		#endregion

		#region YearFullProperty
		private int year;

		public int Year
		{
			get { return year; }
			set 
			{ 
				if(value>1950 && value<2025)
					year = value;
				else
                    throw new ArgumentOutOfRangeException("Out Of Range");
            }
		}

        #endregion

        #region overrideToStringForShowDateFormating
        public override string ToString()
        {
            return $"{day}-{month}-{year}";
        }
		#endregion

		
	}
}
