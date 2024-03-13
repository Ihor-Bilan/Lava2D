using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message3 : MonoBehaviour
{
    public Vector3 scaleChange;
    private int framesElapsed = 0;
    private int maxFrames = 100000;
    private int frameToShowMessage = 6700;

    void Update()
    {
        if (framesElapsed < maxFrames)
        {
            transform.localScale += scaleChange;
            framesElapsed++;

            if (framesElapsed == frameToShowMessage)
            {
                Debug.Log("�� �� ��� ��... ");
            }
        }
    }
}

