using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

public class ParameterController : MonoBehaviour
{
    [SerializeField]
    private ParameterChanger parameterChanger;

    private void Awake()
    {
        Deactivate();
    }
    
    // 파라미터가 바뀌면 왼쪽으로 움직이는 애니메이션이 실행된다.
    private void ChangeParameter()
    {
        parameterChanger.ChangeDirectionParameter(parameterChanger.leftDirection);
    }

    private void Activate()
    {
        parameterChanger.gameObject.SetActive(true);
    }

    private void Deactivate()
    {
        parameterChanger.gameObject.SetActive(false);
    }

    // 왼쪽으로 움직이지 않는다.
    public void ChangeAndActivate()
    {
        ChangeParameter();
        Activate();
    }

    // 정상적으로 왼쪽으로 움직인다.
    public void ActivateAndChange()
    {
        Activate();
        ChangeParameter();
    }

}