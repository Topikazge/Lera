using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CreateTestData", order = 1)]
public class TestContainer : ScriptableObject
{
    [SerializeField] public  QuestionTest[] QuestionTest;
}
