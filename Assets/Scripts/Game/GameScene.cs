using Barriers;
using Platforms;
using Player;
using Points;
using UnityEngine;
using UnityEngine.UIElements;

namespace Game
{
    public class GameScene : MonoBehaviour
    {
        public StartGameComponent StartGameComponent;
        
        public RunPlayerComponent RunPlayerComponent;
        public JumpPlayerComponent JumpPlayerComponent;

        public MovePlatformComponent MovePlatformComponent;
        public TeleportPlatformComponent TeleportPlatformComponent;

        public MoveBarriersComponent[] MoveBarriersComponent;
        public SpawnBarriersComponent SpawnBarriersComponent;

        public PlayerDeadAnimationComponent PlayerDeadAnimationComponent;
        public PlayerJumpAnimationComponent PlayerJumpAnimationComponent;

        public PointsComponent PointsComponent;
        public PointsTextComponent PointsTextComponent;

        public SpeedComponent SpeedComponent;

        public Transform[] Platforms;
        public GameObject[] Barriers;

        public float StartSpeed;
        public float Acceleration;

        public Animator PlayerAnimator;
    }
}