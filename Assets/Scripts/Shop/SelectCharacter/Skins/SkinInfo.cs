using System;
using Player;
using UnityEngine;

namespace Shop.SelectCharacter.Skins
{
    [Serializable]
    public class SkinInfo
    {
        public Sprite Icon;
        public int Price;
        public PlayerComponent Prefab;
    }
}