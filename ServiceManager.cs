using Presentation.Service;
using Repositories.Contracts;
using Sevices;
using Sevices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Extensions
{

    public class ServiceManager : IServiceManagerr
    {
        private readonly Lazy<IBookService> _bookService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _bookService = new Lazy<IBookService>(() => new BookManager(repositoryManager));
        }
        public IBookService BookService => _bookService.Value;

    }
}