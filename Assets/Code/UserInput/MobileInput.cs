using System;
using UnityEngine;

namespace MVCExample
{
    internal sealed class MobileInput : IUserInputProxy
    {
        public event Action<float> AxisOnChange;
        public void GetAxis()
        {
            Debug.Log("нажали кнопку!");
        }
    }
}
