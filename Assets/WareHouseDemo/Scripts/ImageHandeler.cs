using UnityEngine.UI;
using UnityEngine;
using Utilities;
using System;

public class ImageHandeler : MonoSingleton<ImageHandeler>
{
    private static Action _onComplete;
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private Image img;


    void Start()
    {
        canvasGroup.UpdateState(false, 0);
    }

    private void OnDestroy()
    {

        canvasGroup.UpdateState(false, 0);
    }

    internal void BringPanel(Sprite spr , Action onComplete = null)
    {
        img.sprite = spr;
        _onComplete = onComplete;
        canvasGroup.UpdateState(true);
        Invoke(nameof(BringOutPanel), 4);
    }

    internal void BringOutPanel()
    {
        canvasGroup.UpdateState(false,0.2f,()=> {
            
            if(_onComplete != null) { 
            _onComplete();
            _onComplete = null;
            }
        });
    }
}
