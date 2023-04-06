using Background;
using Barriers;
using Buttons;
using HealthBar;
using Player;
using Points;
using Popups;
using UnityEngine;
using UnityEngine.UIElements;

namespace Game
{
    public class GameScene : MonoBehaviour
    {
        public StartGameComponent StartGameComponent;
        public StartGameTextComponent StartGameTextComponent;
        
        public RunPlayerComponent RunPlayerComponent;
        public JumpPlayerComponent JumpPlayerComponent;
        public DeadPlayerComponent DeadPlayerComponent;
        
        public SpawnBarriersComponent SpawnBarriersComponent;

        public MoveBackgroundComponent[] MoveBackgroundComponent;

        public PlayerDeadAnimationComponent PlayerDeadAnimationComponent;
        public PlayerJumpAnimationComponent PlayerJumpAnimationComponent;

        public PopupGameOverAnimationComponent PopupGameOverAnimationComponent;
        public PopupPauseComponent PopupPauseComponent;

        public PlayingButtonComponent[] PlayingButtonComponent;
        public YesButtonGameOverComponent YesButtonGameOverComponent;
        public NoButtonGameOverComponent NoButtonGameOverComponent;
        public PauseButtonComponent PauseButtonComponent;
        public ContinueButtonPauseComponent ContinueButtonPauseComponent;

        public ImageHealthBarComponent ImageHealthBarComponent;
        public SpawnAdditionalHealthComponent SpawnAdditionalHealthComponent;

        public PointsComponent PointsComponent;
        public PointsTextComponent PointsTextComponent;

        public SpeedComponent SpeedComponent;

        public Transform[] Platforms;

        public GameObject[] Barriers;
        public GameObject[] Items;

        public float StartSpeed;
        public float MaxSpeed;
        public float Acceleration;

        public int StartHealth;

        public Animator PlayerAnimator;
    }
}