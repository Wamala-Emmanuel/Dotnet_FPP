using System.ComponentModel.DataAnnotations;

namespace RestAPICoreDemo.Model
{
    
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}