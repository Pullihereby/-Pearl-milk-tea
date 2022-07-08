using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endcontrol : MonoBehaviour
{
    public Text timer_time;
    public Text money;
    public Text monok;
    public Text nowtime;

    public GameObject con;
    public GameObject fail;

    public GameObject bg;
    public GameObject ex;
    public GameObject re;
    public GameObject ex5;

    public GameObject conAudio = null;
    public GameObject falAudio = null;
    public GameObject backAudio = null;

    public int is5 = 0;

    // Start is called before the first frame update
    void Start()
    {
        falAudio.SetActive(false);
        conAudio.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (nowtime.color == new Color(255, 255, 255, 255)) 
        {
            bg.SetActive(true);
            fail.SetActive(true);
            ex.SetActive(true);
            re.SetActive(true);
            backAudio.SetActive(false); 
            falAudio.SetActive(true);
            Time.timeScale = 0f;
        }

        if(monok.color == new Color(255, 255, 255, 255))
        {
            if(is5 == 0) 
            {
                ex.SetActive(true);
                bg.SetActive(true);
                con.SetActive(true);
                ex5.SetActive(true);
                Time.timeScale = 0f;
                backAudio.SetActive(false);
                conAudio.SetActive(true);
            }
            else if(is5 == 1)
            {
                bg.SetActive(true);
                con.SetActive(true);
                ex5.SetActive(true);
                Time.timeScale = 0f;
                backAudio.SetActive(false);
                conAudio.SetActive(true);
            }
        }
    }

    public void Clicknext1()
    {
        Application.LoadLevel("Level2");
    }
    public void Clicknext2()
    {
        Application.LoadLevel("Level3");
    }
    public void Clicknext3()
    {
        Application.LoadLevel("Level4");
    }
    public void Clicknext4()
    {
        Application.LoadLevel("Level5");
    }

    public void Clickretry1()
    {
        Application.LoadLevel("Level1");
    }

    public void Clickretry2()
    {
        Application.LoadLevel("Level2");
    }

    public void Clickretry3()
    {
        Application.LoadLevel("Level3");
    }

    public void Clickretry4()
    {
        Application.LoadLevel("Level4");
    }

    public void Clickretry5()
    {
        Application.LoadLevel("Level5");
    }

    public void Clickexit()
    {
        Application.LoadLevel("Map");
    }
}
