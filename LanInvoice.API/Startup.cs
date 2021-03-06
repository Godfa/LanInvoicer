﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanInvoice.API.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LanInvoice.API
{
  public class Startup
  {
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
      string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LanPartyInvoices;Trusted_Connection=True;";
      services.AddDbContext<LanPartyContext>(o => o.UseSqlServer(connectionString));
      services.AddLogging(logging =>
      {
        logging.AddConsole();
        logging.AddDebug();
      });


    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IHostingEnvironment env)
      {
        //loggingBuilder.AddConsole();

        if (env.IsDevelopment())
        {
          app.UseDeveloperExceptionPage();
        }
        else
        {
          app.UseExceptionHandler();
        }

        app.UseStatusCodePages();

        app.UseMvc();

        //app.Run(async (context) =>
        //{
        //    await context.Response.WriteAsync("Hello World!");
        //});
      }
    }
  }
