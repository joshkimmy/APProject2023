using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemover : MonoBehaviour
{
    public float pipeMove = 15;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeMove) * Time.deltaTime;
        
       
    }
}
