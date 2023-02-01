using TMPro;
using Ui.ScoreSystem;
using UnityEngine;
using UnityEngine.UI;
using Utilities;

public class QuizCompletePanel : MonoSingleton<QuizCompletePanel>
{
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private TextMeshProUGUI messegeTextMeshProUGUI;
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
        messegeTextMeshProUGUI.text = "You have scored " + ScoreManager.Instance.GetScore().ToString() + "out of" + ScoreManager.Instance.GetMaxScore().ToString();
        canvasGroup.UpdateState(true);
    }

    private void OnClickAssessmentAgainBtn()
    {
  
    }
}
