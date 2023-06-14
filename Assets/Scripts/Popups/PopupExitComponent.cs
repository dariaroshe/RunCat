using Game;
using UnityEngine;

namespace Popups
{
    public class PopupExitComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Animator _exitAnimator;
        private static readonly int Show = Animator.StringToHash("Show");

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
            var gameState = _gameModel.GameState.Value;

            if (gameState == GameState.Exit)
            {
                _exitAnimator.SetBool(Show, true);
            }
            else
            {
                _exitAnimator.SetBool(Show, false);
            }
        }
    }
}