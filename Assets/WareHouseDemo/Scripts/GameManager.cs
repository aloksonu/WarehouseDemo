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
                                " who knows about the field my client is into";
    private const string AN11 = "Ok & what’s that";
    private const string BN12 = "He’s into warehouse automation";
    private const string AN13 = "Is that so? Don’t worry then, I’ll help you out";
    private const string BN14 = "You serious? You’ve idea about this field? If you help me out it’d be really helpful";
    private const string AN15 = "Yes, I mean I’ve been working in the similar field for over a decade now";
    private const string BN16 = "You really are a lifesaver";
    private const string AN17 = "Yeah, So whatever you want just ask right away";
    private const string BN18 = "Yeah Sure!, Let me just get my notes I’ve somethings I need answers for. I’ll ask you about them one by one is that okay";
    private const string AN19 = "Yeah no worries";
    private const string BN20 = "So, Let’s start with the basics what’s a warehouse";
    private const string AN21 = "Yes, Sure, warehouse is a building where large quantities of goods are stored before being sent to shops";// after this show pic>>warehouse
    private const string BN22 = "Ok, Now I do have some terminologies that I didn’t understand here, can you explain them to me";
    private const string AN23 = "Yeah";
    private const string BN24 = "So there’s something written over here like Inbound, Whats that";
    private const string AN25 = "You mean Inbound logistics, so its basically the way materials and other goods are brought into a company";// after this show pic >>Inbound
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
    // here show pic >>Putaway

    private const string BN36 = "Alright. That sounds really important. Now can you tell me a bit about outbound logistics"; // after this show pic>>outbound
    private const string AN37 = "Yeah So this term is generally used for storing, transporting and distributing goods to customer";
    private const string BN38 = "Ok";
    private const string AN39 = "So it basically starts with customer sales order, moves on to warehouse packing and ends with product deliver";
    private const string BN40 = "Cool!";

    private const string BN41 = "Ok pease can you tell me about warehouse receiving";
    private const string AN42 = "Ok look this picture"; // after this show pic >> receiving
    private const string AN43 = "So the warehouse receiving process steps include delivery of the products, unloading from the delivery trunk, and inventory storage";

    //..........
    private const string BN44 = "Ok, Now can you tell me more about this picking process";
    private const string AN45 = "Yeah! So what happens is Voice, labels, or lights direct operators to pick all cases required for a batch of orders within a specific pick module.Operators make the picks";
    private const string BN46 = "Ok then";
    private const string AN47 = "After that, All the picks are placed on each case on the outbound conveyor.The conveyor transports and merges cases from" +
        " various pick modules and then sorts them to individual shipping lanes based on order requirements";
    // after this show pic >> picking
    private const string BN48 = "Ok, Now what’s the case picking pallet then";
    private const string AN49 = "So we help our operators with the help of computer instructions or voice commands so that they can understand which goods to pick out" +
        " and where to send them";
    private const string BN50 = "I believe most of these picking methods are automated right";
    private const string AN51 = "Yeah right";
    private const string BN52 = "Ok, Now can you explain me about the transportation system";   // after this show pic >> transport
    private const string AN53 = "Yeah the transport system in warehouse includes transport of goods and cargos from their receiving location to the warehouse" +
        " where they're stored along with sending them to desired delivery locations";


    //private const string AN41 = "Its basically process of storing goods in a warehouse. Here we take items from inventory and them put them on the different pallet or shelves";
    //private const string BN41 = "So what are the activities involved in this put-away process";
    //private const string AN43 = "the main activities involved in this are warehouse receiving, transportation, and ensuring that inventory is stored in the right locations";


    //private const string NC15 = "Inbound:";
    //private const string NC16 = "Receiving";
    //private const string NC17 = "Putaway";
    //private const string NC18 = "Storage";
    //private const string NC19 = "Outbound:";
    //private const string NC20 = "Picking";
    //private const string NC21 = "Transport";
    //private const string NC22 = "Shipping Software";
    //private const string NC23 = "Service";

    //private const string NC24 = "<b> Receiving</b>  the collection of activities involved in:";
    //private const string NC25 = "\u2022<indent=1em> the orderly receipt of all materials coming into the warehouse.</indent>";
    //private const string NC26 = "\u2022<indent=1em> providing the assurance that the quantity and quality of such materials are as ordered.</indent>";
    //private const string NC27 = "\u2022<indent=1em> disbursing materials to storage or to other organizational functions requiring them.</indent>";


    [SerializeField] Sprite whareHouseSPR;
    [SerializeField] Sprite ReceivingSPR;
    [SerializeField] Sprite InboundSPR;
    [SerializeField] Sprite OutboundSPR;
    [SerializeField] Sprite PutawaySPR;
    [SerializeField] Sprite PickingSPR;
    [SerializeField] Sprite TransportSPR;
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
        Invoke(nameof(CallA01), 2.2f);
       // Invoke(nameof(CallB40), 2.2f);
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
        _narratorHandeler.BringInNarrator(BN14, NarratorName.B, 1f, AudioName.NB14, CallA15);
    }


    private void CallA15()
    {
        _narratorHandeler.BringInNarrator(AN15, NarratorName.A, 1f, AudioName.NA15, CallB16);
    }
    private void CallB16()
    {
        _narratorHandeler.BringInNarrator(BN16, NarratorName.B, 1f, AudioName.NB16, CallA17);
    }
    private void CallA17()
    {
        _narratorHandeler.BringInNarrator(AN17, NarratorName.A, 1f, AudioName.NA17, CallB18);
    }


    private void CallB18()
    {
        _narratorHandeler.BringInNarrator(BN18, NarratorName.B, 1f, AudioName.NB18, CallA19);
    }


    private void CallA19()
    {
        _narratorHandeler.BringInNarrator(AN19, NarratorName.A, 1f, AudioName.NA19, CallB20);
    }
    private void CallB20()
    {
        _narratorHandeler.BringInNarrator(BN20, NarratorName.B, 1f, AudioName.NB20, CallA21);
    }

    private void CallA21()
    {
        _narratorHandeler.BringInNarrator(AN21, NarratorName.A, 1f, AudioName.NA21, CallImageForWharehouse);
    }

    private void CallImageForWharehouse()
    {
        ImageHandeler.Instance.BringPanel(whareHouseSPR, CallB22);
    }

    private void CallB22()
    {
        _narratorHandeler.BringInNarrator(BN22, NarratorName.B, 1f, AudioName.NB22, CallA23);
    }


    private void CallA23()
    {
        _narratorHandeler.BringInNarrator(AN23, NarratorName.A, 1f, AudioName.NA23, CallB24);
    }
    private void CallB24()
    {
        _narratorHandeler.BringInNarrator(BN24, NarratorName.B, 1f, AudioName.NB24, CallA25);
    }

    private void CallA25()
    {
        _narratorHandeler.BringInNarrator(AN25, NarratorName.A, 1f, AudioName.NA25, CallImageForInbound);
    }

    private void CallImageForInbound()
    {
        ImageHandeler.Instance.BringPanel(InboundSPR, CallB26);
    }
    private void CallB26()
    {
        _narratorHandeler.BringInNarrator(BN26, NarratorName.B, 1f, AudioName.NB26, CallA27);
    }

    private void CallA27()
    {
        _narratorHandeler.BringInNarrator(AN27, NarratorName.A, 1f, AudioName.NA27, CallB28);
    }
    private void CallB28()
    {
        _narratorHandeler.BringInNarrator(BN28, NarratorName.B, 1f, AudioName.NB28, CallA29);
    }

    private void CallA29()
    {
        _narratorHandeler.BringInNarrator(AN29, NarratorName.A, 1f, AudioName.NA29, CallB30);
    }

    private void CallB30()
    {
        _narratorHandeler.BringInNarrator(BN30, NarratorName.B, 1f, AudioName.NB30, CallA31);
    }

    private void CallA31()
    {
        _narratorHandeler.BringInNarrator(AN31, NarratorName.A, 1f, AudioName.NA31, CallB32);
    }
    private void CallB32()
    {
        _narratorHandeler.BringInNarrator(BN32, NarratorName.B, 1f, AudioName.NB32, CallA33);
    }

    private void CallA33()
    {
        _narratorHandeler.BringInNarrator(AN33, NarratorName.A, 1f, AudioName.NA33, CallB34);
    }
    private void CallB34()
    {
        _narratorHandeler.BringInNarrator(BN34, NarratorName.B, 1f, AudioName.NB34, CallA35);
    }

    private void CallA35()
    {
        _narratorHandeler.BringInNarrator(AN35, NarratorName.A, 1f, AudioName.NA35, CallImageForPutAway);
    }
    private void CallImageForPutAway()
    {
        ImageHandeler.Instance.BringPanel(PutawaySPR, CallB36);
    }
    private void CallB36()
    {
        _narratorHandeler.BringInNarrator(BN36, NarratorName.B, 1f, AudioName.NB36, CallA37);
    }
    private void CallA37()
    {
        _narratorHandeler.BringInNarrator(AN37, NarratorName.A, 1f, AudioName.NA37, CallImageForOutbound);
    }

    private void CallImageForOutbound()
    {
        ImageHandeler.Instance.BringPanel(OutboundSPR, CallB38);
    }
    private void CallB38()
    {
        _narratorHandeler.BringInNarrator(BN38, NarratorName.B, 1f, AudioName.NB38, CallA39);
    }

    private void CallA39()
    {
        _narratorHandeler.BringInNarrator(AN39, NarratorName.A, 1f, AudioName.NA39, CallB40);
    }
    private void CallB40()
    {
        _narratorHandeler.BringInNarrator(BN40, NarratorName.B, 1f, AudioName.NB40, CallB41);//CallB41 to skip receiving process
    }
    private void CallB41()
    {
        _narratorHandeler.BringInNarrator(BN41, NarratorName.B, 1f, AudioName.NB41, CallA42);
    }
    private void CallA42()
    {
        _narratorHandeler.BringInNarrator(AN42, NarratorName.A, 1f, AudioName.NA42, CallImageForWharehouseReceving);
    }
    private void CallImageForWharehouseReceving()
    {
        ImageHandeler.Instance.BringPanel(ReceivingSPR, CallA43);
    }
    private void CallA43()
    {
        _narratorHandeler.BringInNarrator(AN43, NarratorName.A, 1f, AudioName.NA43, CallB44);
    }
    private void CallB44()
    {
        _narratorHandeler.BringInNarrator(BN44, NarratorName.B, 1f, AudioName.NB44, CallA45);
    }
    private void CallA45()
    {
        _narratorHandeler.BringInNarrator(AN45, NarratorName.A, 1f, AudioName.NA45, CallB46);
    }
    private void CallB46()
    {
        _narratorHandeler.BringInNarrator(BN46, NarratorName.B, 1f, AudioName.NB46, CallA47);
    }
    private void CallA47()
    {
        _narratorHandeler.BringInNarrator(AN47, NarratorName.A, 1f, AudioName.NA47, CallImageForPicking);
    }

    private void CallImageForPicking()
    {
        ImageHandeler.Instance.BringPanel(PickingSPR, CallB48);
    }
    private void CallB48()
    {
        _narratorHandeler.BringInNarrator(BN48, NarratorName.B, 1f, AudioName.NB48, CallA49);
    }
    private void CallA49()
    {
        _narratorHandeler.BringInNarrator(AN49, NarratorName.A, 1f, AudioName.NA49, CallB50);
    }
    private void CallB50()
    {
        _narratorHandeler.BringInNarrator(BN50, NarratorName.B, 1f, AudioName.NB50, CallA51);
    }
    private void CallA51()
    {
        _narratorHandeler.BringInNarrator(AN51, NarratorName.A, 1f, AudioName.NA51, CallB52);
    }
    private void CallB52()
    {
        _narratorHandeler.BringInNarrator(BN52, NarratorName.B, 1f, AudioName.NB52, callLookImage);
    }

    private void callLookImage()
    {
        _narratorHandeler.BringInNarrator(AN42, NarratorName.A, 1f, AudioName.NA42, callimageforwharehouseTransport);
    }
    private void callimageforwharehouseTransport()
    {
        ImageHandeler.Instance.BringPanel(TransportSPR, CallA53);
    }
    private void CallA53()
    {
        _narratorHandeler.BringInNarrator(AN53, NarratorName.A, 1f, AudioName.NA53, CallB54);
    }
    private void CallB54()
    {
        _narratorHandeler.BringInNarrator(BN38, NarratorName.B, 1f, AudioName.NB38, null);
    }
    private void BringWarehouseCompletePanel()
    {
        WarehouseTrainingCompletePanel.Instance.BringPanel();
    }

}
