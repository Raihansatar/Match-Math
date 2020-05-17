using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ManagerLevel : MonoBehaviour
{
    public GameObject Bearblack, Foxblack, Frogblack, Bear, Fox, Frog,  Mice, Cat,  Kancil, Cow, Deer,  Catblack, Miceblack, Kancilblack, Cowblack, Deerblack;
    Vector2  BeariniPost, FoxiniPost, FroginiPost,  MiceiniPost, CatiniPost,  KanciliniPost, CowiniPost, DeeriniPost;
    int x = 0;
    int check, check2;
    int time=0;
    bool check1 = false;
    bool Bearb = true, Foxb = true, Frogb = true, Miceb = true, Catb = true, Kancilb = true, Cowb = true, Deerb = true;
    public GameObject buttonnext1, home;
    private AudioSource bgMusic;
    private AudioSource clickSound;
    void Start()
    {
        clickSound = Deer.GetComponent<AudioSource>();
        bgMusic = GetComponent<AudioSource>();
        int randomnum = Random.Range(0, 5);
        for(int i =0; i < randomnum; i++)
        { randomPos(x);}
        check2 = 0;
        check = 0;
        time = 0;
        BeariniPost =Bear.transform.position;
        FoxiniPost =Fox.transform.position;
        FroginiPost =Frog.transform.position;
        MiceiniPost =Mice.transform.position;
        CatiniPost = Cat.transform.position;
        KanciliniPost = Kancil.transform.position;
        CowiniPost = Cow.transform.position;
        DeeriniPost = Deer.transform.position;

        Cat.SetActive(false);
        Cow.SetActive(false);
        Kancil.SetActive(false);
        Bear.SetActive(false);
        Fox.SetActive(false);
        Frog.SetActive(false);
        Mice.SetActive(false);
        buttonnext1.SetActive(false);
    }

    public void  randomPos(int x)
    {
        Vector2 temp1 = buttonnext1.transform.position;
        Vector2 temp2= buttonnext1.transform.position;
        Vector2 tempswap = buttonnext1.transform.position;
        int max1=0, max2=0;

        if (x == 0)
        {
            max1 = 4;
            max2 = 4;
        }else if (x == 1)
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


        while (num==num2)
        {
            num2 = Random.Range(0, max2);
        }


        switch (num)
        {
            case 0:
                temp1 = Cowblack.transform.position;
                break;
            case 1:
                temp1 = Kancilblack.transform.position;
                break;
            case 2:
                temp1 = Deerblack.transform.position;
                break;
            case 3:
                temp1 = Catblack.transform.position;
                break;
            case 4: 
                temp1 = Miceblack.transform.position;
                break;
            case 5:
                temp1 = Foxblack.transform.position;
                break;
            case 6:
                temp1 = Frogblack.transform.position;
                break;
            case 7:
                temp1 = Bearblack.transform.position;
                break;
        }

        switch (num2)
        {
            case 0:
                temp2 = Cowblack.transform.position;
                break;
            case 1:
                temp2 = Kancilblack.transform.position;
                break;
            case 2:
                temp2 = Deerblack.transform.position;
                break;
            case 3:
                temp2 = Catblack.transform.position;
                break;
            case 4:
                temp2 = Miceblack.transform.position;
                break;
            case 5:
                temp2 = Foxblack.transform.position;
                break;
            case 6:
                temp2 = Frogblack.transform.position;
                break;
            case 7:
                temp2 = Bearblack.transform.position;
                break;
        }

        tempswap = temp1;
        temp1 = temp2;
        temp2 = tempswap;

        switch (num)
        {
            case 0:
                Cowblack.transform.position = temp1;
                break;
            case 1:
                Kancilblack.transform.position = temp1;
                break;
            case 2:
                 Deerblack.transform.position = temp1;
                break;
            case 3:
                Catblack.transform.position = temp1;
                break;
            case 4:
                 Miceblack.transform.position = temp1;
                break;
            case 5:
                Foxblack.transform.position = temp1;
                
                break;
            case 6:
                Frogblack.transform.position = temp1;
                
                break;
            case 7:
                Bearblack.transform.position = temp1;
                
                break;
        }

        switch (num2)
        {
            case 0:
                Cowblack.transform.position = temp2;
                break;
            case 1:
                Kancilblack.transform.position = temp2;
                break;
            case 2:
                Deerblack.transform.position = temp2;
                break;
            case 3:
                Catblack.transform.position = temp2;
                break;
            case 4:
                Miceblack.transform.position = temp2;
                break;
            case 5:
                Foxblack.transform.position = temp2;
                break;
            case 6:
                Frogblack.transform.position = temp2;
                break;
            case 7:
                Bearblack.transform.position = temp2;
                break;
        }
    }

    public void DragMice()
    {
        if (Miceb)
            Mice.transform.position = Input.mousePosition;
    }
    public void DragFrog()
    {
        if(Frogb)
        Frog.transform.position = Input.mousePosition;
    }
    public void DragFox()
    {
        if(Foxb)
        Fox.transform.position = Input.mousePosition;
    }
    public void DragBear()
    {
        if(Bearb)
        Bear.transform.position = Input.mousePosition;
    }
    public void DragCat()
    {
        if(Catb)
        Cat.transform.position = Input.mousePosition;
    }
    public void DragKancil()
    {
        if(Kancilb)
        Kancil.transform.position = Input.mousePosition;
    }
    public void DragCow()
    {
        if(Cowb)
        Cow.transform.position = Input.mousePosition;
    }
    public void DragDeer()
    {
        if (Deerb)
            Deer.transform.position = Input.mousePosition;
        
    }
    public void DropBear()
    {
        float Distance = Vector3.Distance(Bear.transform.position, Bearblack.transform.position);
        if (Distance < 50)
        {
            Bear.transform.position = Bearblack.transform.position;
            ScoreDrag.totalscore += 20;
            clickSound.Play();
            // level3++;
            Bearb = false;
            Fox.SetActive(true); check++;
        }
        else
        {
            Bear.transform.position = BeariniPost;
        }
    }
    public void DropFox()
    {
        float Distance = Vector3.Distance(Fox.transform.position, Foxblack.transform.position);
        if (Distance < 50)
        {
            Fox.transform.position = Foxblack.transform.position;
            ScoreDrag.totalscore += 20;
            clickSound.Play();
            Foxb = false;
            check2++;
          //  level2++;
            Frog.SetActive(true); 
            check++;
        }
        else
        {
            Fox.transform.position = FoxiniPost;
        }
    }
    public void DropFrog()
    {
        float Distance = Vector3.Distance(Frog.transform.position, Frogblack.transform.position);
        if (Distance < 50)
        {
            Frog.transform.position = Frogblack.transform.position;
            ScoreDrag.totalscore += 20;
            clickSound.Play();
            Frogb = false; check++;
            //  level3++;check++;
            Bear.SetActive(true);
        }
        else
        {
            Frog.transform.position = FroginiPost;
        }
    }
    public void DropMice()
    {
        float Distance = Vector3.Distance(Mice.transform.position, Miceblack.transform.position);
        if (Distance < 50)
        {
            Mice.transform.position = Miceblack.transform.position;
            Miceb = false;

            clickSound.Play();
            Fox.SetActive(true);
            ScoreDrag.totalscore += 20;
            check2++;
            // level3++;
            check++;
        }
        else
        {
            Mice.transform.position = MiceiniPost;
        }
    }
    public void DropCat()
    {
        float Distance = Vector3.Distance(Cat.transform.position, Catblack.transform.position);
        if (Distance < 50)
        {
            Cat.transform.position = Catblack.transform.position;
            clickSound.Play();
            Cow.SetActive(true);
            Catb = false;
            ScoreDrag.totalscore += 20;
            check++;
            //   level2++;
            //   level3++;
        }
        else
        {
            Cat.transform.position = CatiniPost;
        }
    }
    public void DropKancil()
    {
        float Distance = Vector3.Distance(Kancil.transform.position, Kancilblack.transform.position);
        if (Distance < 50)
        {
            Kancil.transform.position = Kancilblack.transform.position;
            Mice.SetActive(true);
            clickSound.Play();
            ScoreDrag.totalscore += 20;
            Kancilb = false;
            check++;
            //level2++;
            // level3++;

        }
        else
        {
            Kancil.transform.position = KanciliniPost;
        }
    }
    public void DropCow()
    {
        float Distance = Vector3.Distance(Cow.transform.position, Cowblack.transform.position);
        if (Distance < 50)
        {
            Cow.transform.position = Cowblack.transform.position;
            Kancil.SetActive(true);
            clickSound.Play();
            ScoreDrag.totalscore += 20;
            Cowb = false;
            check++;
            //   level2++;
            //   level3++;


        }
        else
        {
            Cow.transform.position = CowiniPost;
        }
    }
    public void DropDeer()
    {
        float Distance = Vector3.Distance(Deer.transform.position, Deerblack.transform.position);
        if (Distance < 50)
        {
            Deer.transform.position = Deerblack.transform.position;
            
            clickSound.Play();
            Cat.SetActive(true);
            ScoreDrag.totalscore += 20;
            Deerb = false;
            check++;

        }
        else
        {
            Deer.transform.position = DeeriniPost;
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
            SceneManager.LoadScene("DragAndDropAnimalLevel2");
        }
        else if (x == 2)
        {
            ScoreDrag.totalscore += (50 - time);
            SceneManager.LoadScene("DragAndDropAnimalLevel3");
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
        time += (int) Time.deltaTime;
        Debug.Log ( "Check:  " + check1 + "check: " + check + "check2: " + check2);
        

        if (check == 8)
        {
            x = 3;
            buttonnext1.SetActive(true);
        }
        else if (check ==6 && check1)
        {
            x = 2;
            buttonnext1.SetActive(true);
        }
        else if (check ==4 && !check1)
        {
            x = 1;
            buttonnext1.SetActive(true);
            check1 = true;
        }
        
    }
    public void allinactive()
    {
        Cat.SetActive(false);
        Cow.SetActive(false);
        Kancil.SetActive(false);
        Deer.SetActive(false);
        Bearblack.SetActive(false);
        Foxblack.SetActive(false);
        Frogblack.SetActive(false);
        Bear.SetActive(false);
        Fox.SetActive(false);
        Frog.SetActive(false);
        Mice.SetActive(false);
        Deer.SetActive(false);
        Catblack.SetActive(false);
        Miceblack.SetActive(false);
        Kancilblack.SetActive(false);
        Cowblack.SetActive(false);
        Deerblack.SetActive(false); ;

    }
}
