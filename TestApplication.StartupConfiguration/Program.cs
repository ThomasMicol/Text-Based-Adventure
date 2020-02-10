using System;

namespace TestApplication.StartupConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            IViewHandler view = new TextBasedViewHandler();
            IGameLogicHandler gameLogic = new BaseGameLogicHandler();
            IGameEngineHandler engineHandler = new BasicGameLoopEngineHandler();
            IDataAccessHandler dataAccess = new TextFileDataAccessHandler();
        }
    }
}
