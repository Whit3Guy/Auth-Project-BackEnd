﻿namespace AuthApplication.DTOs
{
    public class UserStorageDto
    {
        public UserStorageDto(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
