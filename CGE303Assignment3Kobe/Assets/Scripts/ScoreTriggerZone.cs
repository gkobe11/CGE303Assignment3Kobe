using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTriggerZone : MonoBehaviour
{
    bool active = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (active)
        {
            active = false;
            ScoreManager.score++;

            //destroy trigger zone
            Destroy(gameObject);
        }
    }
}
