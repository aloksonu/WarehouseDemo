using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utilities;

public class WarehouseTrainingCompletePanel : MonoSingleton<WarehouseTrainingCompletePanel>
{
    [SerializeField] private CanvasGroup canvasGroup;
    //[SerializeField] private TextMeshProUGUI panelText;
    [SerializeField] private Button assessmentBtn;
    void Start()
    {
        canvasGroup.UpdateState(false, 0);
        assessmentBtn.onClick.AddListener(OnClickAssessmentBtn);
    }
    private void OnDestroy()
    {
        assessmentBtn.onClick.RemoveListener(OnClickAssessmentBtn);
        canvasGroup.UpdateState(false, 0);
    }

    internal void BringPanel()
    {
        canvasGroup.UpdateState(true);
    }

    private void OnClickAssessmentBtn()
    {
        WarehouseQuiz.Instance.Quiz_01();
    }
}
