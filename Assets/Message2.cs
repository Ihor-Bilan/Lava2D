using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message2 : MonoBehaviour
{
    public Vector3 scaleChange;
    private int framesElapsed = 0;
    private int maxFrames = 100000;
    private int frameToShowMessage = 5500;

    void Update()
    {
        if (framesElapsed < maxFrames)
        {
            transform.localScale += scaleChange;
            framesElapsed++;

            if (framesElapsed == frameToShowMessage)
            {
                Debug.Log("Àÿÿÿÿàÿÿé, ãàðÿ÷å!!!! ÀÀÀÀ ");
            }
        }
    }
}

