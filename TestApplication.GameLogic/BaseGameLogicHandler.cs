using System;
using System.Collections.Generic;
using System.Text;
using TestApplication.DataAccess;
using TestApplication.ViewHandler;

namespace TestApplication.GameLogic
{
    public class BaseGameLogicHandler : IGameLogicHandler
    {
        private readonly IViewHandler _aView;
        private readonly IDataAccessHandler _dataAccess;

        public BaseGameLogicHandler(IViewHandler aView, IDataAccessHandler dataAccess)
        {
            _aView = aView;
            _dataAccess = dataAccess;
        }
    }
}
