using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnDynamic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

     private void OnTriggerEnter(Collider other){
        if(other.tag== "Player"){
            Debug.Log("Respawn zone was detected");
            SceneManager.LoadScene("Scenes/Level_2");
        }
    }
}
