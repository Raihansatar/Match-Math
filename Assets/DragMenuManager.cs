using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragMenuManager : MonoBehaviour
{
    // Start is called before the first frame update

    private AudioSource bgMusic;
    void Start()
    {
        bgMusic = GetComponent<AudioSource>();
    }

    public void AnimalButton()
    {
        SceneManager.LoadScene("DragAndDropAnimalLevel1");
    }

    public void FruitButton()
    {
        SceneManager.LoadScene("DragAndDropFruitLevel1");
    }

    public void FoodButton()
    {
        SceneManager.LoadScene("DragAndDropFruitLevel1");
    }

    public void ObjectButton()
    {
        SceneManager.LoadScene("DragAndDropObjectLevel1");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
