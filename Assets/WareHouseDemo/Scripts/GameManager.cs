using UnityEngine;
using DG.Tweening;
using Ui.Narrator;
using Audio.Warehouse;

public class GameManager : MonoBehaviour
{
    // P1 A   Answer  >>>> man
    // P2 B   Question  >>> girl

    private const string AN01 = "Hi how’re you";
    private const string BN02 = "I’m good, How was you’re weekend";
    private const string AN03 = "Nothing much, what about you";
    private const string BN04 = "Just went to beach with my family";
    private const string AN05 = "Nice, So how was it";
    private const string BN06 = "Very nice & Calming, A much needed gate away. Enjoyed the sunsets, the food & some quality time";
    private const string AN07 = "Sounds really awesome";
    private const string BN08 = "Yes It was";
    private const string AN09 = "So, what are you working on nowadays";
    private const string BN10 = "Oh! It’s just a new project that was assigned to me but I’ve no idea about it, So I’m hoping to find someone" +
                                "who knows about the field my client is into";
    private const string AN11 = "Ok & what’s that";
    private const string BN12 = "He’s into warehouse automation";
    private const string AN13 = "is that so? Don’t worry then, I’ll help you out";
    private const string BN14 = "You serious? You’ve idea about this field? If you help me out it’d be really helpful";
    private const string AN15 = "Yes, I mean I’ve been working in the similar field for over a decade now";
    private const string BN16 = "You really are a lifesaver";
    private const string AN17 = "Yeah, So whatever you want just ask right away";
    private const string BN18 = "Yeah Sure!, Let me just get my notes I’ve somethings I need answers for. I’ll ask you about them one by one is that okay";
    private const string AN19 = "Yeah no worries";
    private const string BN20 = "So, Let’s start with the basics what’s a warehouse";
    private const string AN21 = "Yes, Sure, warehouse is a building where large quantities of goods are stored before being sent to shops";
    private const string BN22 = "ok, Now I do have some terminologies that I didn’t understand here, can you explain them to me";
    private const string AN23 = "Yeah";
    private const string BN24 = "So there’s something written over here like Inbound, Whats that";
    private const string AN25 = "You mean Inbound logistics, so its basically the way materials and other goods are brought into a company";
    private const string BN26 = "Ok so what are steps are there related with this Inbound logistics";
    private const string AN27 = "Usually This process includes the steps to order, receive, store, transport and manage incoming supplies";

    private const string BN28 = "Oh ok that sounds good";
    private const string AN29 = "Yeah! So I guess that’s that. Now what are you curios about next";
    private const string BN30 = "Yes, So can you tell me more about Putaway";
    private const string AN31 = "So putaway is actually one of the key components in terms of warehouse management";
    private const string BN32 = "Ok so what does it mean";
    private const string AN33 = "Its basically process of storing goods in a warehouse. Here we take items from inventory and them put them on the different pallet or shelves";
    private const string BN34 = "So what are the activities involved in this put-away process";
    private const string AN35 = "the main activities involved in this are warehouse receiving, transportation, and ensuring that inventory is stored in the right locations";

    private const string BN36 = "Alright. That sounds really important. Now can you tell me a bit about outbound logistics";
    private const string AN37 = "Yeah So this term is generally used for storing, transporting and distributing goods to customer";
    private const string BN38 = "Ok";
    private const string AN39 = "So it basically starts with customer sales order, moves on to warehouse packing and ends with product deliver";
    private const string BN40 = "Cool!";


    //private const string AN41 = "Its basically process of storing goods in a warehouse. Here we take items from inventory and them put them on the different pallet or shelves";
    //private const string BN41 = "So what are the activities involved in this put-away process";
    //private const string AN43 = "the main activities involved in this are warehouse receiving, transportation, and ensuring that inventory is stored in the right locations";
    //private const string BN28 = "Ok pease can you tell me about warehouse receiving";
    //private const string AN29 = "Yes The warehouse receiving process steps include delivery of the products, unloading from the delivery trunk, and inventory storage";

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
    [SerializeField] GameObject characterBoy;
    [SerializeField] GameObject characterGirl;

