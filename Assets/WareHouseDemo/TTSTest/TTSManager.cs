using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ReadSpeaker;
using UnityEngine.UI;
using System;
using Utilities;

public class TTSManager : MonoSingleton<TTSManager>
{
    private static Action _onComplete;
    public TTSSpeaker speakerMale;
    public TTSSpeaker speakerFemale;
    private TTSSpeaker speaker;
    void Start()
    {
        TTS.Init();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !speakerMale.audioSource.isPlaying)
        {

            ReadCanvas("Hi this is alok");
        }
    }
    public void ReadCanvas(string str, NarratorName narratorName = NarratorName.NotSet, Action onComplete= null)
    {
        StartCoroutine(CanvasReaderCoroutine(str, narratorName, onComplete));
    }



    IEnumerator CanvasReaderCoroutine(string str , NarratorName narratorName = NarratorName.NotSet, Action onComplete = null)
    {
        _onComplete = onComplete;
        if (narratorName == NarratorName.A)
        {
            speaker = speakerMale;
        }
        else if (narratorName == NarratorName.B)
        {
            speaker = speakerFemale;
        }
        TTS.Say(str, speaker);
        // yield return new WaitUntil(() => speaker.audioSource.isPlaying);
        while (speaker.audioSource.isPlaying)
        {
            yield return null;
        }
        if (_onComplete != null)
        {
           _onComplete();
            _onComplete = null;
        }
    }
}
