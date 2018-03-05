using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAssignment1
{
    class Student
    {
        private string name;
        private Queue<Test> testQueue;

        public Student()
        {
            testQueue = new Queue<Test>();
        }

        public Student(string name)
        {
            Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new NullReferenceException("Name not provided");
                }

                else
                {
                    name = value;
                }
            }


        }

        public Queue<Test> getAllTest()
        {
            return testQueue;
        }

        public void addTest(Test test)
        {
            testQueue.Enqueue(test);
        }



        public double calcTotalScore()
        {
            Test test = new Test();
            double totalTestScore = 0;
            foreach (Test printTestScore in testQueue)
            {
                totalTestScore += (test.ObtainedScore);
                Console.WriteLine("Total test Score", printTestScore);
            }

            return totalTestScore;

        }

        public double calcMaxScore()
        {
            Test test = new Test();
            double totalMaxScore = 0;

            foreach (Test printMaxScore in testQueue)
            {
                totalMaxScore += (test.MaximumScore);
                Console.WriteLine("Total Maximum Score", printMaxScore);
            }

            return totalMaxScore;
        }

        public bool updateTest(Test test)
        {
            bool updateStatus = false;
            Queue<Test> tempTestQueue = new Queue<Test>();

            while (testQueue.Count > 0)
            {
                Test testTemp = testQueue.Dequeue();
                if (testTemp.TestID != test.TestID)
                {
                    tempTestQueue.Enqueue(testTemp);
                   
                }
                else
                {
                    tempTestQueue.Enqueue(test);
                    
                }
            }
            testQueue = tempTestQueue;


            return updateStatus;
        }

    


        public bool removeTest(int testId)
        {
            bool removeStatus = false;
            Queue<Test> tempTestQueue = new Queue<Test>();

            while(testQueue.Count>0)
            {
                Test test = testQueue.Dequeue();
                if (test.TestID != testId)
                {
                    tempTestQueue.Enqueue(test);
                } else
                {
                    removeStatus = true;
                }
            }
            testQueue = tempTestQueue;


            return removeStatus;
        }
        public override string ToString()
        {
            return "Name:" + name +"\n" ;
        }
    }
}
