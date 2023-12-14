using Core.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Employee
    {
        // Унікальний ідентифікатор працівника
        public Guid Id { get; set; }

        // Ім'я працівника
        public string Name { get; set; }

        // Прізвище працівника
        public string Surname { get; set; }

        // Дата створення запису про працівника
        public DateTime CreatedDate { get; set; }

        // Унікальний ідентифікатор автобази, до якої прив'язаний працівник
        public Guid AutoBaseId { get; set; }

        // Посада працівника (використовує перерахування PositionType)
        public PositionType Position { get; set; }
    }

}
