using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_OOP
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {

        }


		public Date(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public void setDate(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public int getDay()
		{
			return day;
		}

		public void setDay(int day)
		{
			this.day = day;
		}

		public int getMonth()
		{
			return month;
		}

		public void setMonth(int month)
		{
			this.month = month;
		}

		public int getYear()
		{
			return year;
		}

		public void setYear(int year)
		{
			this.year = year;
		}

		public string ToString()
        {
			string day = this.day + "";
			string month = this.month + "";
			string year = this.year + "";

			if (day.Length == 1)
				day = "0" + day;

			if (month.Length == 1)
				month = "0" + month;

			return $"{day}/{month}/{year}";
		}
	}
}
