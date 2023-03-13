using Game;
using UnityEngine;

namespace Platforms
{
    public class MovePlatformComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void FixedUpdate()
        {
            var platforms = _gameScene.Platforms;
            var speed = _gameScene.SpeedPlatform;
            var gameState = _gameModel.GameState;
            
            if(gameState.Value == GameState.Playing)
            {
                for (int i = 0; i < platforms.Length; i++)
                {
                    var moveX = platforms[i].position.x - speed * Time.deltaTime;
                    platforms[i].position = new Vector3(moveX, platforms[i].position.y, platforms[i].position.z);
                }
            }
        }
    }
}