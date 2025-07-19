using System.ComponentModel.DataAnnotations;

namespace FirstProject.Models;


public class GuestResponse
{
    [Required(ErrorMessage = "please enter your name")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Please enter your email address")]
    [EmailAddress]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Please enter your phone number")]
    public string? Phone { get; set; }

    [Required(ErrorMessage = "Please specify whether you will attend")]
    public bool? WillAttend { get; set; }

}




