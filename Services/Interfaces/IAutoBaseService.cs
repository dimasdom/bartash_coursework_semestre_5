using Core.DTO;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAutoBaseService
    {
        public AutoBase GetAutoBase(Guid Id);
        public void DeleteAutoBase(Guid Id);
        public void UpdateAutoBase(AutoBase Supplier);
        public IEnumerable<AutoBase> GetAll();
        public void CreateAutoBase(AutoBase Supplier);
    }
}
