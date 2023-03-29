using System;
using Game;
using UnityEngine;

namespace Player
{
    public class RunPlayerComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        private static readonly int IsMoving = Animator.StringToHash("IsMoving");

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.GameState.Changed += OnGameStateChanged;
        }

        private void OnDestroy()
        {
            _gameModel.GameState.Changed -= OnGameStateChanged;
        }

        private void OnGameStateChanged()
        {
            var playerAnimator = _gameScene.PlayerAnimator;
            var gameState = _gameModel.GameState;
            
            if (gameState.Value == GameState.Playing)
            {
                playerAnimator.SetBool(IsMoving, true);
            }
            else
            {
                playerAnimator.SetBool(IsMoving, false);
            }
        }
    }
}