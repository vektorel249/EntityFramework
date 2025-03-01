using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.EndUser;

class Main
{
    public void A()
    {
        var s = new Students();
        s.Add(new Student());

        var od = new ObjectDict();
        od.Add("Code 1", 1);
    }
}

class Student
{
    public string Name { get; set; }
}
class Students : List<Student>
{

}

class ObjectDict : Dictionary<object, object>
{

}
