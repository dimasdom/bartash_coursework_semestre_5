using Core.DTO;
using Core.Entities;
using Core.Interfaces;
using Infrastracture.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Services
{
    public class AutoBaseService : IAutoBaseService
    {
        private readonly IAutoBaseRepository repository;

        public AutoBaseService(IAutoBaseRepository repository)
        {
            this.repository = repository;
        }

        public void CreateAutoBase(AutoBase autoBase)
        {
            repository.AddValue(autoBase);
        }

        public void DeleteAutoBase(Guid Id)
        {
            repository.RemoveValue(repository.GetValueById(Id));
        }

        public IEnumerable<AutoBase> GetAll()
        {
            return repository.GetAll();
        }

        public AutoBase GetAutoBase(Guid Id)
        {
            return repository.GetValueById(Id);
        }

        public void UpdateAutoBase(AutoBase autoBase)
        {
            repository.Update(autoBase);
        }

    }
}
