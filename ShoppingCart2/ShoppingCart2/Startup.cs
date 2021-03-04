using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ShoppingCart2.Middlewares;
using ShoppingCart2.Models;
using ShoppingCart2.OAuth;
using ShoppingCart2.Security.Authencation;

namespace ShoppingCart2
{
    public class Startup
    {
        ///readonly string allowSpecificOrigins = "_allowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var connection = @"Server=.\sqlexpress;Database=db_ShoppingCart;Trusted_Connection=true";
            services.AddDbContext<ShoppingCartContext>(
                options => options.UseSqlServer(connection));

            services.AddCors(options => options.AddPolicy("AllowAll",
                p => p.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()));

            services.AddAuthentication("Basic")
                .AddScheme<BasicAuthenticationOptions, BasicAuthenticationHandler>("Basic", null);

            services.AddTransient<IAuthenticationHandler, BasicAuthenticationHandler>();

            //services.AddIdentityServer()
            //        .AddInMemoryApiResources(Config.GetApiResources())
            //        .AddInMemoryClients(Config.GetClients())
            //        .AddProfileService<ProfileService>()
            //        .AddDeveloperSigningCredential();

            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme =
            //                               JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme =
            //                               JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(o =>
            //{
            //    o.Authority = "http://localhost:44354";
            //    o.Audience = "FlixOneStore.ReadAccess";
            //    o.RequireHttpsMetadata = false;
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            app.UseOptions();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("AllowAll");

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
