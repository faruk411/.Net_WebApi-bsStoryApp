using Sevices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Service
{
    public interface IServiceManagerr
    {
        IBookService BookService { get; }
    }
}
