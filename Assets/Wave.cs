using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Wave : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wave;
    public Rect rect;
    public bool isMoving;
    public static float waveMultiplier=1;
    public GameObject waveLine;
    public static Wave waveRef;
    void Start()
    {
        waveRef = this;
        rect = this.gameObject.GetComponent<RectTransform>().rect;
    }



    // Update is called once per frame
    void Update()
    {
        if (isMoving) 
        {
            wave.transform.rotation = Quaternion.Euler(0, 0, 45);
            //move up
              
            wave.transform.position += new Vector3(0, 1, 0);
            wave.transform.position = new Vector3(wave.transform.position.x, Mathf.Min(Screen.height, wave.transform.position.y), 0);
        }
        else
        {
            wave.transform.rotation = Quaternion.Euler(0, 0, -45);
            //move down
            wave.transform.position -= new Vector3(0, 1, 0);
            wave.transform.position = new Vector3(wave.transform.position.x, Mathf.Max(0, wave.transform.position.y), 0);
        }
        if (wave.transform.position.y > waveLine.transform.position.y)
        {
            waveMultiplier = 2;
        }
        else
        {
            waveMultiplier =  1 ;
        }
        
    }
    public void wavelineupgrade()
    {
        waveLine.transform.position -= new Vector3 (0, 10, 0);
    }
    public void MoveUp()
    {
        isMoving=true;
    }

    public void MoveDown()
    {
        isMoving = false;   
    }

}
