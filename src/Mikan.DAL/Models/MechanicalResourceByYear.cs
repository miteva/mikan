using System;
using System.Collections.Generic;
using System.Text;

namespace Mikan.DAL.Models
{
  public class MechanicalResourceByYear
  {
    public int Id { get; set; }

    public MechanicalResource MechanicalResource { get; set; }

    public int year { get; set; }

    public int amortization { get; set; }

    public int value { get; set; }

    public String description { get; set; }

  }
}
