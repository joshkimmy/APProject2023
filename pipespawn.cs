using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawn : MonoBehaviour
{
    public GameObject pipe;
    public float rate = 2;
    private float time = 0;
    public float location = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
         if (time < rate){
            time = time + Time.deltaTime;
        }
        else{
           spawn();
           time = 0;
        }
    }
    void spawn(){
        float bottom = transform.position.y - location;
        float top = transform.position.y + location;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(bottom, top), 0), transform.rotation);
    }
}
