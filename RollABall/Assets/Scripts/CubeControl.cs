using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubeControl : MonoBehaviour
{

    public static CubeControl instance;
    
    public CubeItem mDefaultItem;

    private void Awake()
    {
        instance = this;
        mDefaultItem.gameObject.SetActive(false);
    }

    public void BeginCreat()
    {

        int RandomCount = Random.Range(8, 13);

        int totTalScore = 12;
        int lastScore = totTalScore - RandomCount;
        int currentScore = 0;
        
        for (int i = 0; i < RandomCount; i++)
        {
            CubeItem item = Instantiate(mDefaultItem, transform);
            item.transform.localPosition = new Vector3(Random.Range(-14f, 14f), 0, Random.Range(-14f, 14f));
            item.transform.rotation = new Quaternion(Random.Range(0, 360f), Random.Range(0, 360f), Random.Range(0, 360f), Random.Range(0, 360f));
            
            if (lastScore > 0)
            {
                int extScore = Random.Range(0, lastScore + 1);
                lastScore -= extScore;
                item.mScore = extScore + 1;
            }
            else
            {
                item.mScore = 1;
            }
            currentScore += item.mScore;
            item.gameObject.SetActive(true);
        }
        
    }
}
