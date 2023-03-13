using Barriers;
using UnityEngine;

namespace Game
{
    public class GameStarter : MonoBehaviour
    {
        public GameScene GameScene;

        private void Start()
        {
            var gameModel = new GameModel();

            GameScene.RunCatComponent.Initialize(gameModel, GameScene);
            GameScene.JumpCatComponent.Initialize(gameModel, GameScene);
            
            GameScene.MovePlatformComponent.Initialize(gameModel, GameScene);
            GameScene.TeleportPlatformComponent.Initialize(gameModel, GameScene);

            for (int i = 0; i < GameScene.MoveBarriersComponent.Length; i++)
            {
                GameScene.MoveBarriersComponent[i].Initialize(gameModel, GameScene);
            }
           
            GameScene.SpawnBarriersComponent.Initialize(gameModel, GameScene);
        }
    }
}