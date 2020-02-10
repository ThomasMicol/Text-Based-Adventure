using System;
using System.Collections.Generic;
using System.Text;
using TestApplication.DataAccess;
using TestApplication.ViewHandler;

namespace TestApplication.GameLogic
{
    public class BaseGameLogicHandler : IGameLogicHandler
    {
        private readonly IDataAccessHandler _dataAccess;

        public BaseGameLogicHandler(IDataAccessHandler dataAccess)
        {
            _dataAccess = dataAccess;
        }
    }
}
