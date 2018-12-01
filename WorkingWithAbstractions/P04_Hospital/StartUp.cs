using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class StartUp
    {
        static List<Doctor> doctors = new List<Doctor>();
        static List<Department> departments = new List<Department>();

        public static void Main()
        {
             doctors = new List<Doctor>();
             departments = new List<Department>();

            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] commandArgs = command.Split();

                var departmentName = commandArgs[0];
                var firstName = commandArgs[1];
                var lastName = commandArgs[2];
                var patient = commandArgs[3];
                var fullName = firstName + lastName;

                Department department = GetDepartment(departmentName);

                Doctor doctor = GetDoctor(firstName, lastName);

                bool availableSpace = department.Rooms.Sum(x => x.Patients.Count) < 60;

                if (availableSpace)
                {
                    int targetRoom = 0;

                    doctor.Patients.Add(patient);

                    for (int room = 0; room < department.Rooms.Count; room++)
                    {
                        if (department.Rooms[room].Patients.Count < 3)
                        {
                            targetRoom = room;
                            break;
                        }
                    }
                    department.Rooms[targetRoom].Patients.Add(patient); 
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();

                if (commandArgs.Length == 1)
                {
                    var department = GetDepartment(commandArgs[0]);

                    foreach (var room in department.Rooms.Where(x => x.Patients.Count > 0))
                    {
                        foreach (var patient in room.Patients)
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }
                else if (commandArgs.Length == 2 && int.TryParse(commandArgs[1], out int room))
                {
                    var department = GetDepartment(commandArgs[0]);

                    foreach (var patient in department.Rooms[room - 1].Patients.OrderBy(x => x))
                    {
                        Console.WriteLine(patient);
                    }
                }
                else
                {
                    var doctor = GetDoctor(commandArgs[0], commandArgs[1]);

                    foreach (var patient in doctor.Patients.OrderBy(x => x))
                    {
                        Console.WriteLine(patient);
                    }
                }
                command = Console.ReadLine();
            }
        }

        private static Doctor GetDoctor(string firstName, string lastName)
        {
            Doctor doctor = doctors.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            if (doctor == null)
            {
                doctor = new Doctor(firstName, lastName);
                doctors.Add(doctor);
            }

            return doctor;
        }

        private static Department GetDepartment(string departmentName)
        {
            Department department = departments.FirstOrDefault(x => x.Name == departmentName);

            if (department == null)
            {
                department = new Department(departmentName);
                departments.Add(department);

                for (int rooms = 0; rooms < 20; rooms++)
                {
                    department.Rooms.Add(new Room());
                }
            }

            return department;
        }
    }
}
