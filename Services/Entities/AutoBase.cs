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
        // Унікальний ідентифікатор автобази
        public Guid Id { get; set; }

        // Назва автобази
        public string Name { get; set; }

        // Опис автобази
        public string Description { get; set; }

        // Дата створення автобази
        public DateTime CreatedDate { get; set; }

        // Дата останнього оновлення автобази
        public DateTime UpdatedDate { get; set; }

        // Список об'єктів FuelConsumption, що відображають споживання пального
        public List<FuelConsumption> FuelConsumption { get; set; }

        // Список постачальників для даної автобази
        public List<Supplier> Suppliers { get; set; }

        // Список працівників, які пов'язані з автобазою
        public List<Employee> Employees { get; set; }
    }

}
