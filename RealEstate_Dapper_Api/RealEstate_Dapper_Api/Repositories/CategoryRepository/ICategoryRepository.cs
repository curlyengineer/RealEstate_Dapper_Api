﻿using RealEstate_Dapper_Api.Dtos.CategoryDtos;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepository
{
    public interface ICategoryRepository // imzalarımızı tutacak
    {
        Task<List<ResultCategoryDto>> GeAllCategoryAsync();
    }
}