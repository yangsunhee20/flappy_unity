using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; //(-1,0,0)
        //6fps 와 3fps 를 같은 프레임으로 맞춰주기 위한 delta time 
        //Debug.Log(transform.position);
    }
}
