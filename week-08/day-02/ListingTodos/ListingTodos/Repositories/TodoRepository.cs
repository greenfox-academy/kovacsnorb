﻿using ListingTodos.Entities;
using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public List<Todo> GetTodo()
        {
            return TodoContext.Todos.ToList();
        }
    }
}
