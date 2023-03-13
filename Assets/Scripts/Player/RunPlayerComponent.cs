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
        }
        
        private void Update()
        {
            var playerAnimator = _gameScene.PlayerAnimator;
            
            if (Input.GetKeyDown(KeyCode.Return))
            {
                playerAnimator.SetBool(IsMoving, true);
            }
        }
    }
}