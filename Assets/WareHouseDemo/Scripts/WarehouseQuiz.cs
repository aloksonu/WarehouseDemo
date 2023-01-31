using GamePlay.Quiz;
using UnityEngine;
using Utilities;

public class WarehouseQuiz : MonoSingleton<WarehouseQuiz>
{
    private const string QUIZ01 = "This is quiz 1?";
    private const string QUIZ01_A = "Answer.";
    private const string QUIZ01_B = "Wrong1";
    private const string QUIZ01_C = "Wrong2";
    private const string QUIZ01_D = "Wrong3";

    private const string QUIZ02 = "This is quiz 2?";
    private const string QUIZ02_A = "Answer.";
    private const string QUIZ02_B = "Wrong1";
    private const string QUIZ02_C = "Wrong2";
    private const string QUIZ02_D = "Wrong3";


    void Start()
    {
       // Invoke("Quiz_01", 2f);
    }


    internal void Quiz_01()
    {
        Quizcontroller.Instance.BringQuizPanel(Quiz_02, GameOver, QUIZ01,
            QUIZ01_A, new string[]
            {
                    QUIZ01_B, QUIZ01_C, QUIZ01_D
            });
    }

    internal void Quiz_02()
    {
        Quizcontroller.Instance.BringQuizPanel(Quiz_03, GameOver, QUIZ02,
           QUIZ02_A, new string[]
           {
                    QUIZ02_B, QUIZ02_C, QUIZ02_D
           });
    }
    internal void Quiz_03()
    {
        //Quizcontroller.Instance.BringQuizPanel(Quiz_02, GameOver, QUIZ01,
        //    QUIZ01_A, new string[]
        //    {
        //            QUIZ01_B, QUIZ01_C, QUIZ01_D
        //    });
    }
    private void GameOver()
    {

    }
}
