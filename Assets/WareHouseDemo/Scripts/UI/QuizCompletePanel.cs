using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utilities;

public class QuizCompletePanel : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private Button assessmentAgainBtn;
    void Start()
    {
        canvasGroup.UpdateState(false, 0);
        assessmentAgainBtn.onClick.AddListener(OnClickAssessmentAgainBtn);
    }
    private void OnDestroy()
    {
        assessmentAgainBtn.onClick.RemoveListener(OnClickAssessmentAgainBtn);
        canvasGroup.UpdateState(false, 0);
    }

    internal void BringPanel()
    {
        canvasGroup.UpdateState(true);
    }

    private void OnClickAssessmentAgainBtn()
    {
  
    }
}
