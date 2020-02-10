using System;
using TestApplication.DataAccess;
using TestApplication.GameEngine;
using TestApplication.GameLogic;
using TestApplication.ViewHandler;

namespace TestApplication.StartupConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            IViewHandler view = new TextBaseViewHandler();
            IDataAccessHandler dataAccess = new TextFileDataAccessHandler();
            IGameLogicHandler gameLogic = new BaseGameLogicHandler(dataAccess);
            IGameEngineHandler engineHandler = new BasicGameLoopEngineHandler(view, gameLogic);
            engineHandler.RunGame();
        }
    }
}
