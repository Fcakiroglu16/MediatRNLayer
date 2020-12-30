using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRNlayer.Domain.Command
{
    public abstract class CommandBase<TResult> : IRequest<TResult> where TResult : class
    {
    }
}