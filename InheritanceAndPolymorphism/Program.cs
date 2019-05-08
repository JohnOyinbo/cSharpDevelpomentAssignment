using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Data
    {

    }
    public class DataManager
    {
        public virtual void SaveRecord(Data data)
        {
            Console.WriteLine("DataManager save record was called");
        }
    }
    public class StudentDataManager : DataManager
    {
        public override void SaveRecord(Data data)
        {
            base.SaveRecord(data);
            Console.WriteLine("StudentDataManager save record was called");
        }
    }
    public class CourseDataManager : DataManager
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            DataManager dataMgr = new StudentDataManager();
            dataMgr.SaveRecord(new Data());
            dataMgr = new CourseDataManager();
        }
    }
}
