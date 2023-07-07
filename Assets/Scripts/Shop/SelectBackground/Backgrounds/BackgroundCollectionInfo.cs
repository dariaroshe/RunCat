using System.Collections.Generic;
using Shop.SelectCharacter.Skins;
using UnityEngine;

namespace Shop.SelectBackground.Backgrounds
{
    [CreateAssetMenu(menuName = "Info/Backgrounds")]
    public class BackgroundCollectionInfo : ScriptableObject
    {
        public List<BackgroundInfo> Backgrounds;
    }
}