using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinMove : MonoBehaviour
{
   public Vector2 MoveOffsetPosition;

   public Vector2 MoveToPosition;

   public Vector2 MoveFromPosition;

   private void Start()
   {
      MoveFromPosition = transform.position;
      MoveToPosition = MoveFromPosition + MoveOffsetPosition;
      MoveTween();
   }

   void MoveTween()
   {
      transform.DOMove(MoveToPosition, 1f).From(MoveFromPosition).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
   }
}
