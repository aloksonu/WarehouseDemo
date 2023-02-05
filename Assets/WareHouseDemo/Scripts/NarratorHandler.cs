using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Utilities;

namespace Ui.Narrator
{
    public class NarratorHandler : MonoBehaviour
    {
        private static Action _onClickCrossButton , _onCompleteNarrator;
        [SerializeField] private CanvasGroup _canvasGroup;
        [SerializeField] private TextMeshProUGUI panelText;
        [SerializeField] private Image textContainerImage;
        [SerializeField] private Color[] randomColor;
        private string _narratorText;
        private float _fadeDuration = 0.4f;

        void Start()
        {
            BringOutNarrator(0f);
        }

        internal void BringInNarrator(string narratorText, float delay = 1f,
               Action onCompleteNarrator = null)
        {
            _narratorText = narratorText;
            panelText.text = _narratorText;
            int randomInt = UnityEngine.Random.Range(0, randomColor.Length);
            textContainerImage.color = randomColor[randomInt];
            _onCompleteNarrator = onCompleteNarrator;
            // _canvasGroup.DOFade(1f, delay);
            _canvasGroup.UpdateState(true, delay , BringOnNarratorComplete);
        }

        private void BringOnNarratorComplete()
        {
            if (_onCompleteNarrator != null)
            {
                _onCompleteNarrator();
                _onCompleteNarrator = null;
            }
        }

        internal void BringOutNarrator(float delay = 1f)
        {
            //_canvasGroup.DOFade(0f, delay);
            _canvasGroup.UpdateState(false, delay);
        }

    }
}
