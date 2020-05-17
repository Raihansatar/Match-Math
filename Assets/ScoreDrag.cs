using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDrag : MonoBehaviour
{ 

    public static int totalscore = 0;
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = "Score: " + totalscore; 
    }
}
