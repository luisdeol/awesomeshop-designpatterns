using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeShopDesignPatterns.API.Application
{
    public interface ICommandHandler<T, U> where T: ICommand
    {
        U Handle(T command);
    }
}