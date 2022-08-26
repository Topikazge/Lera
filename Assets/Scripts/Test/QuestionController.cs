using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionController : MonoBehaviour
{
    [SerializeField] private  TestContainer _testContainer;
    [SerializeField] private TextMeshProUGUI _questionField;
    [SerializeField] private TextMeshProUGUI[] _answer;
    private int _trueAnswer;
    private int _maxTrueAnswer;
    private int _answerIndex;

    private QuestionTest[] _questionTest;

    public void Start()
    {
        _questionTest = _testContainer.QuestionTest;
        _answerIndex = 1;
        _trueAnswer = 0;
        _maxTrueAnswer = _questionTest.Length;
        NextQuestion();
    }

    public void OnClickedAnswer(int numberAnswer)
    {
        if(numberAnswer == _questionTest[_answerIndex - 1].TrueAnswer)
        {
            _trueAnswer++;
           
        }

        if ((_answerIndex-1) != _maxTrueAnswer)
        {
            NextQuestion();
        }
    }

    private void NextQuestion()
    {
        _questionField.text = _questionTest[_answerIndex - 1].Question;
        for (int i = 0; i < _answer.Length; i++)
        {
            _answer[i].text = _questionTest[_answerIndex - 1].Answers[i];
        }
    }


}
