using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int NumberSSN { get; set; }
        public string PermanentAdress { get; set; }
        public int MobilePhone { get; set; }
        public string EMail { get; set; }
        public int CourseNumber { get; set; }
        public Specialty Specialty { get; set; }
        public Universitiy Universitiy { get; set; }
        public Faculty Faculty { get; set; }


        public Student (string firstName, string middleName, string lastName, int numberSSN, string permanetAdress, int mobilePhone,
            string eMail, int courseNumber, Specialty specialty, Universitiy universitiy, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.NumberSSN = numberSSN;
            this.PermanentAdress = permanetAdress;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.CourseNumber = courseNumber;
            this.Specialty = specialty;
            this.Universitiy = universitiy;
            this.Faculty = faculty;
        }

        public override bool Equals(object other)
        {
            var otherStudent = other as Student;

            return this.FirstName == otherStudent.FirstName
                    && this.MiddleName == otherStudent.MiddleName
                    && this.LastName == otherStudent.LastName
                    && this.NumberSSN == otherStudent.NumberSSN;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(string.Format("Student name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.Append(string.Format("\nSSN: {0}\nPermanent Adress: {1}\nMobile phone: {2}\nEmail: {3}\nCourse: {4}"
                          , this.NumberSSN, this.PermanentAdress, this.MobilePhone, this.EMail, this.CourseNumber));
            result.Append(string.Format("\nUniversity: {0}\nSpecialty: {1}\nFaculty: {2}"
                          , this.Universitiy, this.Specialty, this.Faculty));


            return result.ToString();
        }

        public override int GetHashCode()
        {
            int hash = 9;
            hash = (hash * 7) + this.NumberSSN.GetHashCode();
            return hash;
        }

        public static bool operator ==(Student firstStud, Student secondStud)
        {
            return firstStud.Equals(secondStud);
        }

        public static bool operator !=(Student firstStud, Student secondStud)
        {
            return !(firstStud == secondStud);
        }

        //EX2
        public object Clone()
        {
            Student originalStudent = this;
            Student newStudent = new Student(originalStudent.FirstName, originalStudent.MiddleName, originalStudent.LastName,
                                originalStudent.NumberSSN, originalStudent.PermanentAdress, originalStudent.MobilePhone, originalStudent.EMail,
                                originalStudent.CourseNumber, originalStudent.Specialty, originalStudent.Universitiy, originalStudent.Faculty);

            return newStudent;  
        }

        //EX 3
        public int CompareTo(object obj)
        {
            Student otherStudent = obj as Student;
            int comparrison = this.FirstName.CompareTo(otherStudent.FirstName);
            if (comparrison == 0)
            {
                return this.NumberSSN.CompareTo(otherStudent.NumberSSN);
            }

            return comparrison;
        }
    }
}
