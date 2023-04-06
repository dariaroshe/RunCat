using System;
using System.Collections;
using Game;
using UnityEngine;

namespace HealthBar
{
    public class MoveAdditionalHealthComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private GameObject _additionalHealth;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void FixedUpdate()
        {
            var speed = _gameModel.Speed;
            var gameState = _gameModel.GameState.Value;
            var additionalHealthPosition = _additionalHealth.transform.position;

            if (gameState == GameState.Playing)
            {
                var moveX = additionalHealthPosition.x - speed * Time.deltaTime;
                _additionalHealth.transform.position = new Vector3(moveX, additionalHealthPosition.y, additionalHealthPosition.z);
            }
        }
        
    }
}