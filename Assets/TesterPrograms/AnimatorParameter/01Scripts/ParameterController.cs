using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class ParameterController : MonoBehaviour
{
    [SerializeField]
    private ParameterChanger parameterChanger;
    [SerializeField]
    private bool isAnimator;

    private void Start()
    {
        Deactivate();
    }

    [Button]
    private void ChangeParameter()
    {
        parameterChanger.ChangeDirectionParameter(parameterChanger.leftDirection);
        parameterChanger.LogParameter();
    }

    [Button]
    private void Activate()
    {
        if (isAnimator)
            parameterChanger.animator.enabled = true;
        else
            parameterChanger.gameObject.SetActive(true);
    }

    [Button]
    private void Deactivate()
    {
        if (isAnimator)
            parameterChanger.animator.enabled = false;
        else
            parameterChanger.gameObject.SetActive(false);
    }

    [Button]
    private void ChangeAndActivate()
    {
        ChangeParameter();
        Activate();
    }

    [Button]
    private void ActivateAndChange()
    {
        Activate();
        ChangeParameter();
    }
}