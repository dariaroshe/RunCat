using System.Collections.Generic;
using UnityEngine;

namespace Shop.SelectCharacter.Skins
{
    [CreateAssetMenu(menuName = "Info/Skins")]
    public class SkinsCollectionInfo : ScriptableObject
    {
        public List<SkinInfo> Skins;
    }
}