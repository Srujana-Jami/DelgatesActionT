using System;

namespace ActionAndFuncT
{
    public delegate int BizRulesDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            var data = new ProcessData();
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate multiplyDel = (x, y) => x * y;

            Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);
            //data.ProcessAction(2, 3, myAction);

            data.ProcessAction(2, 3, myAction);
            
            var worker = new Worker();
            worker.WorkPerformed += (s, e) =>
            {
                Console.WriteLine("Worked : " + e.Hours + "hours doing: " + e.WorkType);
                Console.WriteLine("Some Other value");
            };
            worker.WorkCompleted += (s, e) => Console.WriteLine("Work is done");


            worker.DoWork(8, WorkType.GenerateReports);

            Console.Read();
        }

        

    }
}
