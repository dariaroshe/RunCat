using System;
using System.Collections;
using Game;
using UnityEngine;

namespace Player
{
    public class PlayerDamageAnimationComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private SpriteRenderer _sprite;

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
                StartCoroutine(ChangeColor());
            }
        }

        private IEnumerator ChangeColor()
        {
            _sprite.color = Color.red;
            
            yield return new WaitForSeconds(0.2f);
            
            _sprite.color = Color.white;
        }
    }
}