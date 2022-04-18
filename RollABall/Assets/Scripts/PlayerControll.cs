using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [Header("移动速度")]
    public float movespeed = 1;
    [Header("")]
    public int mTotalCount = 0;

    public int mCurrentCount = 0;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))//控制人物的移动
        {
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);         
        }
 
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movespeed * Time.deltaTime);
        
        }
 
        if (Input.GetKey(KeyCode.A) )
        {
            transform.Translate(Vector3.left * movespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movespeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == LayerInfo.Cube)
        {
            CubeItem item = other.gameObject.GetComponent<CubeItem>();
            if (item.isOnCollision)
            {
                return;
            }
            mCurrentCount += item.mScore;
            item.Hidden();
            if (mCurrentCount == mTotalCount)
            {
                // 结束
                UIManager.instance.ShowSuccess();
            }
        }
    }
}
