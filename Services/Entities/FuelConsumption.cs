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
        // Унікальний ідентифікатор споживання пального
        public Guid Id { get; set; }

        // Унікальний ідентифікатор автобази, до якої відноситься споживання пального
        public Guid AutoBaseId { get; set; }

        // Тип пального (використовує перерахування FuelType)
        public FuelType Type { get; set; }

        // Об'єм спожитого пального
        public float Volume { get; set; }

        // Вартість спожитого пального
        public float Price { get; set; }

        // Тип операції (використовує перерахування OperationType)
        public OperationType OperationType { get; set; }
    }
}
