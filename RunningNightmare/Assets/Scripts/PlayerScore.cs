using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    //Starting timer for game.
    [SerializeField]private float timer;
    
    //Visual for timer with real-time seconds.
    [SerializeField]private TextMeshProUGUI score;

    // Update is called once per frame
    void Update()
    {
        //if Player isn't dead, score increases.
        timer += Time.deltaTime;

        //If player evades obstacle, score inscreases by x.

        DisplayTime(timer);
    }
    private void DisplayTime(float time)
    {
        score.text = string.Format("{0}", (int)time);
    }

}
