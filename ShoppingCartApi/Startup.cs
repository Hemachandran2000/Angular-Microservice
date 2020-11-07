using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ShoppingCartApi.AuthService;
using ShoppingCartDAL;
using ShoppingCartDAL.Interface;
using ShoppingCartDAL.Repositories;
using ShoppingCartDAL.UnitOfWork;
using ShoppingCartDTO;
using ShoppingCartEntity;
using ShoppingInfra;

namespace ShoppingCartApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("ShoppingCartConnection"))
            );           

            services.AddCors();
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IShoppingCart<Userdto>, Users>();
            services.AddScoped<IShoppingCart<Productsdto>, Products>();
            services.AddScoped<IShoppingCart<CategoryModel>, Category>();
            services.AddScoped<IShoppingCart<SubCategoryModel>, SubCategory>();
            services.AddScoped<IUnitWork, UnitWork>();
            services.AddControllers();
            //Calling Auth service lib using extension method
            services.AddTokenAuthentication(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials()
            );
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
