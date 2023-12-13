using System.ComponentModel.DataAnnotations;

public class Property
{
    [Key]
    public int? PropertyId { get; set; }

    [Required(ErrorMessage ="Property name is required")]
    public string? PropName { get; set; }

    [StringLength(maximumLength:20,MinimumLength =8,ErrorMessage ="Address must be less than 20 charaters")]
    public string? Address { get; set; }

    [Range(0,15,ErrorMessage ="Property age should be between 0 - 15 ")]
    public int? Age{ get; set; }
    public int? Price{ get; set; }
    public string? ConsultantName {get;set;}

    [EmailAddress(ErrorMessage ="Invalid email id")]
    public string? ContactMail {get;set;}

}