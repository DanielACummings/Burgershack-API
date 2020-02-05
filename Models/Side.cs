using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace burgershackApi.Models
{
  public class Side
  {
    public int Id { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(50)]
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public bool KidSized { get; set; }


    public Side() { }
    public Side(string name, string description, float price, bool kidSized)
    {
      Name = name;
      Description = description;
      Price = price;
      KidSized = kidSized;
    }
  }
}