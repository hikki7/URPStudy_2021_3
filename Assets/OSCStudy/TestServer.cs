using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestServer : MonoBehaviour
{

    public ScaleScript sendScript;

    public void TestOsc(float value)
    {
        //Debug.Log("value: " + value);
        sendScript.ReactiveValue_Intensity = value;
    }
}
