﻿using System;
using System.Collections.Generic;
using System.Configuration;
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
            throw new NotImplementedException("Don't want this code.");
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
