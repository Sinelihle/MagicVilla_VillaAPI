﻿namespace MagicVilla_VillaAPI.Models.Dto
{
    public class LoginResponseDto
    {
        //public LocalUser User { get; set; }
        public UserDto User { get; set; }

        public string Role { get; set; }

        public string Token { get; set; }
    }
}
