using Book_Store.Data;
using Book_Store.Data.Models;
using Microsoft.EntityFrameworkCore;
using my_books.Data.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace test_web_api
{
    public class PublishersServiceTest
    {
        private static DbContextOptions<AppDbContext> dbContextOptions = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "WepAPI-9")
            .Options;

        AppDbContext _context;
        PublishersService _publishersService;

        [OneTimeSetUp]
        public void Setup()
        {
            _context = new AppDbContext(dbContextOptions);
            _context.Database.EnsureCreated();

            SeedDatabase();

            _publishersService = new PublishersService(_context);
        }

        [Test, Order(1)]
        public void GetAllPublishers_WithNoSort_WithNoSerch_WithNoPageNumber_Test()
        {
            var result = _publishersService.GetAllPublishers("", "", null);

            Assert.That(result.Count, Is.EqualTo(6));
        }

        [Test, Order(2)]
        public void GetAllPublishers_WithSort_WithNoSerch_WithNoPageNumber_Test()
        {

        }


        [OneTimeTearDown]
        public void ClenUp()
        {
            _context.Database.EnsureDeleted();
        }

        private void SeedDatabase()
        {
            var publishers = new List<Publisher>
            {
                new Publisher()
                {
                    Id = 1,
                    Name = "Publisher 1"
                },
                new Publisher()
                {
                    Id = 2,
                    Name = "Publisher 2"
                },
                new Publisher()
                {
                    Id = 3,
                    Name = "Publisher 3"
                },
                new Publisher()
                {
                    Id = 4,
                    Name = "Publisher 4"
                },
                new Publisher()
                {
                    Id = 5,
                    Name = "Publisher 5"
                },
                new Publisher()
                {
                    Id = 6,
                    Name = "Publisher 6"
                },
                new Publisher()
                {
                    Id = 7,
                    Name = "Publisher 7"
                },
                new Publisher()
                {
                    Id = 8,
                    Name = "Publisher 8"
                },
                new Publisher()
                {
                    Id = 9,
                    Name = "Publisher 9"
                },
                new Publisher()
                {
                    Id = 10,
                    Name = "Publisher 10"
                },
            };
            _context.Publishers.AddRange(publishers);
            _context.SaveChanges();
        }



    }
}