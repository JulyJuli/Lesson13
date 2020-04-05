using Lesson13.Utills;
using System;

namespace Lesson13.Tasks
{
    public abstract class TaskBase
    {
        private const int minPriority = 1;
        private int maxPriority = 10;
        private const int minComplexity = 5;
        private int maxComplexity = 10;
        private int _complexity = minComplexity;
        private int _priority = minPriority;
        private int _estimate;//оценка

        public TaskBase(string name, int priority, int complexity, int estimate)
        {
            Name = name;
            Priority = priority;
            Complexity = complexity;
            Estimate = estimate;
        }

        public abstract TaskTypes Type { get;}
        public string Name { get; set; }
        public int Priority//приоритет
        {
            get => _priority;
            set
            {
                if(value>=minPriority||value<=maxPriority)
                {
                    _priority = value;
                }
                else
                {
                    System.Console.WriteLine($"Priority has to be in range from {minPriority} to {maxPriority}");
                }
            }
        }

        public int Complexity//сложность
        {
            get => _complexity;
            set
            {
                if (value >= minComplexity||value <= maxComplexity  )
                {
                    _complexity = value;
                }
                else
                {
                    Console.WriteLine($"Priority has to be in range from {minComplexity} to {maxComplexity}");
                }
            }
        }

        public int Estimate
        {            
            get
            {               
                return _estimate;
            }                
            set
            {
                if (value > 0)
                    _estimate = value;
            }
        }
        public override string ToString()
        {
            return $"Task Name: {Name}, Type: {Type}, Complexity: {Complexity}, Estimate: {Estimate}";
        }
             
        public int UpdateEstimate()
        {
            int updateEstimate = Estimate;
            switch (Complexity)
            {
                case 1:
                    break;
                case 2:
                   updateEstimate= CountEstimateWithDefinedComplexity(0.2); 
                    break;
                case 3:
                    updateEstimate = CountEstimateWithDefinedComplexity(0.3);
                    break;
                case 4:
                    updateEstimate = CountEstimateWithDefinedComplexity(0.4);
                    break;
                case 5:
                    updateEstimate = CountEstimateWithDefinedComplexity(0.5);
                    break;                    
            }
            return updateEstimate;
        }

        private int CountEstimateWithDefinedComplexity(double coefficient)
        {
            return (int)(_estimate + _estimate * coefficient);
        }
    }
}
