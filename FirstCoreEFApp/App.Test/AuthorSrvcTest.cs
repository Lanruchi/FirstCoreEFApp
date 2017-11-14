using App.Data;
using App.Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

namespace App.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class AuthorServiceTest
        {
            private Mock<IRepository<Author>> _authorRepository;

            [TestInitialize]
            public void Initialize()
            {
                _authorRepository = new Mock<IRepository<Author>>();
            }

            [TestMethod]
            public void InsertWasSuccesful()
            {
                //Author author = new Author
                //{
                //    FirstName = "Lanre",
                //    LastName = "Adeniyi",
                //    Email = "Olanre5@aol.com"
                //};


                //_authorRepository.Setup(m => m.Insert(author));

                IQueryable<Author> authors = _authorRepository.Object.GetAll();

                Assert.IsTrue(!authors.Any());
            }
        }
    }
}
