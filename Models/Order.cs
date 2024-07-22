using System.ComponentModel.DataAnnotations;

namespace Homework3_Solution.Models;

public enum Country
{
    [Display(Name = "United States")]
    UnitedStates,
    [Display(Name = "North Korea")]
    NorthKorea,
    [Display(Name = "China")]
    China
}

public enum State
{
    Texas,
    California,
    [Display(Name = "New York")]
    NewYork
}

public class Order
{
    [Display(Name = "First Name")]
    public string FirstName {get; set;} = string.Empty;
    
    [Display(Name = "Last Name")]
    public string LastName {get; set;} = string.Empty;

    [EmailAddress]
    public string Email {get; set;} = string.Empty;
    public string Address { get; set; } = string.Empty;
    
    [Required]
    public Country? Country {get; set;}
    
    [Required]
    public State? State {get; set;}
    
    [RegularExpression(@"\d{5}$", ErrorMessage = "Invalid Zip Code")]
    public string Zip {get; set;} = string.Empty;

    [Display(Name = "Shipping address is the same as my billing address")]
    public bool SameShippingInfo {get; set;}

    [Display(Name = "Save this information for next time")]
    public bool SaveInformation {get; set;}
    
    public int PaymentType {get; set;}
    
    [Display(Name = "Name on card")]
    public string NameOnCard {get; set;} = string.Empty;
    
    [Display(Name = "Credit card number")]
    [CreditCard]
    public string CreditCardNumber {get; set;} = string.Empty;    
}