using MB.SimTaxiPro.Utils.Enums;

namespace MB.SimTaxiPro.Entities
{
    public class Driver
    {
        public Driver()
        {
            Cars = new List<Car>();    
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        public List<Car> Cars { get; set; }
    }
}
