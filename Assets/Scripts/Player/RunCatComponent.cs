using Game;
using UnityEngine;

namespace Player
{
    public class RunCatComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public Animator Animator;
        private static readonly int IsMoving = Animator.StringToHash("IsMoving");

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Animator.SetBool(IsMoving, true);
            }
        }
    }
}