using UnityEngine;
using DG.Tweening;

namespace PracticeWithDOTween
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private Vector3 _endVolue;
        [SerializeField] private float _duration;
        [SerializeField] private int _repeat;
        [SerializeField] private LoopType _loopType;
        [SerializeField] private Ease _ease;

        private void Start()
        {
            Move();
        }

        private void Move()
        {
            transform
                .DOMove(_endVolue, _duration)
                .SetLoops(_repeat, _loopType)
                .SetEase(_ease);
        }
    }
}