using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 유니티 엔진의 ui가져오기 

public class Score : MonoBehaviour
{

    public static int score = 0 ; 
    // 외부에서도 변경가능하게 하려면 public을 사용해야함.
    // static --> 인스턴스 생성없이 클래스에서 관리
    public static int bestscore = 0;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        // 게임 오버 된 다음에 다시 시작할때 0점부터 시작
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString();// = str(score)
    }
}
