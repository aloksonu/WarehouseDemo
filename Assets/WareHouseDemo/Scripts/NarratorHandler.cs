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
        private float _fadeDuration = 0.4f;
        private const float narratorOutDelay = 0.2f;
        private const float audioFinishDelay = 0.5f;

        void Start()
        {
            _canvasGroupA.UpdateState(false, 0);
            _canvasGroupB.UpdateState(false, 0);
        }

        internal void BringInNarrator(string narratorText,NarratorName narratorName= NarratorName.NotSet, float delay = 1f, AudioName audioName = AudioName.NotSet,
               Action onCompleteNarrator = null)
        {
            if(narratorName == NarratorName.A)
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
            _canvasGroup.UpdateState(true, delay , ()=>BringOnNarratorComplete(audioName));
        }

        private void BringOnNarratorComplete(AudioName audioName)
        {
            GenericAudioManager.Instance.PlaySound(audioName);
            if (_onCompleteNarrator != null)
            {
                Invoke(nameof(CallOnCompleteNarrator), GenericAudioManager.Instance.GetAudioLength(audioName) + audioFinishDelay);
            }
        }

        private void CallOnCompleteNarrator()
        {
                 BringOutNarrator(narratorOutDelay);            
        }

        internal void BringOutNarrator(float delay = 1f)
        {
            _canvasGroup.UpdateState(false, delay, ()=> {
                _onCompleteNarrator();
                //_onCompleteNarrator = null;
            });
        }

    }
}

public enum NarratorName
{
    NotSet = -1,
    A = 0,
    B = 1,
}