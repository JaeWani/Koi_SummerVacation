using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    [SerializeField] private bool IsWork;
    public bool isWork
    {
        get
        {
            return IsWork;
        }
        set
        {
            IsWork = value;
            Check_isWork();
        }
    }
    protected void Check_isWork()
    {
        Debug.Log("검사");
        if(IsWork == true)
            Work();
        else
            Off();
    }
    protected virtual void Work()
    {
    }
    protected virtual void Off()
    {
    }
}
