using UnityEngine;
using DG.Tweening;

namespace PracticeWithDOTween
{
    public class ColorChanger : MonoBehaviour
    {
        [SerializeField] private Renderer _renderer;
        [SerializeField] private float _duration;

        private Color _lastColor;
        private Tweener _tweener;


        private void Start()
        {
            Color color = GetColor();
            _tweener = _renderer.material.DOColor(color, _duration).SetAutoKill(false);
            _lastColor = color;

        }

        private void FixedUpdate()
        {
            if (_lastColor == _renderer.material.color)
            {
                Color color = GetColor();
                _tweener.ChangeEndValue(color, true).Restart();
                _lastColor = color;
            }
        }

        private Color GetColor()
        {
            return new Color(Random.value, Random.value, Random.value);
        }
    }
}