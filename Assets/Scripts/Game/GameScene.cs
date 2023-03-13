using Barriers;
using Platforms;
using Player;
using UnityEngine;

namespace Game
{
    public class GameScene : MonoBehaviour
    {
        public RunCatComponent RunCatComponent;
        public JumpCatComponent JumpCatComponent;

        public MovePlatformComponent MovePlatformComponent;
        public TeleportPlatformComponent TeleportPlatformComponent;

        public MoveBarriersComponent[] MoveBarriersComponent;
        public SpawnBarriersComponent SpawnBarriersComponent;

        public Transform[] Platforms;
        public GameObject[] Barriers;

        public float SpeedPlatform;
        public float SpeedBarrier;
    }
}