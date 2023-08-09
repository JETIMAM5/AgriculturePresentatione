using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extension
    {
        public static void ContainerDependencies(this IServiceCollection Services) 
        {
            Services.AddScoped<IServiceService, ServiceManager>();
            Services.AddScoped<IServiceDal, EFServiceDal>();
            Services.AddScoped<ITeamService, TeamManager>();
            Services.AddScoped<ITeamDal, EFTeamDal>();
            Services.AddScoped<IAnnoncementService, AnnoncementManager>();
            Services.AddScoped<IAnnoncementDal, EFAnnoncementsDal>();
            Services.AddScoped<IImageService, ImageManager>();
            Services.AddScoped<IImageDal, EFImageDal>();
            Services.AddScoped<IAddresService, AddressManager>();
            Services.AddScoped<IAddressDal, EFAddressDal>();
            Services.AddScoped<IContactService, ContactManager>();
            Services.AddScoped<IContactDal, EFContactDal>();
            Services.AddScoped<ISocialMediaService, SocialMediaManager>();
            Services.AddScoped<ISocialMediaDal, EFSocialMediaDal>();
            Services.AddScoped<IAboutService, AboutManager>();
            Services.AddScoped<IAboutDal, EFAboutDal>();
            Services.AddScoped<IAdminService, AdminManager>();
            Services.AddScoped<IAdminDal, EFAdminDal>();
        }

    }
}
