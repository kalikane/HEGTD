using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rawImageScript : MonoBehaviour
{
    float x = 0f;
    void Update()
    {
        x += 0.01f;
        GetComponent<RawImage>().uvRect = new Rect(x, 0, 1f, 1f);        
    }
}
