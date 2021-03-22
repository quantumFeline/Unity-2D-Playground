using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;

    public void RaiseScore()
    {
        score++;
        if (score == 3)
        {
            Debug.Log("You won!");
            GameObject.Find("WinSprite").GetComponent<Renderer>().enabled = true;
            SceneManager.LoadScene("Scene2");
        }
    }
}
