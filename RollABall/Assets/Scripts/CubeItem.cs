using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CubeItem : MonoBehaviour
{
    public int mScore = 1;

    public bool isOnCollision = false;

    public void Hidden()
    {
        isOnCollision = true;
        DOTween.To(getter =>
        {
            
        }, 0, 1, 1f).OnComplete(() =>
        {
            Destroy(gameObject);
        });
    }
    
}
