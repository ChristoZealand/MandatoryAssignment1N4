using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public FootballPlayer()
        {
                
        }

        public FootballPlayer(int id, string name, int age, int shirtNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;
        }

        public void ValidateName()
        {
            if (Name.Length < 2)
            {
                throw new ArgumentOutOfRangeException("Name has to be at least two characters!");
            }
        }

        public void ValidateAge()
        {
            if (Age < 1)
            {
                throw new ArgumentOutOfRangeException("Age has to be greater than 1!");
            }
        }

        public void ValidateShirtNumber()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99)
            {
                throw new ArgumentOutOfRangeException("Shirtnumber has to be between 1 and 99!");
            }
        }

        public void Validate()
        {
            ValidateName();
            ValidateAge();
            ValidateShirtNumber();
        }
        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Age)}={Age.ToString()}, {nameof(ShirtNumber)}={ShirtNumber.ToString()}}}";
        }
    }
}
