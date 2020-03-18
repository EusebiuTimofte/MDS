﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ProiectMDS.Data;
using ProiectMDS.Repositories.AlbumRepository;
using ProiectMDS.Repositories.ArtistAlbumAlbumsRepository;
using ProiectMDS.Repositories.ArtistRepository;
using ProiectMDS.Repositories.ProviderRepository;
using ProiectMDS.Repositories.SongAlbumAlbumsRepository;
using ProiectMDS.Repositories.SongRepository;
using ProiectMDS.Repositories.StudioRepository;

namespace ProiectMDS
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<ProiectMDSContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ProiectMDSContext")));

            services.AddTransient<IArtistRepository, ArtistRepository>();
            services.AddTransient<IAlbumRepository, AlbumRepository>();
            services.AddTransient<IArtistAlbumsRepository, ArtistAlbumsRepository>();
            services.AddTransient<IProviderRepository, ProviderRepository>();
            services.AddTransient<ISongAlbumsRepository, SongAlbumsRepository>();
            services.AddTransient<ISongRepository, SongRepository>();
            services.AddTransient<IStudioRepository, StudioRepository>();

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
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
            app.UseMvc();
        }
    }
}
