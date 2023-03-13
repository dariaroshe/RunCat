using Game;
using UnityEngine;

namespace Player
{
    public class JumpCatComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public Animator Animator;
        private static readonly int Jump = Animator.StringToHash("Jump");

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Animator.SetTrigger(Jump);
            }
        }
    }
}