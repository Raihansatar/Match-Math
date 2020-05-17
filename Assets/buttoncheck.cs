using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoncheck : MonoBehaviour
{

    public void homebutton()
    {
        SceneManager.LoadScene("MainMenu");
        ScoreDrag.totalscore = 0;
    }

    public void Mode()
    {
        SceneManager.LoadScene("DragMenu");
        ScoreDrag.totalscore = 0;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
