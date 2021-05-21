using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cardata_api_v3.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string RegistrationId { get; set; }
        public Nullable<int> RankPoints { get; set; }
        public Nullable<long> CarOption1 { get; set; }
        public Nullable<long> CarOption2 { get; set; }
        public Nullable<long> CarOption3 { get; set; }
        public Nullable<long> AssignedCar { get; set; }
    }



}
