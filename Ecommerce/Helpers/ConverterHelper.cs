using Ecommerce.Data.Entities;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public Category ToCategory(CategoryViewModel model, Guid imageId, bool isNew)
        {
            return new Category
            {
                Id = isNew ? 0 : model.Id,
                ImageId = imageId,
                Name = model.Name
            };
        }

        public CategoryViewModel ToCategoryViewModel(Category category)
        {
            return new CategoryViewModel
            {
                Id = category.Id,
                ImageId = category.ImageId,
                Name = category.Name
            };
        }
    }
}
