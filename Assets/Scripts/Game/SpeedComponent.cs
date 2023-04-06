using System;
using UnityEngine;

namespace Game
{
    public class SpeedComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.Speed = _gameScene.StartSpeed;
        }

        private void Update()
        {
            var gameState = _gameModel.GameState;
            var acceleration = _gameScene.Acceleration;

            if (gameState.Value == GameState.Playing)
            {
                _gameModel.Speed = Mathf.Clamp(_gameModel.Speed + Time.deltaTime * acceleration, 0, _gameScene.MaxSpeed);
            }
        }
    }
}