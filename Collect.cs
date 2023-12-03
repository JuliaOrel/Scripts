using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public int speed_rotation=2;
    static public int amount_mushrooms=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1, speed_rotation*Time.deltaTime,0);
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag== "Player"){
            Destroy(gameObject);
            amount_mushrooms++;
            Debug.Log("Object was collected "+ amount_mushrooms);
        }
    }
}
