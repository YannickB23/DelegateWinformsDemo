using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateWinformsDemo.Models
{
    public class People
    {
        public static IList<Person> GetPeople()
        {
            var p = new List<Person>()
            {
                new Person() { FirstName = "Kenan", LastName = "Kurda", Age = 50, StartDate = DateTime.Parse("17/10/2008") },
                new Person() { FirstName = "Saif", LastName = "El Adilee", Age = 25, StartDate = DateTime.Parse("13/10/2010") },
                new Person() { FirstName = "Jarno", LastName = "Maes", Age = 21, StartDate = DateTime.Parse("01/05/2020") },
                new Person() { FirstName = "Yannick", LastName = "Beterams", Age = 31, StartDate = DateTime.Parse("25/07/2015") },
                new Person() { FirstName = "Khadija", LastName = "Sadki", Age = 28, StartDate = DateTime.Parse("17/05/2015") },
                new Person() { FirstName = "Emre", LastName = "Elagöz", Age = 26, StartDate = DateTime.Parse("28/10/2012") },
                new Person() { FirstName = "Timothy", LastName = "Hsu", Age = 24, StartDate = DateTime.Parse("22/10/2020") },
                new Person() { FirstName = "Mohammed", LastName = "Hebili", Age = 28, StartDate = DateTime.Parse("17/01/2021") }
            };
            return p;
        }
    }
}
