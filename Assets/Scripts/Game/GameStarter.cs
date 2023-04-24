using Background;
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

            gameModel.Health.Value = GameScene.StartHealth;

            GameScene.StartGameComponent.Initialize(gameModel, GameScene);
            GameScene.StartGameTextComponent.Initialize(gameModel, GameScene);
            
            GameScene.RunPlayerComponent.Initialize(gameModel, GameScene);
            GameScene.JumpPlayerComponent.Initialize(gameModel, GameScene);
            GameScene.DeadPlayerComponent.Initialize(gameModel, GameScene);

            GameScene.SpawnBarriersComponent.Initialize(gameModel, GameScene);
            
            for (int i = 0; i < GameScene.MoveBackgroundComponent.Length; i++)
            {
                GameScene.MoveBackgroundComponent[i].Initialize(gameModel, GameScene);
            }
            
            GameScene.BackgroundDamageAnimationComponent.Initialize(gameModel, GameScene);
            
            GameScene.PlayerDeadAnimationComponent.Initialize(gameModel, GameScene);
            GameScene.PlayerJumpAnimationComponent.Initialize(gameModel, GameScene);
            GameScene.PlayerDamageAnimationComponent.Initialize(gameModel, GameScene);
            
            GameScene.PopupGameOverAnimationComponent.Initialize(gameModel, GameScene);
            GameScene.PopupPauseComponent.Initialize(gameModel, GameScene);

            for (int i = 0; i < GameScene.PlayingButtonComponent.Length; i++)
            {
                GameScene.PlayingButtonComponent[i].Initialize(gameModel, GameScene);
            }

            GameScene.YesButtonGameOverComponent.Initialize(gameModel, GameScene);
            GameScene.NoButtonGameOverComponent.Initialize(gameModel, GameScene);
            GameScene.PauseButtonComponent.Initialize(gameModel, GameScene);
            GameScene.ContinueButtonPauseComponent.Initialize(gameModel, GameScene);
            
            GameScene.ImageHealthBarComponent.Initialize(gameModel, GameScene);
            GameScene.SpawnAdditionalHealthComponent.Initialize(gameModel, GameScene);
            
            GameScene.PointsComponent.Initialize(gameModel, GameScene);
            GameScene.PointsTextComponent.Initialize(gameModel, GameScene);
            
            GameScene.SpawnGameCurrencyComponent.Initialize(gameModel, GameScene);
            GameScene.GameCurrencyTextComponent.Initialize(gameModel, GameScene);
            
            GameScene.SpeedComponent.Initialize(gameModel, GameScene);
        }
    }
}