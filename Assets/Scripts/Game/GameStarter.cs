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
            
            GameScene.StartGameComponent.Initialize(gameModel, GameScene);
            
            GameScene.RunPlayerComponent.Initialize(gameModel, GameScene);
            GameScene.JumpPlayerComponent.Initialize(gameModel, GameScene);
            
            GameScene.MovePlatformComponent.Initialize(gameModel, GameScene);
            GameScene.TeleportPlatformComponent.Initialize(gameModel, GameScene);

            for (int i = 0; i < GameScene.MoveBarriersComponent.Length; i++)
            {
                GameScene.MoveBarriersComponent[i].Initialize(gameModel, GameScene);
            }
           
            GameScene.SpawnBarriersComponent.Initialize(gameModel, GameScene);
            
            GameScene.PlayerDeadAnimationComponent.Initialize(gameModel, GameScene);
            GameScene.PlayerJumpAnimationComponent.Initialize(gameModel, GameScene);
            
            GameScene.PointsComponent.Initialize(gameModel, GameScene);
            GameScene.PointsTextComponent.Initialize(gameModel, GameScene);
            
            GameScene.SpeedComponent.Initialize(gameModel, GameScene);
        }
    }
}