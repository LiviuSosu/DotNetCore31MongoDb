using DotNetCore31MongoDb.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore31MongoDb.Services
{
    public class BookService
    {
        private readonly IMongoCollection<object> _books;

        public BookService(IBookstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _books = database.GetCollection<object>("users");
        }

        public List<Object> Get() =>
            _books.Find(book => true).ToList();

        //public Book Get(string id) =>
        //    _books.Find<Book>(book => book.Id == id).FirstOrDefault();

        //public Book Create(Book book)
        //{
        //    _books.InsertOne(book);
        //    return book;
        //}

        //public void Update(string id, Book bookIn) =>
        //    _books.ReplaceOne(book => book.Id == id, bookIn);

        //public void Remove(Book bookIn) =>
        //    _books.DeleteOne(book => book.Id == bookIn.Id);

        //public void Remove(string id) =>
        //    _books.DeleteOne(book => book.Id == id);
    }
}
