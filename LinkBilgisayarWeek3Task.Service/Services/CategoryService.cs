using LinkBilgisayarWeek3Task.Data.Entities;
using LinkBilgisayarWeek3Task.Data.Repositories;
using LinkBilgisayarWeek3Task.Data.UnitOfWork;
using LinkBilgisayarWeek3Task.Service.Dtos;
using LinkBilgisayarWeek3Task.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBilgisayarWeek3Task.Service.Services
{
    public class CategoryService
    {
        private readonly Repository<Category> _repository;
        private readonly UnitOfWork _unitOfWork;

        public CategoryService(Repository<Category> repository, UnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }


    }
}
