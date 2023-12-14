using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Supplier
    {
        // Унікальний ідентифікатор постачальника
        public Guid Id { get; set; }

        // Назва постачальника
        public string Name { get; set; }

        // Опис постачальника
        public string Description { get; set; }

        // Дата створення запису про постачальника
        public DateTime CreationDate { get; set; }

        // Номер облікового номера постачальника (Tax Identification Number)
        public string TaxNum { get; set; }

        // Міжнародний банківський номер рахунку (IBAN)
        public string IBAN { get; set; }

        // Унікальний ідентифікатор автобази, до якої відноситься постачальник
        public Guid AutoBaseId { get; set; }
    }

}
