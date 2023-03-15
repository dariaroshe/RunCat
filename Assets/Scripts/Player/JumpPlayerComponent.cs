using Game;
using UnityEngine;

namespace Player
{
    public class JumpPlayerComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Rigidbody2D _rigidbody2D;
        [SerializeField] private float _force;
        
        private static readonly int Jump = Animator.StringToHash("Jump");

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void Update()
        {
            var playerAnimator = _gameScene.PlayerAnimator;
            var gameState = _gameModel.GameState;
            
            if (Input.GetKeyDown(KeyCode.Space) && gameState.Value == GameState.Playing && _rigidbody2D.velocity == Vector2.zero)
            {
                _rigidbody2D.velocity = Vector2.up * _force;
                playerAnimator.SetTrigger(Jump);
            }
        }
    }
}