using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Ui.Narrator;
using Audio.Warehouse;

public class GameManager : MonoBehaviour
{
    private const string N01 = "Hi , This is Sam.";
    private const string N02 = "Hi , This is Maya.";
    private const string N03 = "Please tell me , What is warehouse?";
    private const string N04 = "warehouse is a building where large quantities of goods are stored before being sent to shops.";

    //[SerializeField] Image characterBoy;
    //[SerializeField] Image characterGirl;
    [SerializeField] GameObject characterBoy;
    [SerializeField] GameObject characterGirl;

    [SerializeField] NarratorHandler _narratorHandelerBoy;
    [SerializeField] NarratorHandler _narratorHandelerGirl;

    void Start()
    {
        BringCharacterInView();

        //GenericAudioManager.Instance.PlaySound(AudioName.IntroBoy);
    }

    private void BringCharacterInView()
    {
        characterBoy.GetComponent<Transform>().DOMoveX(-5.38f, 2f);
        characterGirl.GetComponent<Transform>().DOMoveX(5.38f, 2f);
        Invoke(nameof(FirstNarratorByBoy), 2.2f);
    }

    private void FirstNarratorByBoy()
    {
        _narratorHandelerBoy.BringInNarrator(N01,1f,()=> GenericAudioManager.Instance.PlaySound(AudioName.IntroBoy));
        Invoke(nameof(HideFirstNarratorByBoy), GenericAudioManager.Instance.GetAudioLength(AudioName.IntroBoy)+1);
    }

    private void HideFirstNarratorByBoy()
    {
        _narratorHandelerBoy.BringOutNarrator();
        Invoke(nameof(FirstNarratorByGirl), 1);
    }

    private void FirstNarratorByGirl()
    {
        _narratorHandelerGirl.BringInNarrator(N02, 1f, () => GenericAudioManager.Instance.PlaySound(AudioName.IntroGirl));
        Invoke(nameof(HideFirstNarratorByGirl), GenericAudioManager.Instance.GetAudioLength(AudioName.IntroGirl) + 1);
    }

    private void HideFirstNarratorByGirl()
    {
        _narratorHandelerGirl.BringOutNarrator();
        Invoke(nameof(FirstQuizNarratorByBoy), 1);

    }

    private void FirstQuizNarratorByBoy()
    {
        _narratorHandelerBoy.BringInNarrator(N03, 1f, () => GenericAudioManager.Instance.PlaySound(AudioName.WhatWarehouse));
        Invoke(nameof(HideFirstQuizNarratorByBoy), GenericAudioManager.Instance.GetAudioLength(AudioName.WhatWarehouse) + 1);
    }

    private void HideFirstQuizNarratorByBoy()
    {
        _narratorHandelerBoy.BringOutNarrator();
        Invoke(nameof(FirstQuizReplyNarratorByGirl), 1);
    }

    private void FirstQuizReplyNarratorByGirl()
    {
        _narratorHandelerGirl.BringInNarrator(N04, 1f, () => GenericAudioManager.Instance.PlaySound(AudioName.DefWarehouse));
        Invoke(nameof(HideFirstQuizReplyNarratorByGirl), GenericAudioManager.Instance.GetAudioLength(AudioName.DefWarehouse) + 1);
    }

    private void HideFirstQuizReplyNarratorByGirl()
    {
        _narratorHandelerGirl.BringOutNarrator();
        Invoke(nameof(BringWarehouseCompletePanel), 2);
    }


    private void BringWarehouseCompletePanel()
    {
        WarehouseTrainingCompletePanel.Instance.BringPanel();
    }

}
