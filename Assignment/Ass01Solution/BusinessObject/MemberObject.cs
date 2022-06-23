using System;

namespace BusinessObject
{
    public class MemberObject
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        //default: admin@fstore.com
        public string Email { get; set; }
        //default: admin@@
        //Email, Password stored in the appsetting.json
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
