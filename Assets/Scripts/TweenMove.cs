using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using DG.Tweening;

public class TweenMove : MonoBehaviour
{
    public Vector2 Position1;

    public Vector2 Position2 ;

    public Tween CurrentTween;
    private void Start()
    {
        MoveTween();
        
    }
    
    public void MoveTween()
    {
        MoveBackwards(Position1,Position2);
    }

    void MoveBackwards(Vector2 GoToPosition, Vector2 GoToAnotherPosition)
    {
        CurrentTween = transform.DOMove(GoToPosition, 1f).SetDelay(2f).SetLoops(-1,LoopType.Incremental).OnComplete(() =>
        {
            transform.DOMove(GoToAnotherPosition, 1f).OnComplete(() =>
            {
                Debug.LogError("Movement is completed");
            });
        });
    }
    
    
    
    
    
    
    
}
