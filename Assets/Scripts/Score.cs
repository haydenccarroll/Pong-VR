using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMesh scoreBoard;
    public int scoreCount;

    public void OnCollisionEnter(Collision collision)
    {
        scoreCount++;
        scoreBoard.text = "Score: " + scoreCount.ToString();
    }
}
