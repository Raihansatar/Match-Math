using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FruitManager : MonoBehaviour
{
    public GameObject Fruit7black, Fruit5black, Fruit8black, Fruit7, Fruit5, Fruit8, Fruit6, Fruit1, Fruit3, Fruit2, Fruit4, Fruit1black, Fruit6black, Fruit3black, Fruit2black, Fruit4black;
    Vector2 Fruit7iniPost, Fruit5iniPost, Fruit8iniPost, Fruit6iniPost, Fruit1iniPost, Fruit3iniPost, Fruit2iniPost, Fruit4iniPost;
    int x = 0;
    int check, check2;
    int time = 0;
    bool check1 = false;
    bool Bearb = true, Foxb = true, Frogb = true, Miceb = true, Fruit1b = true, Kancilb = true, Cowb = true, Deerb = true;
    public GameObject buttonnext1, home;
    private AudioSource bgMusic;
    private AudioSource clickSound;
    void Start()
    {
        bgMusic = GetComponent<AudioSource>();
        clickSound = Fruit1.GetComponent<AudioSource>();
        int randomnum = Random.Range(0, 5);
        for (int i = 0; i < randomnum; i++)
        { randomPos(x); }
        check2 = 0;
        check = 0;
        time = 0;
        Fruit7iniPost = Fruit7.transform.position;
        Fruit5iniPost = Fruit5.transform.position;
        Fruit8iniPost = Fruit8.transform.position;
        Fruit6iniPost = Fruit6.transform.position;
        Fruit1iniPost = Fruit1.transform.position;
        Fruit3iniPost = Fruit3.transform.position;
        Fruit2iniPost = Fruit2.transform.position;
        Fruit4iniPost = Fruit4.transform.position;

        Fruit1.SetActive(false); //cat
        Fruit2.SetActive(false); //cow
        Fruit3.SetActive(false); //kancil
        //deer fruit4

        Fruit7.SetActive(false); //bear
        Fruit8.SetActive(false); //frog

        Fruit5.SetActive(false); //fox
        Fruit6.SetActive(false); //mice
        buttonnext1.SetActive(false);
    }

    public void randomPos(int x)
    {
        Vector2 temp1 = buttonnext1.transform.position;
        Vector2 temp2 = buttonnext1.transform.position;
        Vector2 tempswap = buttonnext1.transform.position;
        int max1 = 0, max2 = 0;

        if (x == 0)
        {
            max1 = 4;
            max2 = 4;
        }
        else if (x == 1)
        {
            max1 = 6;
            max2 = 6;
        }
        else
        {
            max1 = 8;
            max2 = 8;
        }



        int num = Random.Range(0, max1);
        int num2 = Random.Range(0, max2);


        while (num == num2)
        {
            num2 = Random.Range(0, max2);
        }


        switch (num)
        {
            case 0:
                temp1 = Fruit2black.transform.position;
                break;
            case 1:
                temp1 = Fruit3black.transform.position;
                break;
            case 2:
                temp1 = Fruit4black.transform.position;
                break;
            case 3:
                temp1 = Fruit1black.transform.position;
                break;
            case 4:
                temp1 = Fruit6black.transform.position;
                break;
            case 5:
                temp1 = Fruit5black.transform.position;
                break;
            case 6:
                temp1 = Fruit8black.transform.position;
                break;
            case 7:
                temp1 = Fruit7black.transform.position;
                break;
        }

        switch (num2)
        {
            case 0:
                temp2 = Fruit2black.transform.position;
                break;
            case 1:
                temp2 = Fruit3black.transform.position;
                break;
            case 2:
                temp2 = Fruit4black.transform.position;
                break;
            case 3:
                temp2 = Fruit1black.transform.position;
                break;
            case 4:
                temp2 = Fruit6black.transform.position;
                break;
            case 5:
                temp2 = Fruit5black.transform.position;
                break;
            case 6:
                temp2 = Fruit8black.transform.position;
                break;
            case 7:
                temp2 = Fruit7black.transform.position;
                break;
        }

        tempswap = temp1;
        temp1 = temp2;
        temp2 = tempswap;

        switch (num)
        {
            case 0:
                Fruit2black.transform.position = temp1;
                break;
            case 1:
                Fruit3black.transform.position = temp1;
                break;
            case 2:
                Fruit4black.transform.position = temp1;
                break;
            case 3:
                Fruit1black.transform.position = temp1;
                break;
            case 4:
                Fruit6black.transform.position = temp1;
                break;
            case 5:
                Fruit5black.transform.position = temp1;

                break;
            case 6:
                Fruit8black.transform.position = temp1;

                break;
            case 7:
                Fruit7black.transform.position = temp1;

                break;
        }

        switch (num2)
        {
            case 0:
                Fruit2black.transform.position = temp2;
                break;
            case 1:
                Fruit3black.transform.position = temp2;
                break;
            case 2:
                Fruit4black.transform.position = temp2;
                break;
            case 3:
                Fruit1black.transform.position = temp2;
                break;
            case 4:
                Fruit6black.transform.position = temp2;
                break;
            case 5:
                Fruit5black.transform.position = temp2;
                break;
            case 6:
                Fruit8black.transform.position = temp2;
                break;
            case 7:
                Fruit7black.transform.position = temp2;
                break;
        }
    }

    public void DragMice()
    {
        if (Miceb)
            Fruit6.transform.position = Input.mousePosition;
    }
    public void DragFrog()
    {
        if (Frogb)
            Fruit8.transform.position = Input.mousePosition;
    }
    public void DragFox()
    {
        if (Foxb)
            Fruit5.transform.position = Input.mousePosition;
    }
    public void DragBear()
    {
        if (Bearb)
            Fruit7.transform.position = Input.mousePosition;
    }
    public void DragCat()
    {
        if (Fruit1b)
            Fruit1.transform.position = Input.mousePosition;
    }
    public void DragKancil()
    {
        if (Kancilb)
            Fruit3.transform.position = Input.mousePosition;
    }
    public void DragCow()
    {
        if (Cowb)
            Fruit2.transform.position = Input.mousePosition;
    }
    public void DragDeer()
    {
        if (Deerb)
            Fruit4.transform.position = Input.mousePosition;

    }
    public void DropBear()
    {
        float Distance = Vector3.Distance(Fruit7.transform.position, Fruit7black.transform.position);
        if (Distance < 50)
        {
            Fruit7.transform.position = Fruit7black.transform.position;
            ScoreDrag.totalscore += 20; clickSound.Play();
            // level3++;
            Bearb = false;
            Fruit5.SetActive(true); check++;
        }
        else
        {
            Fruit7.transform.position = Fruit7iniPost;
        }
    }
    public void DropFox()
    {
        float Distance = Vector3.Distance(Fruit5.transform.position, Fruit5black.transform.position);
        if (Distance < 50)
        {
            Fruit5.transform.position = Fruit5black.transform.position;
            ScoreDrag.totalscore += 20; clickSound.Play();
            Foxb = false;
            check2++;
            //  level2++;
            Fruit8.SetActive(true);
            check++;
        }
        else
        {
            Fruit5.transform.position = Fruit5iniPost;
        }
    }
    public void DropFrog()
    {
        float Distance = Vector3.Distance(Fruit8.transform.position, Fruit8black.transform.position);
        if (Distance < 50)
        {
            Fruit8.transform.position = Fruit8black.transform.position;
            ScoreDrag.totalscore += 20;
            Frogb = false; check++; clickSound.Play();
            //  level3++;check++;
            Fruit7.SetActive(true);
        }
        else
        {
            Fruit8.transform.position = Fruit8iniPost;
        }
    }
    public void DropMice()
    {
        float Distance = Vector3.Distance(Fruit6.transform.position, Fruit6black.transform.position);
        if (Distance < 50)
        {
            Fruit6.transform.position = Fruit6black.transform.position;
            Miceb = false;
            clickSound.Play();
            Fruit5.SetActive(true);
            ScoreDrag.totalscore += 20;
            check2++;
            // level3++;
            check++;
        }
        else
        {
            Fruit6.transform.position = Fruit6iniPost;
        }
    }
    public void DropCat()
    {
        float Distance = Vector3.Distance(Fruit1.transform.position, Fruit1black.transform.position);
        if (Distance < 50)
        {
            Fruit1.transform.position = Fruit1black.transform.position;
            Fruit2.SetActive(true);
            Fruit1b = false; clickSound.Play();
            ScoreDrag.totalscore += 20;
            check++;
            //   level2++;
            //   level3++;
        }
        else
        {
            Fruit1.transform.position = Fruit1iniPost;
        }
    }
    public void DropKancil()
    {
        float Distance = Vector3.Distance(Fruit3.transform.position, Fruit3black.transform.position);
        if (Distance < 50)
        {
            Fruit3.transform.position = Fruit3black.transform.position;
            Fruit6.SetActive(true); clickSound.Play();
            ScoreDrag.totalscore += 20;
            Kancilb = false;
            check++;
            //level2++;
            // level3++;

        }
        else
        {
            Fruit3.transform.position = Fruit3iniPost;
        }
    }
    public void DropCow()
    {
        float Distance = Vector3.Distance(Fruit2.transform.position, Fruit2black.transform.position);
        if (Distance < 50)
        {
            Fruit2.transform.position = Fruit2black.transform.position;
            Fruit3.SetActive(true); clickSound.Play();
            ScoreDrag.totalscore += 20;
            Cowb = false;
            check++;
            //   level2++;
            //   level3++;


        }
        else
        {
            Fruit2.transform.position = Fruit2iniPost;
        }
    }
    public void DropDeer()
    {
        float Distance = Vector3.Distance(Fruit4.transform.position, Fruit4black.transform.position);
        if (Distance < 50)
        {
            Fruit4.transform.position = Fruit4black.transform.position;
            Fruit1.SetActive(true); clickSound.Play();
            ScoreDrag.totalscore += 20;
            Deerb = false;
            check++;
        }
        else
        {
            Fruit4.transform.position = Fruit4iniPost;
        }
    }
    public void homebutton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void nextbutton1()
    {
        if (x == 0)
            home.SetActive(false);
        else if (x == 1)
        {
            ScoreDrag.totalscore += (50 - time);
            SceneManager.LoadScene("DragAndDropFruitLevel2");
        }
        else if (x == 2)
        {
            ScoreDrag.totalscore += (50 - time);
            SceneManager.LoadScene("DragAndDropFruitLevel3");
        }
        else if (x == 3)
        {
            SceneManager.LoadScene("DragHighscore");
        }
        else
        {
        }

    }

    void Update()
    {
        time += (int)Time.deltaTime;
        Debug.Log("Check:  " + check1 + "check: " + check + "check2: " + check2);


        if (check == 8)
        {
            x = 3;
            buttonnext1.SetActive(true);
        }
        else if (check == 6)
        {
            x = 2;
            buttonnext1.SetActive(true);
        }
        else if (check == 4  )
        {
            x = 1;
            buttonnext1.SetActive(true);
           // check1 = true;
        }

    }
    public void allinactive()
    {
        Fruit1.SetActive(false);
        Fruit2.SetActive(false);
        Fruit3.SetActive(false);
        Fruit4.SetActive(false);
        Fruit7black.SetActive(false);
        Fruit5black.SetActive(false);
        Fruit8black.SetActive(false);
        Fruit7.SetActive(false);
        Fruit5.SetActive(false);
        Fruit8.SetActive(false);
        Fruit6.SetActive(false);
        Fruit4.SetActive(false);
        Fruit1black.SetActive(false);
        Fruit6black.SetActive(false);
        Fruit3black.SetActive(false);
        Fruit2black.SetActive(false);
        Fruit4black.SetActive(false); ;

    }
}
