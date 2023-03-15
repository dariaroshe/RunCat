using Service;
using UnityEngine;

namespace Game
{
    public class GameModel
    {
        public readonly Field<GameState> GameState = new Field<GameState>();
        public readonly Field<int> Points = new Field<int>();

        public float Speed;
    }
}
