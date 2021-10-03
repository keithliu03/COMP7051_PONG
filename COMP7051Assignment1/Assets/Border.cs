using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public Score score;

    void OnCollisionEnter(Collision col)
    {
        Ball ball = col.gameObject.GetComponent<Ball>();
        
        if(ball!=null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);

            if (col.gameObject.name == "WallRight")
            {
                score.leftScore++;
            }
            else if (col.gameObject.name == "WallLeft")
            {
                score.rightScore++;
            }
        }
    }
}
