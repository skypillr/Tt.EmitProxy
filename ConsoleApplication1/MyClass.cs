using SadasSof.Aspects.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApplication1
{
    public class MyClassTest : IMyclass
    {
        public MyClassTest()
        {
            int x = 1;
        }

        public void MyClassTestInterface()
        {
            Console.WriteLine("in no p MyClassTestInterface(int x)");
        }

        public void MyClassTestInterface(int x)
        {
            Console.WriteLine("in MyClassTestInterface(int x)");
        }

        //public void MyClassTestInterface(int x, int y)
        //{
        //    Console.WriteLine("in MyClassTestInterface(int x, int y)");
        //}
    }

    public class TestBeforeAttribute : BeforeAttribute
    {
        public override object Action(object target, MethodBase method, object[] parameters, object result)
        {
            Console.WriteLine("in TestBefore Action(object target, MethodBase method, object[] parameters, object result)");
            return null;
        }
    }

    public interface IMyclass
    {
        [TestBeforeAttribute]
        [LoggerExceptionToFile]
        void MyClassTestInterface();
        //[TestBeforeAttribute]
        //[LoggerExceptionToFile]
        //void MyClassTestInterface(int x);
        //[TestBeforeAttribute]
        //[LoggerExceptionToFile]
        //void MyClassTestInterface(int x,int y);
    }
}
