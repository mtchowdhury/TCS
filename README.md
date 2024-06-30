# TCS
## Tariff Comparator Service

Simple Tariff Comparison System using Web API .NET 8 framework. It uses simple factory pattern and dependency injection. 
"TariffList.json" from root directory, used as a mock data source for external tariff details. Unit testing added with Xunit. 

## Project structure
* ***TariffComparator.Api***: Main Web API application
* ***TariffComparator.Services***: REST API communication service
* ***TariffComparator.Models***: Resides data passing models between api and service.
* ***TariffComparator.Test***: Unit test project.


## External Packages/Libaries used:
* FluentValidation.AspNetCore
* Swashbuckle.AspNetCore
* Microsoft.Extensions.DependencyInjection

## Available Functionalities
* Fetch electricity tariff plans from external proivder
* Compare tariff plan costs for total annual consumption kwh

## Notes
* A bash script is provided in the root to quickly install all requirements and run it on Linux
