using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;




public class Lives : MonoBehaviour
{
    public TextMesh liveBoard;
    public GameObject deathScreenPrefab;
    public Shooter shooterClass;
    public Score scoreClass;
    public int livesCount = 3;

    public bool gameOver = false;

    public void OnCollisionEnter(Collision collision)
    {
        shooterClass.isThereBall = false;
        livesCount--;
        livesCount = livesCount < 0 ? 0 : livesCount;
        liveBoard.text = "Lives: " + livesCount.ToString();

        Destroy(collision.gameObject);

    }

    public void Update()
    {
        if (livesCount == 0 && gameOver == false)
        {
            scoreClass.scoreCount = 0;
            scoreClass.scoreBoard.text = "Score: 0";
            gameOver = true;
            Instantiate(deathScreenPrefab, new Vector3(-2.791f, 3.0f, -5.0f), Quaternion.identity);
            // create end screen text
        }

        


    }

    void OnRestartGame()
    {
        if (gameOver)
        {
            gameOver = false;

            // reset lives
            livesCount = 3;
            liveBoard.text = "Lives: " + livesCount.ToString();

            // reset score
            

            // get rid of end screen text
            Destroy(GameObject.Find("Game_Over_Text(Clone)"));

        }
    }
}

