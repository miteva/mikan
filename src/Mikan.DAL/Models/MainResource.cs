using System;
using System.Collections.Generic;
using System.Text;

namespace Mikan.DAL.Models
{
  public class MainResource
  {
    public int Id { get; set; }

    public String Name { get; set; }

    public String Description { get; set; }

    public String kpNumber { get; set; }

    public int YearFrom { get; set; }

    public int yearTo { get; set; }

    public int Size { get; set; }
  }
}
