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
        [SerializeField] private Animator _playerAnimator;
        
        private static readonly int JumpUp = Animator.StringToHash("JumpUp");
        private static readonly int JumpDown = Animator.StringToHash("JumpDown");
        private static readonly int IsGrounded = Animator.StringToHash("IsGrounded");
        
        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void Update()
        {
            var gameState = _gameModel.GameState;
            
            if (gameState.Value == GameState.Playing)
            {
                if (_rigidbody2D.velocity.y > 0.1f)
                {
                    _playerAnimator.SetTrigger(JumpUp);
                    _playerAnimator.SetBool(IsGrounded, false);
                }
                else if (_rigidbody2D.velocity.y < -0.1f)
                {
                    _playerAnimator.SetTrigger(JumpDown);
                    _playerAnimator.SetBool(IsGrounded, false);
                }
                else
                {
                    _playerAnimator.SetBool(IsGrounded, true);
                }
            }
        }
    }
}