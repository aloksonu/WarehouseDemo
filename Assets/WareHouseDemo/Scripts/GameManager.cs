using UnityEngine;
using DG.Tweening;
using Ui.Narrator;
using Audio.Warehouse;

public class GameManager : MonoBehaviour
{
    private const string NJ01 = "This is James, after working for several years, He has finally managed to save some money," +
        " He’s now starting his own business. But unfortunately for him all of the essentials he bought were lost." +
        " So now he’s trying to find them. Help him find them and setup his business.";
    private const string NC02 = "Hi,Sure, please tell me, How can I help you?";
    private const string NJ03 = "I’m here to find out my stuff, Unfortunately I’ve lost the details of my shipment. Can you help me find it";
    private const string NC04 = "Sure, that’d be no issue. I can also help you to get you super strength & speed" +
        " while we’re at it so that you can easily lift them up and carry them out of here so that " +
        "you won’t have to spend some extra bucks on transporting them.";
    private const string NJ05 = "What?";
    private const string NC06 = "That was a sarcasm! Jeez, you really have no idea about how things work around here do you?";
    private const string NJ07 = "All I know is that all my stuff was supposed to be delivered to me but it didn’t happen. So now I just want my stuff back. That’s it";
    private const string NC08 = "Dude! Look around you we’re in this giant warehouse where there are lots of boxes " +
        "and the only way to Identify them is with the shipment number which you lost!";
    private const string NJ09 = "Phew! Is there any way around that’d help me to find my stuff. I’ve worked way hard all these years." +
        "I can’t have everything go down the drain just because of my stupid mistake";
    private const string NJ10 = "I think we got on the wrong foot here. Can you help me understand this process. " +
        "So that I’ll be able to find out where my package is exactly.";
    private const string NC11 = "Sure! I’ll help you out. But don’t take all day I’ve lots of work to do.";
    private const string NJ12 = "Ok. So can you tell me what’s a warehouse? And how do these things operate?";
    private const string NC13 = "Yes, Sure, warehouse is a building where large quantities of goods are stored before being sent to shops.";
    private const string NC14 = "The major warehouse operations are:";

    private const string NC15 = "Inbound:";
    private const string NC16 = "Receiving";
    private const string NC17 = "Putaway";
    private const string NC18 = "Storage";
    private const string NC19 = "Outbound:";
    private const string NC20 = "Picking";
    private const string NC21 = "Transport";
    private const string NC22 = "Shipping Software";
    private const string NC23 = "Service";

    private const string NC24 = "<b> Receiving</b>  the collection of activities involved in:";
    private const string NC25 = "\u2022<indent=1em> the orderly receipt of all materials coming into the warehouse.</indent>";
    private const string NC26 = "\u2022<indent=1em> providing the assurance that the quantity and quality of such materials are as ordered.</indent>";
    private const string NC27 = "\u2022<indent=1em> disbursing materials to storage or to other organizational functions requiring them.</indent>";


    [SerializeField] Sprite whareHouseSPR;
    [SerializeField] Sprite whareHouseReceivingSPR;
    //[SerializeField] Image characterBoy;
    //[SerializeField] Image characterGirl;
    [SerializeField] GameObject characterBoy;
    [SerializeField] GameObject characterGirl;

    [SerializeField] NarratorHandler _narratorHandelerBoy;
    [SerializeField] NarratorHandler _narratorHandelerGirl;


    private const float timeToHoldMAx = 6f;

    void Start()
    {
        BringCharacterInView();

        //GenericAudioManager.Instance.PlaySound(AudioName.IntroBoy);
    }

    private void BringCharacterInView()
    {
        characterBoy.GetComponent<Transform>().DOMoveX(-5.38f, 2f);
        characterGirl.GetComponent<Transform>().DOMoveX(5.38f, 2f);
        Invoke(nameof(FunNJ01), 2.2f);
        //Invoke(nameof(FunNC14), 2.2f);
    }

    private void FunNJ01()
    {
        _narratorHandelerBoy.BringInNarrator(NJ01, 1f);
        Invoke(nameof(HideFunNJ01), timeToHoldMAx);

        //_narratorHandelerBoy.BringInNarrator(NJ01, 1f, () => GenericAudioManager.Instance.PlaySound(AudioName.IntroBoy));
        //Invoke(nameof(HideFirstNarratorByBoy), GenericAudioManager.Instance.GetAudioLength(AudioName.IntroBoy) + 1);
    }

    private void HideFunNJ01()
    {
        _narratorHandelerBoy.BringOutNarrator();
        Invoke(nameof(FunNC02), 1);
    }

    private void FunNC02()
    {
        _narratorHandelerGirl.BringInNarrator(NC02, 1f);
        Invoke(nameof(HideFunNC02), timeToHoldMAx);
    }

    private void HideFunNC02()
    {
        _narratorHandelerGirl.BringOutNarrator();
        Invoke(nameof(FunNJ03), 1);

    }

    private void FunNJ03()
    {
        _narratorHandelerBoy.BringInNarrator(NJ03, 1f);
        Invoke(nameof(HideFunNJ03), timeToHoldMAx);
    }

    private void HideFunNJ03()
    {
        _narratorHandelerBoy.BringOutNarrator();
        Invoke(nameof(FunNC04), 1);
    }

