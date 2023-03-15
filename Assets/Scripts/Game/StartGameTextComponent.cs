using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace Game
{
    public class StartGameTextComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private TextMeshProUGUI _textCountdown;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.Countdown.Changed += OnChangedCountdown;

            _textCountdown.text = _gameModel.Countdown.Value.ToString();
        }

        private void OnDestroy()
        {
            _gameModel.Countdown.Changed -= OnChangedCountdown;
        }

        private void OnChangedCountdown()
        {
            var countdown = _gameModel.Countdown.Value;

            if (countdown == 0)
            {
                _textCountdown.text = "RUN!";
                StartCoroutine(DisableText());
            }
            else
            {
                _textCountdown.text = countdown.ToString();
            }
        }

        private IEnumerator DisableText()
        {
            yield return new WaitForSeconds(1);
            _textCountdown.gameObject.SetActive(false);
        }
    }
}