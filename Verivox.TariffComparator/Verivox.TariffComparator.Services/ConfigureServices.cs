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
using Verivox.TariffComparator.Models.DTOs.Request;
using Verivox.TariffComparator.Service.Contracts;
using Verivox.TariffComparator.Service.Factories;
using Verivox.TariffComparator.Service.Helpers;
using Verivox.TariffComparator.Service.Validator;

namespace Verivox.TariffComparator.Service;

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
