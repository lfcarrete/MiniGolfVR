using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(GameObject.FindWithTag("Ball")){
            print("entrei");
            Destroy(GameObject.FindWithTag("Ball"));
            // ganhou
        }
    }
}
