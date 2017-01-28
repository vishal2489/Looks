using System.Collections.Generic;

namespace Looks.Models {
    public class User: EntityBase {
        
        public long MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public List<RequestOrder> orders { get; set; }
    }
}
