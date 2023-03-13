using Game;
using UnityEngine;

namespace Player
{
    public class JumpPlayerComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;
        
        private static readonly int Jump = Animator.StringToHash("Jump");

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void Update()
        {
            var playerAnimator = _gameScene.PlayerAnimator;
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerAnimator.SetTrigger(Jump);
            }
        }
    }
}