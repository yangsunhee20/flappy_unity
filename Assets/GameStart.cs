using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
   public void StartGame() // void 리턴값이 없다.
   {
        SceneManager.LoadScene("PlayScene");
   }
}
