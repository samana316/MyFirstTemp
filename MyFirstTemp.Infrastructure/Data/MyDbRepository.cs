using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstTemp.Core.Models;
using MyFirstTemp.Core.Repositories;

namespace MyFirstTemp.Infrastructure.Data
{
    public sealed class MyDbRepository : IMyRepository
    {
        private readonly ConnectionStringSettings settings;

        public MyDbRepository(
            ConnectionStringSettings settings)
        {
            if (ReferenceEquals(settings, null))
            {
                throw new ArgumentNullException("settings");
            }

            this.settings = settings;
        }

        public int Add(
            MyModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MyModel> Get()
        {
            throw new NotImplementedException();
        }

        public int Remove(
            int id)
        {
            throw new NotImplementedException();
        }

        public int Update(
            MyModel model)
        {
            throw new NotImplementedException();
        }
    }
}
