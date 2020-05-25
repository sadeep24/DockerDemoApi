using DockerDemoApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerDemoApi.Infrastructure.Repositories
{
    public interface IUnitOfWork
    {
        GenericRepocitory<Product> ProductRepository { get; }

        void Save();
    }
}
