namespace P1_3Student
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student()
        {
        }

        public Student(string firstName, string middleName, string lastName, int ssn)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
        }

        public Student(string firstName, string middleName, string lastName, int ssn, string permanentAddress, string mobilePhone, string email, string course, Specialties specialty, Universities university, Faculties faculty)
            : this(firstName, middleName, lastName, ssn)
        {
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int SSN { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }

        public Specialties Specialty { get; set; }

        public Universities University { get; set; }

        public Faculties Faculty { get; set; }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !Student.Equals(student1, student2);
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (student == null)
            {
                return false;
            }

            if (!object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }

            if (!object.Equals(this.LastName, student.LastName))
            {
                return false;
            }

            if (this.SSN != student.SSN)
            {
                return false;
            }

            if (!object.Equals(this.PermanentAddress, student.PermanentAddress))
            {
                return false;
            }

            if (!object.Equals(this.MobilePhone, student.MobilePhone))
            {
                return false;
            }

            if (!object.Equals(this.Email, student.Email))
            {
                return false;
            }

            if (!object.Equals(this.Course, student.Course))
            {
                return false;
            }

            if (this.Specialty != student.Specialty)
            {
                return false;
            }

            if (this.University != student.University)
            {
                return false;
            }

            if (this.Faculty != student.Faculty)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^
                this.MiddleName.GetHashCode() ^
                this.LastName.GetHashCode() ^
                this.SSN ^
                this.PermanentAddress.GetHashCode() ^
                this.MobilePhone.GetHashCode() ^
                this.Email.GetHashCode() ^
                this.Course.GetHashCode() ^
                this.Specialty.GetHashCode() ^
                this.University.GetHashCode() ^
                this.Faculty.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(string.Format("First name: {0} ", this.FirstName));
            toString.Append(string.Format("Middle name: {0} ", this.MiddleName));
            toString.AppendLine(string.Format("Last name: {0}", this.LastName));
            toString.AppendLine("SSN: " + this.SSN);
            toString.AppendLine("Permanent Address: " + this.PermanentAddress);
            toString.AppendLine("Mobile phone: " + this.MobilePhone);
            toString.AppendLine("Email: " + this.Email);
            toString.AppendLine("Course: " + this.Course);
            toString.AppendLine("University: " + this.University);
            toString.AppendLine("Specialty: " + this.Specialty);
            return toString.ToString();
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.MobilePhone, this.Email, this.Course, this.Specialty, this.University, this.Faculty);
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }

            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            if (this.SSN != other.SSN)
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return 0;
        }
    }
}
