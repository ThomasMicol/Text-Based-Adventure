using System;
using System.Collections.Generic;
using System.Text;
using TestApplication.GameLogic;
using TestApplication.ViewHandler;

namespace TestApplication.GameEngine
{
    public class BasicGameLoopEngineHandler : IGameEngineHandler
    {
        private readonly IGameLogicHandler _gameLogic;
        private readonly IViewHandler _viewHandler;
        public RunningCodeStatus RunningCode { get; private set; }


        public BasicGameLoopEngineHandler(IViewHandler view, IGameLogicHandler gameLogic)
        {
            _gameLogic = gameLogic;
            _viewHandler = view;
        }

        public void RunGame()
        {
            RunningCode = RunningCodeStatus.Running;

            while(RunningCode == RunningCodeStatus.Running)
            {
                Console.WriteLine("Is this runner running?");
            }
        }
    }
}
