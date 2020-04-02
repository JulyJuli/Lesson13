﻿using Lesson13.Utils;
using System;
using System.Collections.Generic;
using System.Text;

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

        public TaskBase(string name, int priority, int complexity, int estimate)
        {
            Name = name;
            Priority = priority;
            Complexity = complexity;
            Estimate = estimate;
        }
        public abstract TaskTypes Type { get; }

        public string Name { get; set; }
        public int Priority
        {
            get => _priority;
            set
            {
                if(value>=minPriority || value<=maxPriority)
                {
                    _priority = value;
                }
                else
                {
                    Console.WriteLine($"Priority has to be if range from {minPriority} to {maxPriority}");
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
                    Console.WriteLine($"Priority has to be if range from {minComplexity} to {maxComplexity}");
                }
            }
        }
        public int Estimate
        {
            
            get=> _estimate;
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
            return $"Task Name: {Name}, Type: {Type}, Complexity: {Complexity}, Estimate: {Estimate} ";
        }

        public int GetActualEstimate()
        {
            int updatedEstimate = Estimate;
            switch (Complexity)
            {
                case 1:
                    break;
                case 2:
                    updatedEstimate = CountEstimateWithDefinedComplexity(0.2);
                    break;
                case 3:
                    updatedEstimate = CountEstimateWithDefinedComplexity(0.3);
                    break;
                case 4:
                    updatedEstimate = CountEstimateWithDefinedComplexity(0.4);
                    break;
                case 5:
                    updatedEstimate = CountEstimateWithDefinedComplexity(0.5);
                    break;
            }
            return updatedEstimate;

            }
        private int CountEstimateWithDefinedComplexity(double coefficient)
        {
            return (int)(Estimate + Estimate * coefficient);
        }
    }
}
