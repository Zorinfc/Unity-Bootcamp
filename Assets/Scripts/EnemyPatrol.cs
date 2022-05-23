using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyPatrol : MonoBehaviour
{
    public Vector2 StartPosition;

    public Vector2 EndPosition;

    public float MovementTime;

    public Ease PatrolMovementEase;
    private void Start()
    {
        StartPatrolMovement();
    }
    void StartPatrolMovement()
    {
        transform.DOMove(EndPosition, MovementTime).From(StartPosition).SetLoops(-1, LoopType.Yoyo).SetEase(PatrolMovementEase);
    }
}