    private void FunNC04()
    {
        _narratorHandelerGirl.BringInNarrator(NC04, 1f);
        Invoke(nameof(HideFunNC04), timeToHoldMAx);
    }

    private void HideFunNC04()
    {
        _narratorHandelerGirl.BringOutNarrator();
        Invoke(nameof(FunNJ05), 1);
    }

    private void FunNJ05()
    {
        _narratorHandelerBoy.BringInNarrator(NJ05, 1f);
        Invoke(nameof(HideFunNJ05), timeToHoldMAx);
    }

    private void HideFunNJ05()
    {
        _narratorHandelerBoy.BringOutNarrator();
        Invoke(nameof(FunNC06), 1);
    }

    private void FunNC06()
    {
        _narratorHandelerGirl.BringInNarrator(NC06, 1f);
        Invoke(nameof(HideFunNC06), timeToHoldMAx);
    }

    private void HideFunNC06()
    {
        _narratorHandelerGirl.BringOutNarrator();
        Invoke(nameof(FunNJ07), 1);

    }

    private void FunNJ07()
    {
        _narratorHandelerBoy.BringInNarrator(NJ07, 1f);
        Invoke(nameof(HideFunNJ07), timeToHoldMAx);
    }

    private void HideFunNJ07()
    {
        _narratorHandelerBoy.BringOutNarrator();
        Invoke(nameof(FunNC08), 1);
    }

    private void FunNC08()
    {
        _narratorHandelerGirl.BringInNarrator(NC08, 1f);
        Invoke(nameof(HideFunNC08), timeToHoldMAx);
    }

    private void HideFunNC08()
    {
        _narratorHandelerGirl.BringOutNarrator();
        Invoke(nameof(FunNJ09), 1);

    }

    private void FunNJ09()
    {
        _narratorHandelerBoy.BringInNarrator(NJ09, 1f);
        Invoke(nameof(HideFunNJ09), timeToHoldMAx);
    }

    private void HideFunNJ09()
    {
        _narratorHandelerBoy.BringOutNarrator();
        Invoke(nameof(FunNJ10), 1);
    }

    private void FunNJ10()
    {
        _narratorHandelerBoy.BringInNarrator(NJ10, 1f);
        Invoke(nameof(HideFunNJ10), timeToHoldMAx);
    }

    private void HideFunNJ10()
    {
        _narratorHandelerBoy.BringOutNarrator();
        Invoke(nameof(FunNC11), 1);
    }

    private void FunNC11()
    {
        _narratorHandelerGirl.BringInNarrator(NC11, 1f);
        Invoke(nameof(HideFunNC11), timeToHoldMAx);
    }

    private void HideFunNC11()
    {
        _narratorHandelerGirl.BringOutNarrator();
        Invoke(nameof(FunNJ12), 1);

    }

    private void FunNJ12()
    {
        _narratorHandelerBoy.BringInNarrator(NJ12, 1f);
        Invoke(nameof(HideFunNJ12), timeToHoldMAx);
    }

    private void HideFunNJ12()
    {
        _narratorHandelerBoy.BringOutNarrator();
        Invoke(nameof(FunNC13), 1);
    }

    private void FunNC13()
    {
        _narratorHandelerGirl.BringInNarrator(NC13, 1f);
        ImageHandeler.Instance.BringPanel(whareHouseSPR);
        Invoke(nameof(HideFunNC13), timeToHoldMAx);
    }

    private void HideFunNC13()
    {
        _narratorHandelerGirl.BringOutNarrator();
        ImageHandeler.Instance.BringOutPanel();
        Invoke(nameof(FunNC14), 1);

    }

    private void FunNC14()
    {
        _narratorHandelerGirl.BringInNarrator(NC14+ "<br>"+NC15 + "<br>" + NC16 + "<br>" + NC17 + "<br>" + NC18, 1f);
        Invoke(nameof(HideFunNC14), timeToHoldMAx);
    }

    private void HideFunNC14()
    {
        _narratorHandelerGirl.BringOutNarrator();
        Invoke(nameof(FunNC15), 1);
    }

    private void FunNC15()
    {
        _narratorHandelerGirl.BringInNarrator(NC19 + "<br>" + NC20 + "<br>" + NC21 + "<br>" + NC22 + "<br>" + NC23, 1f);
        Invoke(nameof(HideFunNC15), timeToHoldMAx);
    }

    private void HideFunNC15()
    {
        _narratorHandelerGirl.BringOutNarrator();
        Invoke(nameof(FunNC16), 1);
    }

    private void FunNC16()
    {
        _narratorHandelerGirl.BringInNarrator(NC24 + "<br>" + NC25 + "<br>" + NC26 + "<br>" + NC27, 1f);
        ImageHandeler.Instance.BringPanel(whareHouseReceivingSPR);
        Invoke(nameof(HideFunNC16), timeToHoldMAx);
    }

    private void HideFunNC16()
    {
        //_narratorHandelerGirl.BringOutNarrator();
        //ImageHandeler.Instance.BringOutPanel();
        //Invoke(nameof(FunNC04), 1);
    }

    private void BringWarehouseCompletePanel()
    {
        WarehouseTrainingCompletePanel.Instance.BringPanel();
    }

}
