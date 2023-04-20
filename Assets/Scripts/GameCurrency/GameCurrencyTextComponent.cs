using Game;
using TMPro;
using UnityEngine;

namespace GameCurrency
{
    public class GameCurrencyTextComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private TextMeshProUGUI _textPoints;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.GameCurrency.Changed += OnChangedValue;
        }

        private void OnDestroy()
        {
            _gameModel.GameCurrency.Changed -= OnChangedValue;
        }

        private void OnChangedValue()
        {
            var points = _gameModel.GameCurrency;

            _textPoints.text = points.Value.ToString();
        }
    }
}