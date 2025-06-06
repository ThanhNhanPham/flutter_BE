﻿using Microsoft.EntityFrameworkCore;
using FoodOdering_BE.Model;

namespace FoodOdering_BE.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id, bool includeProducts = false)
        {
            if (includeProducts)
            {
                return await _context.Categories
                    .Include(c => c.Products) // Bao gồm sản phẩm
                    .FirstOrDefaultAsync(c => c.CategoryId == id);
            }

            return await _context.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }

}
