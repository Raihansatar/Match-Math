using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 20f;
    public static float timeleft;
   public GameObject timesUpText;

    // Start is called before the first frame update
    void Start()
    {
        timesUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        timeleft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            timerBar.fillAmount = timeleft / maxTime;
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;

            SceneManager.LoadScene("DragHighscore");
        }
        
    }
}
