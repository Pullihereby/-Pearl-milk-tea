using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttoncontroler : MonoBehaviour
{
    public GameObject cup1;
    public GameObject cup2;
    public GameObject cup3;

    public int firstcup = 0;
    public int gonextmon = 800;

    public GameObject monAudio = null;
    public GameObject falAudio = null;
    // Start is called before the first frame update
    void Start()
    {
        monok.color = new Color(0, 0, 0, 0);
        firstcup = 1;
        monAudio.SetActive(false); 
        falAudio.SetActive(false);
    }
    int TxtM = 0;
    public Text monok;
    // Update is called once per frame
    void Update()
    {

        if (TxtM >= gonextmon)
        {
            monok.color = new Color(255, 255, 255, 255);
        }
    }
    public void clickCup()
    {
        if (cup1.activeSelf == false && cup2.activeSelf == false && cup3.activeSelf == false)
        {
            cup1.SetActive(true);
        }
        else if(cup1.activeSelf && cup2.activeSelf == false && cup3.activeSelf == false)
        {
            cup2.SetActive(true);
        }
        else if (cup1.activeSelf && cup2.activeSelf && cup3.activeSelf == false)
        {
            cup3.SetActive(true);
        }
    }

    public GameObject red1;
    public GameObject red2;
    public GameObject red3;
    public GameObject green1;
    public GameObject green2;
    public GameObject green3;
    public GameObject milk1;
    public GameObject milk2;
    public GameObject milk3;

    public void clickBlack()
    {
        if (red1.activeSelf == false && cup1.activeSelf && green1.activeSelf == false && milk1.activeSelf == false)
        {
            red1.SetActive(true);
        }
        else if (cup2.activeSelf && red2.activeSelf == false && green2.activeSelf == false && milk2.activeSelf == false && cup1.activeSelf == false)
        {
            red2.SetActive(true);
        }
        else if (cup3.activeSelf && red3.activeSelf == false && green3.activeSelf == false && milk3.activeSelf == false && cup1.activeSelf == false && cup2.activeSelf == false)
        {
            red3.SetActive(true);
        }
        else
        {

        }
    }

    public void clickMilk()
    {
        if (milk1.activeSelf == false && cup1.activeSelf && red1.activeSelf && green1.activeSelf == false)
        {
            red1.SetActive(false);
            milk1.SetActive(true);
        }
        else if (cup2.activeSelf && red2.activeSelf && milk2.activeSelf == false && green2.activeSelf == false && cup1.activeSelf == false)
        {
            red2.SetActive(false);
            milk2.SetActive(true);
        }
        else if (cup3.activeSelf && red3.activeSelf && milk3.activeSelf == false && green3.activeSelf == false && cup1.activeSelf == false && cup2.activeSelf == false)
        {
            red3.SetActive(false);
            milk3.SetActive(true);
        }
        else
        {

        }
    }

    public void clickGreen()
    {
        if (green1.activeSelf == false && cup1.activeSelf && red1.activeSelf == false && milk1.activeSelf == false)
        {
            green1.SetActive(true);
        }
        else if (cup2.activeSelf && green2.activeSelf == false && red2.activeSelf == false && milk2.activeSelf == false && cup1.activeSelf == false)
        {
            green2.SetActive(true);
        }
        else if (cup3.activeSelf && green3.activeSelf == false && red3.activeSelf == false && milk3.activeSelf == false && cup1.activeSelf == false && cup2.activeSelf == false)
        {
            green3.SetActive(true);
        }
        else
        {

        }
    }

    public GameObject bub1;
    public GameObject bub2;
    public GameObject bub3;

    public void clickBub()
    {
        if ((red1.activeSelf || green1.activeSelf || milk1.activeSelf) && bub1.activeSelf == false && cup1.activeSelf)
        {
            bub1.SetActive(true);
        }
        else if ((red2.activeSelf || green2.activeSelf || milk2.activeSelf) && cup1.activeSelf == false && cup2.activeSelf && bub2.activeSelf == false)
        {
            bub2.SetActive(true);
        }
        else if ((red3.activeSelf || green3.activeSelf || milk3.activeSelf) && cup1.activeSelf == false && cup2.activeSelf == false && cup3.activeSelf && bub3.activeSelf == false)
        {
            bub3.SetActive(true);
        }
        else
        {
        }
    }

    public GameObject sugar1;
    public GameObject sugar2;
    public GameObject sugar3;

    public void clickSug()
    {
        if ((red1.activeSelf || green1.activeSelf || milk1.activeSelf) && sugar1.activeSelf == false && cup1.activeSelf)
        {
            sugar1.SetActive(true);
        }
        else if ((red2.activeSelf || green2.activeSelf || milk2.activeSelf) && cup1.activeSelf == false && cup2.activeSelf && sugar2.activeSelf == false)
        {
            sugar2.SetActive(true);
        }
        else if ((red3.activeSelf || green3.activeSelf || milk3.activeSelf) && cup1.activeSelf == false && cup2.activeSelf == false && cup3.activeSelf && sugar3.activeSelf == false)
        {
            sugar3.SetActive(true);
        }
        else
        {
        }
    }

    public GameObject ice1;
    public GameObject ice2;
    public GameObject ice3;

    public void clickIce()
    {
        if ((red1.activeSelf || green1.activeSelf || milk1.activeSelf) && ice1.activeSelf == false && cup1.activeSelf)
        {
            ice1.SetActive(true);
        }
        else if ((red2.activeSelf || green2.activeSelf || milk2.activeSelf) && cup1.activeSelf == false && cup2.activeSelf && ice2.activeSelf == false)
        {
            ice2.SetActive(true);
        }
        else if ((red3.activeSelf || green3.activeSelf || milk3.activeSelf) && cup1.activeSelf == false && cup2.activeSelf == false && cup3.activeSelf && ice3.activeSelf == false)
        {
            ice3.SetActive(true);
        }
        else
        {

        }
    }

    public GameObject lid1;
    public GameObject lid2;
    public GameObject lid3;

    public GameObject dri1;
    public GameObject dri2;
    public GameObject dri3;
    public GameObject dri4;
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

    public GameObject txts1;
    public GameObject txts2;
    public Sprite none;

    public Text money;
  
    int openc1 = 1;
    int openc2 = 0;
    int openc3 = 0;

    public GameObject leave1;
    public GameObject leave2;

    public GameObject angry1;
    public GameObject angry2;

    private int G1;  //到達位置
    private int G2;  //到達位置
    public void clickLid()
    {
        //現正使用?杯
        if (cup1.activeSelf) { openc1 = 1; openc2 = 0; openc3 = 0; monAudio.SetActive(false); falAudio.SetActive(false); } else if (cup2.activeSelf == false) { openc3 = 1; monAudio.SetActive(false); falAudio.SetActive(false); } else if (cup1.activeSelf == false) { openc2 = 1; monAudio.SetActive(false); falAudio.SetActive(false); }

        //配對判斷
        if (openc1 == 1)
        {//第一杯
            if (green1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf == false && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); falAudio.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); falAudio.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); falAudio.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); falAudio.SetActive(true); } else { } }
            }//純綠
            else if (green1.activeSelf && bub1.activeSelf && sugar1.activeSelf && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠All
            else if (green1.activeSelf && bub1.activeSelf && sugar1.activeSelf == false && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+珍珠
            else if (green1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf == false && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+冰
            else if (green1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+糖
            else if (green1.activeSelf && bub1.activeSelf && sugar1.activeSelf == false && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+珍珠+冰
            else if (green1.activeSelf && bub1.activeSelf && sugar1.activeSelf && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+珍珠+糖
            else if (green1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+冰+糖
            else if (red1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf == false && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//純紅
            else if (red1.activeSelf && bub1.activeSelf && sugar1.activeSelf && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅All
            else if (red1.activeSelf && bub1.activeSelf && sugar1.activeSelf == false && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+珍珠
            else if (red1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf == false && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+冰
            else if (red1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+糖
            else if (red1.activeSelf && bub1.activeSelf && sugar1.activeSelf == false && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+珍珠+冰
            else if (red1.activeSelf && bub1.activeSelf && sugar1.activeSelf && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+珍珠+糖
            else if (red1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+冰+糖
            else if (milk1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf == false && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//純奶
            else if (milk1.activeSelf && bub1.activeSelf && sugar1.activeSelf && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶All
            else if (milk1.activeSelf && bub1.activeSelf && sugar1.activeSelf == false && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+珍珠
            else if (milk1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf == false && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+冰
            else if (milk1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+糖
            else if (milk1.activeSelf && bub1.activeSelf && sugar1.activeSelf == false && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+珍珠+冰
            else if (milk1.activeSelf && bub1.activeSelf && sugar1.activeSelf && ice1.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+珍珠+糖
            else if (milk1.activeSelf && bub1.activeSelf == false && sugar1.activeSelf && ice1.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup1.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup1.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+冰+糖
            else { }
            openc1 = 0;
        }
        else if (openc1 == 0 && openc2 == 1)
        {
            //第二杯
            if (green2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf == false && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//純綠
            else if (green2.activeSelf && bub2.activeSelf && sugar2.activeSelf && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠All
            else if (green2.activeSelf && bub2.activeSelf && sugar2.activeSelf == false && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+珍珠
            else if (green2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf == false && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+冰
            else if (green2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+糖
            else if (green2.activeSelf && bub2.activeSelf && sugar2.activeSelf == false && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+珍珠+冰
            else if (green2.activeSelf && bub2.activeSelf && sugar2.activeSelf && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+珍珠+糖
            else if (green2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+冰+糖
            else if (red2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf == false && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//純紅
            else if (red2.activeSelf && bub2.activeSelf && sugar2.activeSelf && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅All
            else if (red2.activeSelf && bub2.activeSelf && sugar2.activeSelf == false && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+珍珠
            else if (red2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf == false && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+冰
            else if (red2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+糖
            else if (red2.activeSelf && bub2.activeSelf && sugar2.activeSelf == false && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+珍珠+冰
            else if (red2.activeSelf && bub2.activeSelf && sugar2.activeSelf && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+珍珠+糖
            else if (red2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+冰+糖
            else if (milk2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf == false && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//純奶
            else if (milk2.activeSelf && bub2.activeSelf && sugar2.activeSelf && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶All
            else if (milk2.activeSelf && bub2.activeSelf && sugar2.activeSelf == false && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+珍珠
            else if (milk2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf == false && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+冰
            else if (milk2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+糖
            else if (milk2.activeSelf && bub2.activeSelf && sugar2.activeSelf == false && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+珍珠+冰
            else if (milk2.activeSelf && bub2.activeSelf && sugar2.activeSelf && ice2.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+珍珠+糖
            else if (milk2.activeSelf && bub2.activeSelf == false && sugar2.activeSelf && ice2.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup2.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup2.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+冰+糖
            else { }
            openc2 = 0;
        }
        else if (openc1 == 0 && openc2 == 0 && openc3 == 1)
        {
            //第三杯
            if (green3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf == false && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == G) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//純綠
            else if (green3.activeSelf && bub3.activeSelf && sugar3.activeSelf && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠All
            else if (green3.activeSelf && bub3.activeSelf && sugar3.activeSelf == false && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+珍珠
            else if (green3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf == false && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+冰
            else if (green3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+糖
            else if (green3.activeSelf && bub3.activeSelf && sugar3.activeSelf == false && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+珍珠+冰
            else if (green3.activeSelf && bub3.activeSelf && sugar3.activeSelf && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+珍珠+糖
            else if (green3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == GIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//綠+冰+糖
            else if (red3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf == false && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == R) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//純紅
            else if (red3.activeSelf && bub3.activeSelf && sugar3.activeSelf && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅All
            else if (red3.activeSelf && bub3.activeSelf && sugar3.activeSelf == false && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+珍珠
            else if (red3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf == false && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+冰
            else if (red3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+糖
            else if (red3.activeSelf && bub3.activeSelf && sugar3.activeSelf == false && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+珍珠+冰
            else if (red3.activeSelf && bub3.activeSelf && sugar3.activeSelf && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+珍珠+糖
            else if (red3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == RIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//紅+冰+糖
            else if (milk3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf == false && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == M) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//純奶
            else if (milk3.activeSelf && bub3.activeSelf && sugar3.activeSelf && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MA) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶All
            else if (milk3.activeSelf && bub3.activeSelf && sugar3.activeSelf == false && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MJB) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+珍珠
            else if (milk3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf == false && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MJI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+冰
            else if (milk3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MJS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+糖
            else if (milk3.activeSelf && bub3.activeSelf && sugar3.activeSelf == false && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MBI) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+珍珠+冰
            else if (milk3.activeSelf && bub3.activeSelf && sugar3.activeSelf && ice3.activeSelf == false)
            {
                if (dri1.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MBS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+珍珠+糖
            else if (milk3.activeSelf && bub3.activeSelf == false && sugar3.activeSelf && ice3.activeSelf)
            {
                if (dri1.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri1.SetActive(false); monAudio.SetActive(true); }
                else if (dri2.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri2.SetActive(false); monAudio.SetActive(true); }
                else if (dri3.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri3.SetActive(false); monAudio.SetActive(true); }
                else if (dri4.GetComponent<Image>().sprite == MIS) { TxtM += 80; money.text = TxtM + ""; cup3.SetActive(false); dri4.SetActive(false); monAudio.SetActive(true); }
                else { cup3.SetActive(false); falAudio.SetActive(true); if (dri1.activeSelf) { dri1.SetActive(false); angry1.SetActive(true); } else if (dri2.activeSelf) { dri2.SetActive(false); angry1.SetActive(true); } else if (dri3.activeSelf) { dri3.SetActive(false); angry2.SetActive(true); } else if (dri4.activeSelf) { dri4.SetActive(false); angry2.SetActive(true); } else { } }
            }//奶+冰+糖
            else { }
            openc3 = 1;
        }

        //清除txt
        if (dri3.activeSelf == false && dri4.activeSelf == false){txts2.SetActive(false); leave2.SetActive(true); }
        if (dri1.activeSelf == false && dri2.activeSelf == false){txts1.SetActive(false); leave1.SetActive(true); }
        //櫃檯的杯子消失
        if (cup1.activeSelf == false)
        {
            green1.SetActive(false);
            red1.SetActive(false);
            milk1.SetActive(false);
            bub1.SetActive(false);
            sugar1.SetActive(false);
            ice1.SetActive(false);
        }
        if (cup2.activeSelf == false)
        {
            green2.SetActive(false);
            red2.SetActive(false);
            milk2.SetActive(false);
            bub2.SetActive(false);
            sugar2.SetActive(false);
            ice2.SetActive(false);
        }
        if (cup3.activeSelf == false)
        {
            green3.SetActive(false);
            red3.SetActive(false);
            milk3.SetActive(false);
            bub3.SetActive(false);
            sugar3.SetActive(false);
            ice3.SetActive(false);
        }
        //清除點單
        if (dri1.activeSelf == false) { dri1.GetComponent<Image>().sprite = none; };
        if (dri2.activeSelf == false) { dri2.GetComponent<Image>().sprite = none; };
        if (dri3.activeSelf == false) { dri3.GetComponent<Image>().sprite = none; };
        if (dri4.activeSelf == false) { dri4.GetComponent<Image>().sprite = none; };
        

    }
}
