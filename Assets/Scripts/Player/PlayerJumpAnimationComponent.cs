using System;
using Game;
using UnityEngine;

namespace Player
{
    public class PlayerJumpAnimationComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Rigidbody2D _rigidbody2D;
        [SerializeField] private Animator _animator;
        
        private static readonly int JumpUp = Animator.StringToHash("JumpUp");
        private static readonly int JumpDown = Animator.StringToHash("JumpDown");
        private static readonly int IsGrounded = Animator.StringToHash("IsGrounded");


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
            if (_rigidbody2D.velocity.y > 0)
            {
                _animator.SetTrigger(JumpUp);
            }
            else if(_rigidbody2D.velocity.y < 0)
            {
                _animator.SetTrigger(JumpDown);
            }
            else if (_rigidbody2D.velocity.y == 0)
            {
                _animator.SetBool(IsGrounded, true);
            }
        }
    }
}