
//일반적으로 파이썬에서 import 하는 것. 
//외부 모듈가져오는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 게임오버 씬으로 넘어갈 때 필요

// class는 상속받아서 사용. 기본적인 기능이 들어있다고 생각. 
// 스크립트가 기본적으로 class로 받아감. 
public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb; // rigidbody 2d활용해서 점프 만들기.
    public float jumpPower; //접근제한자. 이변수가 공개가 되는 것. 


    // Start is called before the first frame update
    // 코드실행시 단한번 처음에 한번만 실행됨. 
    void Start()
    {
        //Debug.Log("start 입니다."); // 프린트문과 같음.
        rb = GetComponent<Rigidbody2D>(); // rigidbody 2d라는 component 를 rb에 넣겠다는 의미. 
    }

    // Update is called once per frame
    //frame 이란 걸어가는 애니메이션일때 걸어가는 사진 여러개를 연결헤서 만들때 사진.
    //60fps 1초에 60장의 프레임. 
    // 프레임마다 실행. 
        void Update()
    {
        //Debug.Log("update 입니다.");
        // rb component가 뭘하는지 해줌.
        if(Input.GetMouseButtonDown(0))//이때 마우스 왼쪽 버튼누를때
        { // 마우스 클릭이랑 핸드폰 터치랑 같은것으로 취급함. 
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; 
        // = (0,3) (0,1)= vector2


        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        //colider끼리 부딪치면 함수안에 있는 내용을 수행
        //파이프랑 새랑 부딪치면 게임오버 화면으로 넘어가야함. 
        if(Score.score > Score.bestscore){
            Score.bestscore = Score.score;
        }
        SceneManager.LoadScene("GameOverscene");
        // 이떄 "가 아니라 '을 사용하면 오류남.
    }
}
