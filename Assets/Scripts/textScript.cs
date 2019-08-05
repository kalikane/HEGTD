using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
    Text t;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "je la l'état d'esprit <color=#8bc34a> <br>d'un millionaire</br> </color>";
        
    }

    
}
