using Game;
using TMPro;
using UnityEngine;

namespace Menu
{
    public class MaxPointsTextComponent : MenuComponent
    {
        private MenuModel _menuModel;
        private MenuScene _menuScene;

        [SerializeField] private TextMeshProUGUI _textMaxPoints;

        public override void Initialize(MenuModel menuModel, MenuScene menuScene)
        {
            _menuModel = menuModel;
            _menuScene = menuScene;

            _textMaxPoints.text = PlayerPrefs.GetInt("maxPoints").ToString();
        }
    }
}