    [SerializeField] NarratorHandler _narratorHandeler;

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
       // Invoke(nameof(CallA01), 2.2f);
        Invoke(nameof(CallA13), 2.2f);
    }

    private void CallA01()
    {
        _narratorHandeler.BringInNarrator(AN01,NarratorName.A, 1f, AudioName.NA01, CallB02);
    }


    private void CallB02()
    {
        _narratorHandeler.BringInNarrator(BN02, NarratorName.B, 1f, AudioName.NB02, CallA03);
    }


    private void CallA03()
    {
        _narratorHandeler.BringInNarrator(AN03, NarratorName.A, 1f, AudioName.NA03, CallB04);
    }
    private void CallB04()
    {
        _narratorHandeler.BringInNarrator(BN04, NarratorName.B, 1f, AudioName.NB04, CallA05);
    }

    private void CallA05()
    {
        _narratorHandeler.BringInNarrator(AN05, NarratorName.A, 1f, AudioName.NA05, CallB06);
    }


    private void CallB06()
    {
        _narratorHandeler.BringInNarrator(BN06, NarratorName.B, 1f, AudioName.NB06, CallA07);
    }


    private void CallA07()
    {
        _narratorHandeler.BringInNarrator(AN07, NarratorName.A, 1f, AudioName.NA07, CallB08);
    }
    private void CallB08()
    {
        _narratorHandeler.BringInNarrator(BN08, NarratorName.B, 1f, AudioName.NB08, CallA09);
    }

    private void CallA09()
    {
        _narratorHandeler.BringInNarrator(AN09, NarratorName.A, 1f, AudioName.NA09, CallB10);
    }


    private void CallB10()
    {
        _narratorHandeler.BringInNarrator(BN10, NarratorName.B, 1f, AudioName.NB10, CallA11);
    }


    private void CallA11()
    {
        _narratorHandeler.BringInNarrator(AN11, NarratorName.A, 1f, AudioName.NA11, CallB12);
    }
    private void CallB12()
    {
        _narratorHandeler.BringInNarrator(BN12, NarratorName.B, 1f, AudioName.NB12, CallA13);
    }

    private void CallA13()
    {
        _narratorHandeler.BringInNarrator(AN13, NarratorName.A, 1f, AudioName.NA13, CallB14);
    }


    private void CallB14()
    {
        _narratorHandeler.BringInNarrator(BN14, NarratorName.B, 1f, AudioName.NA13, CallA15);
    }


    private void CallA15()
    {
        _narratorHandeler.BringInNarrator(AN15, NarratorName.A, 1f, AudioName.NA13, CallB16);
    }
    private void CallB16()
    {
        _narratorHandeler.BringInNarrator(BN16, NarratorName.B, 1f, AudioName.NA13, CallA17);
    }
    private void CallA17()
    {
        _narratorHandeler.BringInNarrator(AN17, NarratorName.A, 1f, AudioName.NA13, CallB18);
    }


    private void CallB18()
    {
        _narratorHandeler.BringInNarrator(BN18, NarratorName.B, 1f, AudioName.NA13, CallA19);
    }


    private void CallA19()
    {
        _narratorHandeler.BringInNarrator(AN19, NarratorName.A, 1f, AudioName.NA13, CallB20);
    }
    private void CallB20()
    {
        _narratorHandeler.BringInNarrator(BN20, NarratorName.B, 1f, AudioName.NA13, CallA21);
    }

    private void CallA21()
    {
        _narratorHandeler.BringInNarrator(AN21, NarratorName.A, 1f, AudioName.NA13, CallImageForWharehouse);
    }

    private void CallImageForWharehouse()
    {
        ImageHandeler.Instance.BringPanel(whareHouseSPR, CallB22);
    }

    private void CallB22()
    {
        _narratorHandeler.BringInNarrator(BN22, NarratorName.B, 1f, AudioName.NA13, CallA23);
    }


    private void CallA23()
    {
        _narratorHandeler.BringInNarrator(AN23, NarratorName.A, 1f, AudioName.NA13, CallB24);
    }
    private void CallB24()
    {
        _narratorHandeler.BringInNarrator(BN24, NarratorName.B, 1f, AudioName.NA13, CallA25);
    }

    private void CallA25()
    {
        _narratorHandeler.BringInNarrator(AN25, NarratorName.A, 1f, AudioName.NA13, CallB26);
    }
    private void CallB26()
    {
        _narratorHandeler.BringInNarrator(BN26, NarratorName.B, 1f, AudioName.NA13, CallA27);
    }

    private void CallA27()
    {
        _narratorHandeler.BringInNarrator(AN27, NarratorName.A, 1f, AudioName.NA13, CallB28);
    }
    private void CallB28()
    {
        _narratorHandeler.BringInNarrator(BN28, NarratorName.B, 1f, AudioName.NA13, CallA29);
    }

    private void CallA29()
    {
        _narratorHandeler.BringInNarrator(AN29, NarratorName.A, 1f, AudioName.NA13, CallImageForWharehouseReceving);
    }

    private void CallImageForWharehouseReceving()
    {
        ImageHandeler.Instance.BringPanel(whareHouseReceivingSPR, CallB30);
    }
    private void CallB30()
    {
       // _narratorHandeler.BringInNarrator(BN26, NarratorName.B, 1f, AudioName.NB12, CallA27);
    }

    private void CallA31()
    {
        _narratorHandeler.BringInNarrator(AN27, NarratorName.A, 1f, AudioName.NB12, CallImageForWharehouse);
    }
    private void BringWarehouseCompletePanel()
    {
        WarehouseTrainingCompletePanel.Instance.BringPanel();
    }

}
