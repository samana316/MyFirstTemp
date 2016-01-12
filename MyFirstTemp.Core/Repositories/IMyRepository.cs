using System.Collections.Generic;
using MyFirstTemp.Core.Models;

namespace MyFirstTemp.Core.Repositories
{
    public interface IMyRepository
    {
        IEnumerable<MyModel> Get();

        int Add(MyModel model);

        int Update(MyModel model);

        int Remove(int id);
    }
}
