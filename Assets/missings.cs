using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections.Generic;

public class missings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[]){
            var flag = false;
            foreach(Component comp in go.GetComponents<Component>()){
                if(comp == null){
                    flag = true;
                }
            }
            if(flag == true){
                Debug.Log(go.name);
            }
        }
        Debug.Log("check finished");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
