﻿namespace UserApi.Dto
{
    public class UserDto
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        public int AddressId { get; set; }
        public string Role { get; set; }

    }
}
