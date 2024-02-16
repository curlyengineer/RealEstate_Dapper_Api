﻿using Dapper;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        // Kategori oluşturma
        public async void CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (CategoryName,Categorystatus) values (@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categorystatus", true);
            using(var connection=_context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters); // ekleme güncelleme ve silme işlemi için ExecuteAsync
            }
        }

        // Listeleme işlemi
        public async Task<List<ResultCategoryDto>> GeAllCategoryAsync()
        {
            string query = "Select * From Category";
            using (var connection = _context.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
