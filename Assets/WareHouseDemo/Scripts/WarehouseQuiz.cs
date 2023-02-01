using GamePlay.Quiz;
using UnityEngine;
using Utilities;

public class WarehouseQuiz : MonoSingleton<WarehouseQuiz>
{
    private const string QUIZ01 = "What is the heart of the warehouse.?";
    private const string QUIZ01_A = "Data warehouse database servers.";
    private const string QUIZ01_B = " Data mining database servers.";
    private const string QUIZ01_C = "Data mart database servers.";
    private const string QUIZ01_D = "Relational data base servers.";

    private const string QUIZ02 = "......... is a subject-oriented, integrated, time-variant, nonvolatile collection of data in supportofmanagement decisions.";
    private const string QUIZ02_A = "Data Warehousing.";
    private const string QUIZ02_B = "Data Mining.";
    private const string QUIZ02_C = "Web Mining.";
    private const string QUIZ02_D = "Text Mining.";

    private const string QUIZ03 = "......... maps the core warehouse metadata to business concepts, familiar and useful to endusers.";
    private const string QUIZ03_A = "Application level metadata.";
    private const string QUIZ03_B = "User level metadata.";
    private const string QUIZ03_C = "Enduser level metadata.";
    private const string QUIZ03_D = "Core level metadata.";

    private const string QUIZ04 = "The time horizon in Data warehouse is usually .........";
    private const string QUIZ04_A = "5-10 years.";
    private const string QUIZ04_B = "1-2 years.";
    private const string QUIZ04_C = "3-4years.";
    private const string QUIZ04_D = "5-6 years.";

    private const string QUIZ05 = "Have you heard about put-away ?";
    private const string QUIZ05_A = "Yes, Putaway is the process of storing goods in a warehouse.";
    private const string QUIZ05_B = "Yes, Putaway is the process of sending goods in a warehouse.";

    private const string QUIZ06 = "SLAM stands for";
    private const string QUIZ06_A = "Simultaneous Localisation and Mapping.";
    private const string QUIZ06_B = "Simultion Localisation and Mapping.";


    void Start()
    {
        Invoke("Quiz_01", 0.2f);
    }


    internal void Quiz_01()
    {
        Quizcontroller.Instance.BringQuizPanel(Quiz_02, Quiz_02, QUIZ01,
            QUIZ01_A, new string[]
            {
                    QUIZ01_B, QUIZ01_C, QUIZ01_D
            });
    }

    internal void Quiz_02()
    {
        Quizcontroller.Instance.BringQuizPanel(Quiz_03, Quiz_03, QUIZ02,
           QUIZ02_A, new string[]
           {
                    QUIZ02_B, QUIZ02_C, QUIZ02_D
           });
    }
    internal void Quiz_03()
    {
        Quizcontroller.Instance.BringQuizPanel(Quiz_04, Quiz_04, QUIZ03,
            QUIZ03_A, new string[]
            {
                   QUIZ03_B, QUIZ03_C, QUIZ03_D
            });
    }

    internal void Quiz_04()
    {
        Quizcontroller.Instance.BringQuizPanel(Quiz_05, Quiz_05, QUIZ04,
            QUIZ04_A, new string[]
            {
                    QUIZ04_B, QUIZ04_C, QUIZ04_D
            });
    }

    internal void Quiz_05()
    {
        Quizcontroller.Instance.BringQuizPanel(Quiz_06, Quiz_06, QUIZ05,
           QUIZ05_A, new string[]
           {
                    QUIZ05_B
           });
    }
    internal void Quiz_06()
    {
        Quizcontroller.Instance.BringQuizPanel(BringQuizCompletePanel, BringQuizCompletePanel, QUIZ06,
            QUIZ06_A, new string[]
            {
                    QUIZ06_B
            });
    }

    internal void BringQuizCompletePanel()
    {
        QuizCompletePanel.Instance.BringPanel();
    }
    private void GameOver()
    {

    }
}
