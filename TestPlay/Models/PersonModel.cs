using System.ComponentModel.DataAnnotations;

public class PersonModel {
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public string phone { get; set; }
}