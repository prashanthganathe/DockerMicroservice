using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using DockerMicroservice.Context;
using Microsoft.EntityFrameworkCore;
using DockerMicroservice.Repository.Interface;
using DockerMicroservice.Repository.Repositories;

namespace DockerMicroservice
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            ConfigureDB(services);
            services.AddScoped<IRepository, RepositoryBase>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            //SeedData.Initialize(app.ApplicationServices);
        }

        public void ConfigureDB(IServiceCollection services)
        {
            SqlServer(services);
            //InMemory(services);
        }

        public void SqlServer(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("DevConnectionString");
            #if !DEBUG
                connectionString = Configuration.GetConnectionString("ProdConnectionString");
            #endif
            services.AddDbContext<MicroServiceContext>(opt => opt.UseSqlServer(connectionString));
        }
        public void InMemory(IServiceCollection services)
        {
            services.AddDbContext<MicroServiceContext>(opt => opt.UseInMemoryDatabase("MicroServiceDB"));
        }

    }
}
