using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu_Hexa : MonoBehaviour
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
        if(GameObject.FindWithTag("FlagHexa")){
            SceneManager.LoadScene("HexaLevel");
        }

        if(GameObject.FindWithTag("FlagCandy")){
            SceneManager.LoadScene("CandyLevel");
        }

        if(GameObject.FindWithTag("FlagMoon")){
            SceneManager.LoadScene("MoonLevel");
        }
    }
}
