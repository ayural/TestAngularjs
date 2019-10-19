using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wappAngular.Models
{
    public class DataGenerator
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoContext(
                serviceProvider.GetRequiredService<DbContextOptions<TodoContext>>()))
            {
                // Look for any board games.
                if (context.TodoItems.Any())
                {
                    return;   // Data was already seeded
                }

                context.TodoItems.AddRange(
                    new TodoItem
                    {
                        Id = 1,
                        Name = "Benito",
                        IsComplete = true,
                    },
                    new TodoItem
                    {
                        Id = 2,
                        Name = "Ana",
                        IsComplete = true,
                    },
                    new TodoItem
                    {
                        Id = 3,
                        Name = "Juan",
                        IsComplete = true,
                    },
                    new TodoItem
                    {
                        Id = 4,
                        Name = "Jhon",
                        IsComplete = true,
                    },
                    new TodoItem
                    {
                        Id = 5,
                        Name = "Gloria",
                        IsComplete = true,
                    },
                    new TodoItem
                    {
                        Id = 6,
                        Name = "Hugo",
                        IsComplete = false,
                    });

                context.SaveChanges();
            }
        }
    }
}
