using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class AutoBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime UpdatedDate { get; set;}
        public List<FuelConsumption> FuelConsumption { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
