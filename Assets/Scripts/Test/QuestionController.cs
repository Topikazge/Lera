using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionController : WindowActive
{
    [SerializeField] private  TestContainer _testContainer;
    [SerializeField] private TextMeshProUGUI _questionField;
    [SerializeField] private TextMeshProUGUI[] _answer;
    [SerializeField] private TestViewer _testViewer;
    private int _trueAnswer;
    private int _maxAnswer;
    private int _answerIndex;

    private QuestionTest[] _questionTest;

    public void Start()
    {
        _questionTest = _testContainer.QuestionTest;
        _answerIndex = 0;
        _trueAnswer = 0;
        _maxAnswer = _questionTest.Length;
        NextQuestion();
    }

    public override void View()
    {
        base.View();
        Start();
    }

    public void OnClickedAnswer(int numberAnswer)
    {
        int trueAnswer = _questionTest[_answerIndex].TrueAnswer;
        Debug.Log("numberAnswer - "+ numberAnswer+ " trueAnswer - "+ trueAnswer);
        if (numberAnswer == trueAnswer)
        {
            _trueAnswer++;
            Debug.Log("Увеличилось на 1");
           
        }

        Debug.Log("(_answerIndex-1) - " + (_answerIndex) + " _maxAnswer - " + _maxAnswer);
        if ((_answerIndex+1) != _maxAnswer)
        {
            _answerIndex++;
            NextQuestion();
        }
        else
        {
            _testViewer.ViewResult(this, _trueAnswer, _maxAnswer);
        }
      
    }

    private void NextQuestion()
    {
        Debug.Log("Переход");
        _questionField.text = _questionTest[_answerIndex].Question;
        for (int i = 0; i < _answer.Length; i++)
        {
            _answer[i].text = _questionTest[_answerIndex].Answers[i];
        }
    }


}
