﻿using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepostory<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Update(T model);
        bool Remove(T model);
        bool RemoveRange(T datas);
        Task<bool> RemoveAsync(string id);
        Task<int> SaveAsync();
    }
}
