using UnityEngine;

namespace Game
{
    public class StartGameComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return) && _gameModel.GameState.Value == GameState.Start)
            {
                _gameModel.GameState.Value = GameState.Playing;
            }
        }
    }
}