using Autofac;
using MediatRNlayer.Domain.Repositories;
using MediatRNLayer.Data.Repositories;
using System;
using System.Collections.Generic;

using System.Text;

namespace MediatRNLayer.Service.Modules
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //  builder.RegisterType(typeof(Repository<>)).As(typeof(IRepository<>));
        }
    }
}