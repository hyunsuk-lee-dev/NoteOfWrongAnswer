using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ParameterChanger : MonoBehaviour
{
    private readonly int _directionParameter = Animator.StringToHash("Direction");
    
    public readonly int leftDirection = 1;
    public readonly int rightDirection = 0;
    
    public Animator animator;
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void ChangeDirectionParameter(int direction)
    {
        animator.SetInteger(_directionParameter, direction);
    }
    
    public string LogParameter()
    {
        var log = $"Parameter : {animator.GetInteger(_directionParameter)}";
        Debug.Log(log);
        return log;
    }

    public int GetParameter() => animator.GetInteger(_directionParameter);
}
