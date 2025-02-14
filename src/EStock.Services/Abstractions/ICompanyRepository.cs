﻿using EStock.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EStock.Services.Abstractions
{
    public interface ICompanyRepository
    {
        Task<int> InsertCompany(Company company);
        Task<int> DeleteCompany(Guid id);
        Task<List<Company>> GetAllCompany();
        Task<Company> GetCompanyById(Guid id);

    }
}
