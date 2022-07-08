using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class feelcontrol : MonoBehaviour
{
    public Image feel;
    public Image feelBK;
    public Sprite G;
    public Sprite GBK;
    public Sprite R;
    public Sprite RBK;
    public GameObject txt;
    //最大
    public float Maxfeel = 300;
    //當前
    private float nowfeel1;

    public GameObject leave1;

    public GameObject feeldoing1;

    public GameObject angry1;
    // Start is called before the first frame update
    void Start()
    {
        nowfeel1 = Maxfeel;
    }

    // Update is called once per frame
    void Update()
    {
        if (txt.activeSelf) 
        {
            feel.color = new Color(255, 255, 255, 255);
            feelBK.color = new Color(255, 255, 255, 255);
            nowfeel1 -= Time.deltaTime * 10;
            if (nowfeel1 < 0)
            {
                txt.SetActive(false);
                feel.color = new Color(0, 0, 0, 0);
                feelBK.color = new Color(0, 0, 0, 0);
                leave1.SetActive(true);
                angry1.SetActive(true);
                feeldoing1.SetActive(false);
                nowfeel1 = Maxfeel;
                changeeFeelBar1();
            }
            else
            {
                updateFeelBar1();
                changeeFeelBar1();
            }
        }
        else
        {
            feel.color = new Color(0, 0, 0, 0);
            feelBK.color = new Color(0, 0, 0, 0);
            nowfeel1 = Maxfeel;
        }

    }
    void updateFeelBar1()
    {
        feel.fillAmount = nowfeel1 / Maxfeel;
    }

    void changeeFeelBar1()
    {
        if (nowfeel1 > 150) { feel.GetComponent<Image>().sprite = G; feelBK.GetComponent<Image>().sprite = GBK; }
        else if (nowfeel1 <= 110) { feel.GetComponent<Image>().sprite = R; feelBK.GetComponent<Image>().sprite = RBK; }
    }
}
