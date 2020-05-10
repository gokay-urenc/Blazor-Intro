﻿using System.Threading.Tasks;
using BlazorIntro.Models;

namespace BlazorIntro.Services
{
    public interface IApiService
   {
       Task<TodoItem[]> GetTodos();
   }
}