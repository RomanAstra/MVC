using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace MVCExample
{
    public sealed class Reference
    {

        private Canvas _canvas;
        private Button _restartButton;

        public Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                    _canvas = Object.FindObjectOfType<Canvas>();
                }
                return _canvas;
            }
        }

        public Button RestartButton
        {
            get
            {
                if (_restartButton == null)
                {
                    var gameObject = Resources.Load<Button>("UI/RestartButton");
                    _restartButton = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _restartButton;
            }
        }

    }

}