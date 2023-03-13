using System;
using Game;
using UnityEngine;

namespace Player
{
    public class TriggerDeadPlayerComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            var gameState = _gameModel.GameState;
            
            if (other.TryGetComponent<RunPlayerComponent>(out var cat))
            {
                gameState.Value = GameState.GameOver;
            }
        }
    }
}