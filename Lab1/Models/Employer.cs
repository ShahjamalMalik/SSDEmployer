using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;


namespace Lab1.Models
{
    public class Employer
    {
        //Value is a unique identifier 
        [Key]
        public int Id { get; set; }
        //Name of the person 
        [Required]
        public string Name { get; set; }
        //Phone number of the person
        [Required, Phone, Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        //Website of the person
        [Required, Url]
        public string Website {  get; set; }
        //Incorporated Date (Honestly don't know what this is supposed to mean? I assumed it meant start date)
        [DataType(DataType.Date), Display(Name = "Incorporated Date")]
        public DateTime? IncorporatedDate { get; set; }
        
    }
}
