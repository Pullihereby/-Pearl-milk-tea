using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drinkapp : MonoBehaviour
{
    public GameObject dri1;
    public GameObject dri2;
    public GameObject dri3;
    public GameObject dri4;
    public GameObject txts1;
    public GameObject txts2;
    //綠茶
    public Sprite G;
    public Sprite GA;
    public Sprite GJB;
    public Sprite GJI;
    public Sprite GJS;
    public Sprite GBI;
    public Sprite GBS;
    public Sprite GIS;
    //紅茶
    public Sprite R;
    public Sprite RA;
    public Sprite RJB;
    public Sprite RJI;
    public Sprite RJS;
    public Sprite RBI;
    public Sprite RBS;
    public Sprite RIS;
    //奶茶
    public Sprite M;
    public Sprite MA;
    public Sprite MJB;
    public Sprite MJI;
    public Sprite MJS;
    public Sprite MBI;
    public Sprite MBS;
    public Sprite MIS;

    //空
    public Sprite none;
    //亂數
    private int drinkc;
    private int drinkc2;
    private int drinkd;
    private int drinkb;
    private int drinki;
    private int drinks;

    private int start;
    private int start2;

    public GameObject leave1; //最左位離開
    public GameObject leave2; //中位離開

    public GameObject feel1; //最左位離開
    public GameObject feel2; //中位離開
    // Start is called before the first frame update
    void Start()
    {
        start = 1;
        start2 = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(feel1.activeSelf == false)
        {
            dri1.GetComponent<Image>().sprite = none;
            dri2.GetComponent<Image>().sprite = none;
            dri1.SetActive(false);
            dri2.SetActive(false);
        }
        if (feel2.activeSelf == false)
        {
            dri3.GetComponent<Image>().sprite = none;
            dri4.GetComponent<Image>().sprite = none;
            dri3.SetActive(false);
            dri4.SetActive(false);
        }
        if (leave1.activeSelf)
        {
            start = 1;
        }
        if (leave2.activeSelf)
        {
            start2 = 1;
        }
        //第一組
        if (txts1.activeSelf)
        {
            if (start == 1)
            {
                drinkc = Random.Range(1, 3);//有幾杯
                drinkd = Random.Range(1, 4);//1綠茶 2紅茶 3奶茶
                drinkb = Random.Range(1, 3);//1無 2有
                drinks = Random.Range(1, 3);//1無 2有
                drinki = Random.Range(1, 3);//1無 2有

                //杯數判斷
                dri1.SetActive(true);
                if (drinkc == 2) { dri2.SetActive(true); }
                //第一杯生成
                if (drinkd == 1)
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri1.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri1.GetComponent<Image>().sprite = GJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri1.GetComponent<Image>().sprite = GJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri1.GetComponent<Image>().sprite = GJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri1.GetComponent<Image>().sprite = GBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri1.GetComponent<Image>().sprite = GBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri1.GetComponent<Image>().sprite = GIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri1.GetComponent<Image>().sprite = GA; } else { }
                }
                else if (drinkd == 2)
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri1.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri1.GetComponent<Image>().sprite = RJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri1.GetComponent<Image>().sprite = RJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri1.GetComponent<Image>().sprite = RJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri1.GetComponent<Image>().sprite = RBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri1.GetComponent<Image>().sprite = RBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri1.GetComponent<Image>().sprite = RIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri1.GetComponent<Image>().sprite = RA; } else { }
                }
                else if (drinkd == 3)
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri1.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri1.GetComponent<Image>().sprite = MJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri1.GetComponent<Image>().sprite = MJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri1.GetComponent<Image>().sprite = MJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri1.GetComponent<Image>().sprite = MBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri1.GetComponent<Image>().sprite = MBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri1.GetComponent<Image>().sprite = MIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri1.GetComponent<Image>().sprite = MA; } else { }
                }
           
                drinkd = Random.Range(1, 4);//1綠茶 2紅茶 3奶茶
                drinkb = Random.Range(1, 3);//1無 2有
                drinks = Random.Range(1, 3);//1無 2有
                drinki = Random.Range(1, 3);//1無 2有
                 //第二杯生成
                if (drinkd == 1)//第二杯生成
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri2.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri2.GetComponent<Image>().sprite = GJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri2.GetComponent<Image>().sprite = GJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri2.GetComponent<Image>().sprite = GJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri2.GetComponent<Image>().sprite = GBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri2.GetComponent<Image>().sprite = GBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri2.GetComponent<Image>().sprite = GIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri2.GetComponent<Image>().sprite = GA; } else { }
                }
                else if (drinkd == 2)
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri2.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri2.GetComponent<Image>().sprite = RJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri2.GetComponent<Image>().sprite = RJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri2.GetComponent<Image>().sprite = RJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri2.GetComponent<Image>().sprite = RBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri2.GetComponent<Image>().sprite = RBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri2.GetComponent<Image>().sprite = RIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri2.GetComponent<Image>().sprite = RA; } else { }
                }
                else if (drinkd == 3)
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri2.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri2.GetComponent<Image>().sprite = MJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri2.GetComponent<Image>().sprite = MJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri2.GetComponent<Image>().sprite = MJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri2.GetComponent<Image>().sprite = MBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri2.GetComponent<Image>().sprite = MBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri2.GetComponent<Image>().sprite = MIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri2.GetComponent<Image>().sprite = MA; } else { }
                }

                //停止運作
                start = 0;
            }
        }

        //第二組
        if (txts2.activeSelf)
        {
            if (start2 == 1)
            {
                drinkc2 = Random.Range(1, 3);//有幾杯
                drinkd = Random.Range(1, 4);//1綠茶 2紅茶 3奶茶
                drinkb = Random.Range(1, 3);//1無 2有
                drinks = Random.Range(1, 3);//1無 2有
                drinki = Random.Range(1, 3);//1無 2有
                //判斷杯數
                dri3.SetActive(true);
                if (drinkc2 == 2) { dri4.SetActive(true); }
                //第一杯
                if (drinkd == 1)
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri3.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri3.GetComponent<Image>().sprite = GJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri3.GetComponent<Image>().sprite = GJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri3.GetComponent<Image>().sprite = GJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri3.GetComponent<Image>().sprite = GBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri3.GetComponent<Image>().sprite = GBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri3.GetComponent<Image>().sprite = GIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri3.GetComponent<Image>().sprite = GA; } else { }
                }
                else if (drinkd == 2)
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri3.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri3.GetComponent<Image>().sprite = RJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri3.GetComponent<Image>().sprite = RJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri3.GetComponent<Image>().sprite = RJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri3.GetComponent<Image>().sprite = RBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri3.GetComponent<Image>().sprite = RBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri3.GetComponent<Image>().sprite = RIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri3.GetComponent<Image>().sprite = RA; } else { }
                }
                else if (drinkd == 3)
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri3.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri3.GetComponent<Image>().sprite = MJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri3.GetComponent<Image>().sprite = MJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri3.GetComponent<Image>().sprite = MJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri3.GetComponent<Image>().sprite = MBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri3.GetComponent<Image>().sprite = MBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri3.GetComponent<Image>().sprite = MIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri3.GetComponent<Image>().sprite = MA; } else { }
                }
                drinkd = Random.Range(1, 4);//1綠茶 2紅茶 3奶茶
                drinkb = Random.Range(1, 3);//1無 2有
                drinks = Random.Range(1, 3);//1無 2有
                drinki = Random.Range(1, 3);//1無 2有
                //第二杯
                if (drinkd == 1)
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri4.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri4.GetComponent<Image>().sprite = GJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri4.GetComponent<Image>().sprite = GJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri4.GetComponent<Image>().sprite = GJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri4.GetComponent<Image>().sprite = GBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri4.GetComponent<Image>().sprite = GBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri4.GetComponent<Image>().sprite = GIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri4.GetComponent<Image>().sprite = GA; } else { }
                }
                else if (drinkd == 2)
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri4.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri4.GetComponent<Image>().sprite = RJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri4.GetComponent<Image>().sprite = RJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri4.GetComponent<Image>().sprite = RJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri4.GetComponent<Image>().sprite = RBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri4.GetComponent<Image>().sprite = RBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri4.GetComponent<Image>().sprite = RIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri4.GetComponent<Image>().sprite = RA; } else { }
                }
                else if (drinkd == 3)
                {
                    if (drinkb == 1 && drinks == 1 && drinki == 1) { dri4.GetComponent<Image>().sprite = G; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 1) { dri4.GetComponent<Image>().sprite = MJB; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 1) { dri4.GetComponent<Image>().sprite = MJS; }
                    else if (drinkb == 1 && drinks == 1 && drinki == 2) { dri4.GetComponent<Image>().sprite = MJI; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 1) { dri4.GetComponent<Image>().sprite = MBS; }
                    else if (drinkb == 2 && drinks == 1 && drinki == 2) { dri4.GetComponent<Image>().sprite = MBI; }
                    else if (drinkb == 1 && drinks == 2 && drinki == 2) { dri4.GetComponent<Image>().sprite = MIS; }
                    else if (drinkb == 2 && drinks == 2 && drinki == 2) { dri4.GetComponent<Image>().sprite = MA; } else { }
                }

                //停止運作
                start2 = 0;
            }
        }
    }


}
