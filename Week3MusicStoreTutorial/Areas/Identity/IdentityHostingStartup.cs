﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Week3_MusicStoreTutorial.Models;
using Week3MusicStoreTutorial.Models;

[assembly: HostingStartup(typeof(Week3MusicStoreTutorial.Areas.Identity.IdentityHostingStartup))]
namespace Week3MusicStoreTutorial.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}