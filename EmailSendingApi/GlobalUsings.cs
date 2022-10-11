// Global using directives

global using System;
global using System.Net;
global using System.Net.Mail;
global using System.Text.Json.Serialization;
global using EmailSendingApi.Data;
global using EmailSendingApi.Mediatr.Commands;
global using EmailSendingApi.Mediatr.Queries;
global using EmailSendingApi.Middlewares;
global using EmailSendingApi.Models;
global using EmailSendingApi.Models.ResponseModels;
global using EmailSendingApi.Services;
global using EmailSendingApi.Services.Interfaces;
global using MediatR;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Migrations;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.OpenApi.Models;
global using Swashbuckle.AspNetCore.SwaggerGen;