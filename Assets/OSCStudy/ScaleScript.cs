using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScript : MonoBehaviour
{
    public float ReactiveValue_Intensity;
    private Transform transform;
    

    // Start is called before the first frame update
    void Start()
    {
        transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.one * ReactiveValue_Intensity;
    }
}
