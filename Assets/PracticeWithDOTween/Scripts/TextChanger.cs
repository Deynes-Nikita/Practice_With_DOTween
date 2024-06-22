using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace PracticeWithDOTween
{
    public class TextChanger : MonoBehaviour
    {
        [SerializeField] private Text _text;
        [SerializeField] private float _duration;
        [SerializeField] private int _repeat;
        [SerializeField] private LoopType _loopType;

        private string _replacedText = "А может и не быть";
        private string _addedText = ", но всё может быть.";
        private string _overdoneText = "НО ЭТО СЕКРЕТ!!!";

        private void Start()
        {
            Sequence sequence = DOTween.Sequence();

            sequence.Append(_text.DOText(_replacedText, _duration).SetDelay(_duration));
            sequence.Append(_text.DOText(_addedText, _duration).SetRelative());
            sequence.Append(_text.DOText(_overdoneText, _duration, true, ScrambleMode.All));

            sequence.SetLoops(_repeat, _loopType);
        }
    }
}