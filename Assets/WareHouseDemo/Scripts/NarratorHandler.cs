using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Utilities;
using Audio.Warehouse;

namespace Ui.Narrator
{
    public class NarratorHandler : MonoBehaviour
    {
        private static Action _onClickCrossButton , _onCompleteNarrator;
        private CanvasGroup _canvasGroup;
        [SerializeField] private CanvasGroup _canvasGroupA;
        [SerializeField] private CanvasGroup _canvasGroupB;
        private TextMeshProUGUI panelText;
        [SerializeField] private TextMeshProUGUI panelTextA;
        [SerializeField] private TextMeshProUGUI panelTextB;
        private Image textContainerImage;
        [SerializeField] private Image textContainerImagA;
        [SerializeField] private Image textContainerImagB;
        [SerializeField] private Color[] randomColor;
        private string _narratorText;
        private NarratorName _narratorName;
        private float _fadeDuration = 0.4f;
        private const float narratorOutDelay = 0.2f;
        private const float audioFinishDelay = 0.5f;

        void Start()
        {
            _canvasGroupA.UpdateState(false, 0);
            _canvasGroupB.UpdateState(false, 0);
        }

        internal void BringInNarrator(string narratorText,NarratorName narratorName= NarratorName.NotSet, float delay = 1f,
               Action onCompleteNarrator = null)
        {
            _narratorName = narratorName;
            if (narratorName == NarratorName.A)
            {
                _canvasGroup = _canvasGroupA;
                panelText = panelTextA;
                textContainerImage = textContainerImagA;
            }
            else if (narratorName == NarratorName.B)
            {
                _canvasGroup = _canvasGroupB;
                panelText = panelTextB;
                textContainerImage = textContainerImagB;
            }
            _narratorText = narratorText;
            panelText.text = _narratorText;
            int randomInt = UnityEngine.Random.Range(0, randomColor.Length);
            textContainerImage.color = randomColor[randomInt];
            _onCompleteNarrator = onCompleteNarrator;
            _canvasGroup.UpdateState(true, delay , ()=>BringOnNarratorComplete());
        }

        private void BringOnNarratorComplete()
        {
            if (_onCompleteNarrator != null)
            {
                CallOnCompleteNarrator();
            }
        }

        private void CallOnCompleteNarrator()
        {
            TTSManager.Instance.ReadCanvas(_narratorText, _narratorName, () => BringOutNarrator(narratorOutDelay));
        }

        internal void BringOutNarrator(float delay = 1f)
        {
            _canvasGroup.UpdateState(false, delay, ()=> {
                _onCompleteNarrator();
            });
        }

    }
}

public enum NarratorName
{
    NotSet = -1,
    //For Male
    A = 0,
    //For Female
    B = 1,
}