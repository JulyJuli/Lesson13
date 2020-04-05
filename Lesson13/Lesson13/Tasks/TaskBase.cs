using Lesson13.Utils;
using System;

namespace Lesson13.Tasks
{
    public abstract class TaskBase
    {
        private const int minPriority = 1;
        private const int maxPriority = 10;

        private const int minComplexity = 1;
        private const int maxComplexity = 5;

        private int _complexity = minComplexity;
        private int _estimate;
        public abstract TaskType Type { get; }
        public string Name { get; set; }

        private int _proirity = minPriority;

        public TaskBase(string name, int priority, int complexity, int estimate)
        {
            Name = name;
            Priority = priority;
            Complexity = complexity;
            Estimate = estimate;
        }


        public int Priority
        {
            get => _proirity;
            set
            {
                if (value >= maxPriority || value <= maxPriority)
                {
                    _proirity = value;
                }
                else
                {
                    Console.WriteLine($"Proirity has to be in range {minPriority} in {maxPriority}");
                }
            }
        }

        public int Complexity
        {
            get => _complexity;
            set
            {
                if (value >= minComplexity || value <= maxComplexity)
                {
                    _complexity = value;
                }
                else
                {
                    Console.WriteLine($"Proirity has to be in range {minComplexity} in {maxComplexity}");
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
                {
                    _estimate = value;
                }
            }
        }


        public int GetActualEstimate()
        {
            int updateEstimate = Estimate;
            switch (Complexity)
            {
                case 1:
                    break;
                case 2:
                    updateEstimate = UpdateEstimateWithDoFindComplexity(0.2);
                    break;
                case 3:
                    updateEstimate = UpdateEstimateWithDoFindComplexity(0.3);
                    break;
                case 4:
                    updateEstimate = UpdateEstimateWithDoFindComplexity(0.4);
                    break;
                case 5:
                    updateEstimate = UpdateEstimateWithDoFindComplexity(0.5);
                    break;
            }
            return updateEstimate;
        }

        private int UpdateEstimateWithDoFindComplexity(double coefficient)
        {
            return (int)(_estimate + _estimate * coefficient);
        }

        public override string ToString()
        {
            return $"Task name {Name}, Type {Type}, Complexity {Complexity}, Estimate {Estimate}";
        }
    }
}
