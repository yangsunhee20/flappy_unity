
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // 6fps에서는 6번 모여서 1이되었을때 넘어감. 
        if (timer > timeDiff) // 1초마다 파이프 생성. 
        {
            GameObject newpipe = Instantiate(Pipe); 
            // 게임 오브젝트를 newpipe로 받아서 생성.
            newpipe.transform.position = new Vector3(2,Random.Range(-1.5f, 4.2f),0); 
            // f= 실수형 자료를 의미.
            timer = 0;
            Destroy(newpipe, 6.0f); // 생성된 파이프 삭제
        }
       
    }
}
