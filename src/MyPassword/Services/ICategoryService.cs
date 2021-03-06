﻿using MyPassword.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPassword.Services
{
    public interface ICategoryService
    {
        List<CategoryModel> Categories { get; }

        CategoryModel FindCategoryByKey(string key);

        CategoryModel GetDefaultCategory();
    }
}
