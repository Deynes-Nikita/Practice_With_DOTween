using UnityEngine;
using DG.Tweening;

namespace PracticeWithDOTween
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private Vector3 _endVolue;
        [SerializeField] private float _duration;
        [SerializeField] private int _repeat;
        [SerializeField] private LoopType _loopType;
        [SerializeField] private Ease _ease;

        private void Start()
        {
            Turn();
        }

        private void Turn()
        {
            transform
                .DORotate(_endVolue, _duration, RotateMode.WorldAxisAdd)
                .SetLoops(_repeat, _loopType)
                .SetEase(_ease);
        }
    }
}