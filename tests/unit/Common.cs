using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;
using Moq;
using Cdc.Vocabulary.WebApi.Controllers;
using Cdc.Vocabulary.WebApi.Models;
using Cdc.Vocabulary.Services;
using Microsoft.EntityFrameworkCore;
using Cdc.Vocabulary.Entities;

namespace Cdc.Vocabulary.Tests
{
    public static class Common
    {
        public static ControllerFixture Fixture { get; } = new ControllerFixture();
    }
}