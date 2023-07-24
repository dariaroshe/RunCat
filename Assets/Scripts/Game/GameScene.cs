using AccelerationPlayer;
using Background;
using Barriers;
using Buttons;
using GameCurrency;
using HealthBar;
using Player;
using Points;
using Popups;
using SaveGame;
using Shop.SelectBackground.Backgrounds;
using Shop.SelectCharacter.Skins;
using UnityEngine;

namespace Game
{
    public class GameScene : MonoBehaviour
    {
        public SkinsCollectionInfo SkinsCollectionInfo;
        public BackgroundCollectionInfo BackgroundCollectionInfo;

        public PlayerSpawnComponent PlayerSpawnComponent;
        
        public DeadPlayerComponent DeadPlayerComponent;

        public StartGameComponent StartGameComponent;
        public StartGameTextComponent StartGameTextComponent;

        public SpawnBarriersComponent SpawnBarriersComponent;

        public MoveBackgroundComponent[] MoveBackgroundComponent;
        public BackgroundDamageAnimationComponent BackgroundDamageAnimationComponent;

        public PopupGameOverAnimationComponent PopupGameOverAnimationComponent;
        public PopupPauseComponent PopupPauseComponent;
        public PopupExitComponent PopupExitComponent;

        public PlayingButtonComponent[] PlayingButtonComponent;
        public YesButtonGameOverComponent YesButtonGameOverComponent;
        public NoButtonGameOverComponent NoButtonGameOverComponent;
        public PauseButtonComponent PauseButtonComponent;
        public ContinueButtonPauseComponent ContinueButtonPauseComponent;
        public ExitButtonComponent ExitButtonComponent;
        public NoButtonExitComponent NoButtonExitComponent;
        public YesButtonExitComponent YesButtonExitComponent;

        public ImageHealthBarComponent ImageHealthBarComponent;
        public SpawnAdditionalHealthComponent SpawnAdditionalHealthComponent;

        public PointsComponent PointsComponent;
        public PointsTextComponent PointsTextComponent;

        public SpawnGameCurrencyComponent SpawnGameCurrencyComponent;
        public GameCurrencyTextComponent GameCurrencyTextComponent;

        public SpawnAccelerationComponent SpawnAccelerationComponent;

        public SpeedComponent SpeedComponent;

        public SavePointsComponent SavePointsComponent;
        public SaveGameCurrencyComponent SaveGameCurrencyComponent;

        public Transform[] Platforms;

        public GameObject[] Barriers;
        public GameObject[] Items;

        public SpriteRenderer[] Backgrounds;
        public ChangeBackgroundComponent ChangeBackgroundComponent;

        public SoundsComponent SoundsComponent;

        public float StartSpeed;
        public float MaxSpeed;
        public float Acceleration;

        public int StartHealth;

        public Vector3 PlayerPosition;
    }
}