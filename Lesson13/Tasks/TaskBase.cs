using System;
using System.Collections.Generic;
using System.Linq;
using Lesson13.Utils;

namespace Lesson13.Tasks
{
    public abstract class TaskBase
    {
        private const int minPriority = 1;
        private int maxPriority = 10;
        private int _priority = minPriority;
        
        private const int minComplexity = 1;
        private int maxComplexity = 5;
        private int _complexity = minComplexity;
        
        private int _estimate = 1;
        
        private readonly Dictionary<int, double> complexityPercents = new Dictionary<int, double>
        {
            {1, 0},
            {2, 0.2},
            {3, 0.3},
            {4, 0.4},
            {5, 0.5}
        };

        protected TaskBase(string name, int priority, int complexity, int estimate)
        {
            Name = name;
            Priority = priority;
            Complexity = complexity;
            Estimate = estimate;
        }

        public abstract TaskType Type { get; }
        
        public string Name { get; set; }
        
        public int Priority { 
            get => _priority;
            set
            {
                if (value >= minPriority || value <= maxPriority)
                {
                    _priority = value;
                }
                else
                {
                    Console.WriteLine($"Priority is invalid. Min = {minPriority}, Max = {maxPriority}.");
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
                    Console.WriteLine($"Complexity is invalid. Min = {minComplexity}, Max = {maxComplexity}.");
                }
            }
        }

        public int Estimate
        {
            get =>_estimate;
            set
            {
                if (value > 0)
                {
                    _estimate = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Task name = {Name}, type = {Type}, complexity = {Complexity}, estimate = {Estimate}";
        }

        public int UpdateEstimate()
        {
            var percent = complexityPercents
                .FirstOrDefault(complexityPercent => complexityPercent.Key == Complexity).Value;
            return (int) (_estimate + _estimate * percent);
        }
    }
}