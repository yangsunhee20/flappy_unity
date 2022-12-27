using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreup : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
    Score.score++; // 1씩 올려줌. 파이썬에서 +=1
   }
}
