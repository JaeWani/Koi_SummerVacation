using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Lever : Puzzle
{
    [SerializeField] GameObject Door;
    [SerializeField] Vector2 ClosePos;
    [SerializeField] Vector2 OpenPos;
    protected override void Work()
    {
        base.Work();
        Door.transform.DOLocalMove(OpenPos, 3f);
        Debug.Log("작동");
    }
    protected override void Off()
    {
        base.Off();
        Door.transform.DOLocalMove(ClosePos, 3f);
        Debug.Log("해제");
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(isWork == true)
                isWork = false;
            else 
                isWork = true;
        }
    }
}
