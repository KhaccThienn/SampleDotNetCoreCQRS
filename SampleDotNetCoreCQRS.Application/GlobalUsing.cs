global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using Microsoft.Extensions.DependencyInjection;

global using SampleDotNetCoreCQRS.Shared;
global using SampleDotNetCoreCQRS.Shared.Commands;
global using SampleDotNetCoreCQRS.Shared.Queries;

global using SampleDotNetCoreCQRS.Shared.Abstraction.Queries;
global using SampleDotNetCoreCQRS.Shared.Abstraction.Commands;
global using SampleDotNetCoreCQRS.Shared.Abstraction.Exceptions;

global using SampleDotNetCoreCQRS.Domain.Const;
global using SampleDotNetCoreCQRS.Domain.Entities;
global using SampleDotNetCoreCQRS.Domain.Events;
global using SampleDotNetCoreCQRS.Domain.Exceptions;
global using SampleDotNetCoreCQRS.Domain.Factories;
global using SampleDotNetCoreCQRS.Domain.Policies;
global using SampleDotNetCoreCQRS.Domain.Policies.Gender;
global using SampleDotNetCoreCQRS.Domain.Policies.Temperature;
global using SampleDotNetCoreCQRS.Domain.Policies.Universal;
global using SampleDotNetCoreCQRS.Domain.Repositories;
global using SampleDotNetCoreCQRS.Domain.ValueObjects;


global using SampleDotNetCoreCQRS.Application.Services;
global using SampleDotNetCoreCQRS.Application.Exceptions;
global using SampleDotNetCoreCQRS.Application.DTOs;
global using SampleDotNetCoreCQRS.Application.DTOs.External;