using System;
using System.Collections.Generic;
using System.Text;
using TestApplication.GameLogic;

namespace TestApplication.GameEngine
{
    public class BasicGameLoopEngineHandler : IGameEngineHandler
    {
        private readonly IGameLogicHandler _gameLogic;
        public RunningCodeStatus RunningCode { get; private set; }


        public BasicGameLoopEngineHandler(IGameLogicHandler gameLogic)
        {
            _gameLogic = gameLogic;
        }

        public void RunGame()
        {
            while(RunningCode == RunningCodeStatus.Running)
            {

            }
        }
    }
}
