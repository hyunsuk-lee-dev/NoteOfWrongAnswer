using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParameterDebugger : MonoBehaviour
{
    [SerializeField]
    private ParameterChanger parameterChanger;

    [SerializeField]
    private Text gameObjectStateText;
    [SerializeField]
    private Text animatorStateText;
    [SerializeField]
    private Text directionStateText;

    // Update is called once per frame
    void Update()
    {
        gameObjectStateText.text = parameterChanger.gameObject.activeSelf ? "켜짐" : "꺼짐";
        animatorStateText.text = parameterChanger.animator.enabled ? "켜짐" : "꺼짐";
        directionStateText.text = parameterChanger.GetParameter() == parameterChanger.leftDirection ? "좌측" : "우측";
    }
}
