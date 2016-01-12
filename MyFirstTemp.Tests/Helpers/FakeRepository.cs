using System.Collections.Generic;
using System.Linq;
using MyFirstTemp.Core.Models;
using MyFirstTemp.Core.Repositories;

namespace MyFirstTemp.Tests.Helpers
{
    internal sealed class FakeRepository : IMyRepository
    {
        private readonly IDictionary<int, MyModel> internalHash = new SortedDictionary<int, MyModel>();

        public IEnumerable<MyModel> Get()
        {
            return this.internalHash.Values.ToArray();
        }

        public int Add(
            MyModel model)
        {
            var newId = 0;

            if (this.internalHash.Any())
            {
                newId = this.internalHash.Keys.Max();
            }

            newId++;
            var clone = new MyModel { Name = model.Name };
            this.internalHash.Add(newId, clone);

            return newId;
        }

        public int Remove(
            int id)
        {
            this.internalHash.Remove(id);

            return 1;
        }

        public int Update(
            MyModel model)
        {
            this.internalHash[model.Id] = model;

            return 1;
        }
    }
}
