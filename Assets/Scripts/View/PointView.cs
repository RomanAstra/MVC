using Model;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    [RequireComponent(typeof(Text))]
    internal sealed class PointView : MonoBehaviour, IPointView
    {
        private Text _text;

        private void Start()
        {
            _text = GetComponent<Text>();
        }

        public void UpdatePoint(IPointData pointData)
        {
            _text.text = pointData.CurrentPoint.ToString();
        }
    }
}
