using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairetu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
       int[] array = new int[5];
　　　
       array [0] = 20;
       array [1] = 40;
       array [2] = 60;
       array [3] = 80;
       array [4] = 100;

         for (int i = 0; i < 5; i++)
           {
               Debug.Log(array[i]);
           }      
         for (int i = 4; i >=0; i--)
           {
               Debug.Log(array[i]);
           }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
