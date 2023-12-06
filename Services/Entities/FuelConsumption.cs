using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class FuelConsumption
    {
        public Guid Id { get; set; }
        public Guid AutoBaseId { get; set; }
        public FuelType Type { get; set; }
        public float Volume { get; set; }
        public float Price { get; set; }
        public OperationType OperationType { get; set; }
        //public Guid SupplierId { get; set; }
        //public Guid ClientId { get; set; }
        //public Guid EmployeeId { get; set; }
        //public Supplier Supplier { get; set; }
        //public Client Client { get; set; }
        //public Employee Employee { get; set; }
    }
}
