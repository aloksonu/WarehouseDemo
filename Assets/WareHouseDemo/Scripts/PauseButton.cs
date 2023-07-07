using UnityEngine;
using UnityEngine.UI;

namespace WareHouseDemo.Scripts
{
    public class PauseButton : MonoBehaviour
    {
        [SerializeField] private Button btnPause;
        void Start()
        {
            btnPause.onClick.AddListener(OnClickPauseButton);
        }
        internal void OnClickPauseButton()
        {
            PausePanel.Instance.OnClickPauseButton();
        }
    }
}
