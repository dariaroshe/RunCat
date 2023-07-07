using System;
using Player;
using UnityEngine;

namespace Shop.SelectBackground.Backgrounds
{
    [Serializable]
    public class BackgroundInfo
    {
        public Sprite Icon;
        public int Price;
        public Sprite[] BackgroundsSprite;
    }
}