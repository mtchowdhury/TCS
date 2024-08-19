#!/bin/bash

# Update package list and install .NET SDK
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0

# Navigate to the project directory
cd /TCS.TariffComparator.Api

# Restore dependencies
dotnet restore

# Run the application
dotnet run