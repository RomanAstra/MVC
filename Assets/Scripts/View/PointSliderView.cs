using Model;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    [RequireComponent(typeof(Slider))]
    internal sealed class PointSliderView : MonoBehaviour, IPointView
    {
        private Slider _slider;

        private void Start()
        {
            _slider = GetComponent<Slider>();
        }

        public void UpdatePoint(IPointData pointData)
        {
            _slider.value = (float)pointData.CurrentPoint / 100;
        }
    }
}
