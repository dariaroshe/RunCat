using Game;
using UnityEngine;

namespace Player
{
    public class RunPlayerComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Animator _animator;
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
                _animator.SetBool(IsMoving, true);
            }
        }
    }
}