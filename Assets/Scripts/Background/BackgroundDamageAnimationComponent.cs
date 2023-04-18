using Game;
using UnityEngine;

namespace Background
{
    public class BackgroundDamageAnimationComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Animation _damageAnimation;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.Health.Changed += OnChangedHealth;
        }

        private void OnDestroy()
        {
            _gameModel.Health.Changed += OnChangedHealth;
        }

        private void OnChangedHealth(int old, int current)
        {
            if (current < old)
            {
                _damageAnimation.Play();
            }
        }
    }
}