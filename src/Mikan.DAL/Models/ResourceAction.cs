using System;
using System.Collections.Generic;
using System.Text;

namespace Mikan.DAL.Models
{
  public class ResourceAction

  {
    public int Id { get; set; }

    public AgricultureAction Action { get; set; }
    public String Description { get; set; }
    public DateTime Date { get; set; }
    public int Expenses { get; set; }
    public int Revenue { get; set; }
    public int Produced { get; set; }
    public int Sold { get; set; }
    public Resource Resource { get; set; }
  }
}
