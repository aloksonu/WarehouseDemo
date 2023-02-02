using UnityEngine.UI;
using UnityEngine;
using Utilities;

public class ImageHandeler : MonoSingleton<ImageHandeler>
{
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

    internal void BringPanel(Sprite spr)
    {
        img.sprite = spr;
        canvasGroup.UpdateState(true);
    }

    internal void BringOutPanel()
    {
        canvasGroup.UpdateState(false);
    }
}
