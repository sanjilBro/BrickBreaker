using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvaScript : MonoBehaviour
{
    Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
       canvas = GetComponent<Canvas>();
       canvas.worldCamera = Camera.main; 
    }

    // Update is called once per frame
    void Update()
    {
        if(canvas.worldCamera == null) canvas.worldCamera = Camera.main;
    }
}
