using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.UL.Core.Common;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;
using Tahaluf.UL.Core.Repository;

namespace Tahaluf.UL.Infra.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly IDbContext _dbContext;
        public BookRepository(IDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public List<Bookul> GetAllBooks()
        {
            var books = _dbContext.Connection.Query<Bookul>("BOOKUL_PACKAGE.GETALLBOOKS", commandType: CommandType.StoredProcedure);
            return books.ToList();
        }
        public List<Bookul> GetNewestBooks()
        {
            var books = _dbContext.Connection.Query<Bookul>("BOOKUL_PACKAGE.GETLASTBOOKS", commandType: CommandType.StoredProcedure);
            return books.ToList();
        }

        public List<Bookul> GetAvailableBook()
        {
            var books = _dbContext.Connection.Query<Bookul>("BOOKUL_PACKAGE.getavailablebook", commandType: CommandType.StoredProcedure);
            return books.ToList();
        }
        public List<Category> GetCategories()
        {
            var books = _dbContext.Connection.Query<Category>("BOOKUL_PACKAGE.getcategories", commandType: CommandType.StoredProcedure);
            return books.ToList();
        }
        public bool CreateNewBook(Bookul book)
        {
            var p = new DynamicParameters();
            p.Add("NAME", book.Book_Name.ToLower(), dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("AUTH", book.Author, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("P", book.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("DESCRIPTION", book.Overview.ToLower(), dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Q", book.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("PHOTO", book.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("FILE", book.Pdf, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CATE", book.Category.ToLower(), dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LIB_ID", book.Library_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var newBook = _dbContext.Connection.ExecuteAsync("BOOKUL_PACKAGE.CREATEBOOK", p,commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateBook(Bookul book)
        {
            var p = new DynamicParameters();
            p.Add("BOOK_ID", book.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("NAME", book.Book_Name.ToLower(), dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("AUTH", book.Author, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("P", book.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("DESCRIPTION", book.Overview.ToLower(), dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Q", book.Quantity, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("FILE", book.Pdf, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PHOTO", book.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CATE", book.Category.ToLower(), dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LIB_ID", book.Library_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var updateBook = _dbContext.Connection.ExecuteAsync("BOOKUL_PACKAGE.UPDATEBOOK", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteBook(int id)
        {
            var p = new DynamicParameters();
            p.Add("BOOK_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var deleteBook = _dbContext.Connection.ExecuteAsync("BOOKUL_PACKAGE.DELETEBOOK", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Bookul> SearchBook(string name)
        {
            var p = new DynamicParameters();
            p.Add("name", name.ToLower(), dbType: DbType.String, direction: ParameterDirection.Input);
            var books = _dbContext.Connection.Query<Bookul>("BOOKUL_PACKAGE.searchbook", p, commandType: CommandType.StoredProcedure);
            return books.ToList();
        }
        public Bookul GetBookById(int id) 
        {
            var p = new DynamicParameters();
            p.Add("Bookid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var books = _dbContext.Connection.QueryFirstOrDefault<Bookul>("BOOKUL_PACKAGE.GetBookById", p, commandType: CommandType.StoredProcedure);
            return books;
        }
        public List<Bookul> GetAllBooksByLibrary(string name)
        {
            var p = new DynamicParameters();
            p.Add("lib_name", name, dbType: DbType.String, direction: ParameterDirection.Input);
            var books = _dbContext.Connection.Query<Bookul>("BOOKUL_PACKAGE.GETALLBOOKSBYLIBRARY", p, commandType: CommandType.StoredProcedure);
            return books.ToList();
        }
        public bool UpdateBookSold(int id)
        { 
            var p = new DynamicParameters();
            p.Add("BOOK_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var updateBook = _dbContext.Connection.ExecuteAsync("BOOKUL_PACKAGE.UPDATEBOOKSOLD", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Bookul> GetBestBooks()
        {
            var books = _dbContext.Connection.Query<Bookul>("BOOKUL_PACKAGE.getbestbooks", commandType: CommandType.StoredProcedure);
            return books.ToList();
        }
         
        public bool ChangeBookDiscount(float discount)
        {
            var p = new DynamicParameters();
            p.Add("dis", discount, dbType: DbType.Double, direction: ParameterDirection.Input);
            _dbContext.Connection.ExecuteAsync("BOOKUL_PACKAGE.changediscount", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
