using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SeeSharp.Eight {
    public interface IEmployee {
        public string Name { get; }
        public decimal Salary { get; }
        public string Id { get => $"{Name}[{this.GetHashCode()}]"; }
    }

    public class Person {
#nullable disable
        public string Name { get; }
        public Person(string name) => Name = name;

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
#nullable enable
        public Person(string first, string last) {
            FirstName = first;
            MiddleName = null;
            LastName = last;
        }
        public Person(string first, string middle, string last) {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }
    }

    public abstract class  Employee : Person, IEmployee {
        public Employee(string name, decimal salary) : base(name) => salary = salary;
        public decimal Salary { get; protected set; }
    }

    public class Professor : Employee, IEmployee {
        public string Topic { get; }
        public Professor(string name, decimal salary, string topic): base(name,salary) => Topic = topic;

        public void Deconstruct(out string name, out string topic) => (name, topic) = (Name, Topic);
        public string Id => $"{Name}[{Topic[..3]} ~ {Topic[^3..^0]}]";
    }

    public class Administrator : Employee {
        public string Department { get; }
        public Administrator(string name, decimal salary, string department) : base(name, salary) => Department = department;
    }

    public static class Service {
#nullable disable
        static Person[] people = null;
#nullable enable

        static Service() {
            people ??= new Person[] {
                new Professor("RedPlus", 1______000, "Computer Science"),
                new Administrator("Taeyo", 2_000, "ABC"),
                new Professor("Itist", 3_000, "Computer Science")
            };
        }

        public static IEnumerable<IEmployee> GetEmployees() {
            foreach(var person in people) {
                if(person is IEmployee employee) {
                    yield return employee;
                }
            }
        }

        public static async IAsyncEnumerable<IEmployee> GetEmployeesAsync() {
            foreach (var person in people) {
                await Task.Delay(500);
                if(person is IEmployee employee) yield return employee;
            }
        }
    }

    class Program {
        static async Task Main(string[] args) {
            static void Print(string message) => Console.WriteLine(message);

            foreach(var employee in Service.GetEmployees()) {
                Print($"name : {employee.Name}");
            }
            Print("-----------------------------------------------");
            foreach(var employee in Service.GetEmployees()) {
                if(employee is Administrator administrator && administrator.Department is "ABC") {
                    Print($"Administrator : {administrator}");
                }
            }
            Print("-----------------------------------------------");

            await foreach (var employee in Service.GetEmployeesAsync()) {
                if(employee is Professor(var name, "Computer Science") professor) {
                    Print($"Professor : {name} ({professor.Id})");
                }
            }

            var red = new Person("YJ", "Park");
            var length = GetMiddleNameLength(red);
            Console.WriteLine(length);
            Print("-----------------------------------------------");
            await foreach (var employee in Service.GetEmployeesAsync()) {
                Console.WriteLine(GetDetails(employee));
            }

            static string GetDetails(IEmployee person) {
                return person switch {
                    Professor p when p.Salary > 1_000 => $"{p.Name} - {p.Topic} - Big",
                    Professor p => $@"{p.Name} - {p.Topic}",
                    Administrator a => $"{a.Name} - {a.Department}",
                    _ => $@"Who ard you?"
                };
            }

            static int GetMiddleNameLength(Person? person) {
                if (person?.MiddleName is { } middle) return middle.Length; return 0;
            }

        }
    }


}