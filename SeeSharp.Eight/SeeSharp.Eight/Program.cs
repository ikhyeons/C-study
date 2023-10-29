using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeeSharp.Eight {
    public interface IEmployee {
        public string Name { get; }
        public decimal Salary { get; }
        public string Id { get => $"{Name}[{this.GetHashCode()}]"; }
    }
}