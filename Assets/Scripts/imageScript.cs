using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class imageScript : MonoBehaviour
{
    public Sprite sp;

    void Start()
    {
        GetComponent<Image>().sprite = sp;
    }

    
}
