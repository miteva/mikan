using System;

namespace Mikan.DAL.Models
{
    public class Resource
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public MainResource MainResource { get; set; }

        public String Description { get; set; }

        public int Size { get; set; }

        public ResourceSubType ResourceSubType { get; set; }

        public int Year { get; set; }
       

    }
}
