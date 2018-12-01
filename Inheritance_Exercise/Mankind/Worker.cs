using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                workHoursPerDay = value;
            }
        }

        public double WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }

        public double CalcSalary()
        {
            double sal = this.weekSalary / 5 / this.WorkHoursPerDay;

            return sal;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());

            result.AppendLine(string.Format(
                "Week Salary: {0:F2}", this.WeekSalary));
            result.AppendLine(string.Format(
                "Hours per day: {0:F2}", this.WorkHoursPerDay));
            result.AppendLine(string.Format(
                "Salary per hour: {0:F2}", this.CalcSalary()));

            return result.ToString().Trim();
        }
    }
}
