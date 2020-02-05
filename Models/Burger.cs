using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace burgershackApi.Models
{
  public class Burger
  {
    public int Id { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(50)]
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }


    public Burger() { }
    public Burger(string name, string description, float price)
    {
      Name = name;
      Description = description;
      Price = price;
    }
  }
}