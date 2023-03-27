using Game;
using UnityEngine;

namespace Popups
{
    public class PopupPauseComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Animator _pauseAnimator;
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

            if (gameState == GameState.Pause)
            {
                _pauseAnimator.SetBool(Show, true);
            }
            else
            {
                _pauseAnimator.SetBool(Show, false);
            }
        }
    }
}