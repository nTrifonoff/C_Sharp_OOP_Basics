using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Doctor
    {
        private string firstName;
        private string lastName;
        private List<string> patients;

        public Doctor(string firstName, string lastName)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Patients = new List<string>();
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public List<string> Patients
        {
            get => patients;
            set => patients = value;
        }
    }
}
