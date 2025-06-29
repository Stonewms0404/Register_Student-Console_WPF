using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRegisterStudent
{
    class Course
    {
        private string name = "";
        private bool isRegisteredAlready = false;
        private static int credits = 3;
        private static int totalCredits = 0;

        public Course(string name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public bool IsRegisteredAlready()
        {
            return isRegisteredAlready;
        }

        public void SetToRegistered()
        {
            isRegisteredAlready = true;
            totalCredits += credits;
        }

        public static int GetTotalCredits()
        {
            return totalCredits;
        }

        public override string ToString()
        {
            return getName();
        }
    }
}
