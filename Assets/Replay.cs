using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
   public void ReplayGame() // void 리턴값이 없다.
   {
        SceneManager.LoadScene("PlayScene");
   }
}
