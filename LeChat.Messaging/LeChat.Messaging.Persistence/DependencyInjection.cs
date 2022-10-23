﻿using LeChat.Messaging.Application.Interfaces;
using LeChat.Messaging.Persistence.Contexts;
using LeChat.Messaging.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LeChat.Messaging.Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ChatClientMessageDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ChatClientMessageDbContext).Assembly.FullName)));

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IChatClientMessageDbContext, ChatClientMessageDbContext>();
        }
    }
}
