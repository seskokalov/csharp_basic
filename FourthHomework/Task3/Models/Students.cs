using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Models
{
    public class Students
    {
        public Students()
        {
        }

        public Students(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public string StudentInfo()
        {
            return $"The student name is {Name}, he is in {Academy} academy and it's in the {Group} group";
        }
    }
}
