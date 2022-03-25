using System;
using System.Collections.Generic;
using System.Text;

namespace taskclasswork
{
    class Worker:Person
    {
        public Worker(string name, string surname, byte age):base(name, surname, age)
        {

        }
        public double MoneyForHour;
        public double WorkTimeForMonth;

    }
}
