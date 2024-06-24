using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class TaskFinishedFeedback : MonoBehaviour
{
    [SerializeField] private VoidEvent _taskFinished;
    [SerializeField] private VoidEvent _taskReset;
    [SerializeField] private TextMeshProUGUI _textMesh;

    private void OnEnable()
    {
        _taskFinished?.Register(TaskFinished);
        _taskReset?.Register(TaskReset);
    }

    private void TaskReset(Void obj)
    {
        _textMesh.SetText("");
    }

    private void TaskFinished(Void obj)
    {
        _textMesh.SetText("Well Done! Youv'e finished the task");
    }
}
