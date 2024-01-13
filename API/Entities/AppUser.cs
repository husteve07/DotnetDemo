﻿using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class AppUser
{
    public string UserName { get; set;}

    [Required]
    public int Id { get; set; }

    public byte[] PasswordHash{get; set;}

    public byte[] PasswordSalt{get; set;}

}
