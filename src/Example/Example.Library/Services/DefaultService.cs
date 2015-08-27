using Example.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Library.Services
{
    public class DefaultService : IExampleService
    {
        public PageModel GetPage()
        {
            return new PageModel() { Title = "Hello from the service" };
        }
    }
}
