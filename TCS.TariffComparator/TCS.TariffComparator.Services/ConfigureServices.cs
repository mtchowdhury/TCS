using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TCS.TariffComparator.Models.DTOs.Request;
using TCS.TariffComparator.Service.Contracts;
using TCS.TariffComparator.Service.Factories;
using TCS.TariffComparator.Service.Helpers;
using TCS.TariffComparator.Service.Validator;

namespace TCS.TariffComparator.Service;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddControllers().AddFluentValidation(v => v.RegisterValidatorsFromAssemblyContaining<TariffValidator>());
        #region BusinessServices
        _ = services.AddScoped<ITariffTypeFactory, TariffTypeFactory>();
        _ = services.AddScoped<ITariffComparator, Services.TariffComparator>();
        _ = services.AddScoped<ITariffProvider, TariffProvider>();

        #endregion
        return services;
    }
}
