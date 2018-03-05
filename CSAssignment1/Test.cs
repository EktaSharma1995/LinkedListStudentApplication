using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAssignment1
{
    class Test
    {
        private int testId;
        private double obtainedScore;
        private double maximumScore;

        public Test()
        {

        }

        public Test(int testId, double obtainedScore, double maximumScore)
        {
            TestID = testId;
            ObtainedScore = obtainedScore;
            MaximumScore = maximumScore;
        }

        public int TestID
        {
            get
            {
                return testId;
            }

            set
            {
                if (value < 0 || value == 0)
                {
                    throw new NullReferenceException("Test Id can't be negative or zero");
                }

                else
                {
                    testId = value;
                }
               
            }

            
        }

        public double ObtainedScore
        {
            get
            {
                return obtainedScore;
            }
            set
            {
                if (value < 0 || value == 0)
                {
                    throw new NullReferenceException("Obtained socre can't be negative or zero");
                }

                else
                {
                    obtainedScore = value;
                }
                
            }

            
        }

        public double MaximumScore
        {
            get
            {
                return maximumScore;
            }
            set
            {
                if (value < 0 || value == 0)
                {
                    throw new NullReferenceException("Maximum socre can't be negative or zero");
                }

                else
                {
                    maximumScore = value;
                }
                
            }

            
        }

        public override string ToString()
        {
            return "Test Id:" + testId + "\n" 
                + "Test Score:" + obtainedScore + "\n"
                + "Maximum Score:" + maximumScore + "\n";
        }
    }
}
