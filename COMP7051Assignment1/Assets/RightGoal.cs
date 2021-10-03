using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightGoal : MonoBehaviour
{
    public Score score;

    void OnCollisionEnter(Collision col)
    {
        Ball ball = col.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);
            score.leftScore++;
            if (score.leftScore == 5)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
