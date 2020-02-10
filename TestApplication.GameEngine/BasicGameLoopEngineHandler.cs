using System;
using System.Collections.Generic;
using System.Text;
using TestApplication.GameLogic;

namespace TestApplication.GameEngine
{
    public class BasicGameLoopEngineHandler : IGameEngineHandler
    {
        private readonly IGameLogicHandler _gameLogic;

        public BasicGameLoopEngineHandler(IGameLogicHandler gameLogic)
        {
            _gameLogic = gameLogic;
        }

        public void RunGame()
        {
            throw new NotImplementedException();
        }
    }
}
