using System;
using Game;
using UnityEngine;

namespace HealthBar
{
    public class AdditionalHealthBarAnimationComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Animator _animator;
        private static readonly int Show = Animator.StringToHash("Show");


        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void FixedUpdate()
        {
            var gameState = _gameModel.GameState.Value;

            if (gameState == GameState.Playing)
            {
                _animator.SetTrigger(Show);
            }
        }
    }
}