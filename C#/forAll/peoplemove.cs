using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class peoplemove : MonoBehaviour
{
    public GameObject PathA;//起點
    public GameObject PathB;//終點1
    public GameObject PathC;//終點2
    public GameObject PathD;//終點2
    public GameObject Obj1;//要移動的物件1
    public GameObject Obj2;//要移動的物件2
    public GameObject Obj3;//要移動的物件3
    public float speed = 0.5f;//移動速度
    public float speed1 = 1f;//移動速度
    public float speed2 = 0.5f;//移動速度
    public float speed3 = 0.5f;//移動速度

    private float firstSpeedA1;//紀錄第一次移動的距離
    private float firstSpeedA2;//紀錄第一次移動的距離
    private float firstSpeedA3;//紀錄第一次移動的距離
    private float firstSpeedA4;//紀錄第一次移動的距離

    private float firstSpeedB1;//紀錄第一次移動的距離
    private float firstSpeedB2;//紀錄第一次移動的距離
    private float firstSpeedB3;//紀錄第一次移動的距離
    private float firstSpeedB4;//紀錄第一次移動的距離

    private float firstSpeedC1;//紀錄第一次移動的距離
    private float firstSpeedC2;//紀錄第一次移動的距離
    private float firstSpeedC3;//紀錄第一次移動的距離
    private float firstSpeedC4;//紀錄第一次移動的距離

    private int rngP; //隨機人物
    private int rngP2; //隨機人物
    private int rngC; //隨機人開關
    private int S;  //到達位置
    private int S1;  //到達位置
    private int oncetxt; //txt只顯示一次
    private int dotwo;  //第二位開始判定
    private int doone;  //只做第一次移動
    private int G1;  //到達位置
    private int G2;  //到達位置
    private int G3;  //到達位置
    private int G4;  //到達位置
    private int G5;  //到達位置
    private int G6;  //到達位置

    private GameObject p1; //A角色第一分身
    private GameObject p2; //B角色第一分身
    private GameObject p3; //C角色第一分身
    private GameObject p12; //A角色第二分身
    private GameObject p22; //B角色第二分身
    private GameObject p32; //C角色第二分身

    public GameObject leave1; //最左位離開
    public GameObject leave2; //中位離開

    public GameObject txts1;//最左位對話框
    public GameObject txts2;//中位對話框

    public GameObject feel1;
    public GameObject feel2;
    public Image feeling1;
    public Image feeling2;
    public Sprite feelG;
    public Sprite feelR;

    public Sprite an1;
    public Sprite an2;
    public Sprite an3;
    public Sprite no1;
    public Sprite no2;
    public Sprite no3;
    public Sprite ha1;
    public Sprite ha2;
    public Sprite ha3;

    public GameObject angry1;
    public GameObject angry2;
    // Start is called before the first frame update
    void Start()
    {
        //建立物件
        p1 = (GameObject)Instantiate(Obj1, Obj1.transform.position, new Quaternion(0, 0, 0, 0));
        p2 = (GameObject)Instantiate(Obj2, Obj2.transform.position, new Quaternion(0, 0, 0, 0));
        p3 = (GameObject)Instantiate(Obj3, Obj3.transform.position, new Quaternion(0, 0, 0, 0));
        p12 = (GameObject)Instantiate(Obj1, Obj1.transform.position, new Quaternion(0, 0, 0, 0));
        p22 = (GameObject)Instantiate(Obj2, Obj2.transform.position, new Quaternion(0, 0, 0, 0));
        p32 = (GameObject)Instantiate(Obj3, Obj3.transform.position, new Quaternion(0, 0, 0, 0));


        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
        p12.SetActive(false);
        p22.SetActive(false);
        p32.SetActive(false);

        //隨機人物
        rngP = Random.Range(1, 4);
        Debug.Log(rngP);
        //開啟人物移動
        rngC = 0;
        //判斷隨機到誰
        if (rngP == 1 && rngC == 0)
        {
            p1.SetActive(true);
            rngC = 1;
            S = 1;
        }//如果隨機到A>顯示A 關閉隨機判斷 設定位置在最左
        else if (rngP == 2 && rngC == 0)
        {
            p2.SetActive(true);
            rngC = 1;
            S = 1;
        }//如果隨機到B>顯示B 關閉隨機判斷 設定位置在最左
        else if (rngP == 3 && rngC == 0)
        {
            p3.SetActive(true);
            rngC = 1;
            S = 1;
        }//如果隨機到C>顯示C 關閉隨機判斷 設定位置在最左
        //紀錄第一次移動的距離
        firstSpeedA1 = Vector3.Distance(PathA.transform.position, PathB.transform.position) * speed;
        firstSpeedB1 = Vector3.Distance(PathA.transform.position, PathB.transform.position) * speed;
        firstSpeedC1 = Vector3.Distance(PathA.transform.position, PathB.transform.position) * speed;
        firstSpeedA2 = Vector3.Distance(PathA.transform.position, PathC.transform.position) * speed1;
        firstSpeedB2 = Vector3.Distance(PathA.transform.position, PathC.transform.position) * speed1;
        firstSpeedC2 = Vector3.Distance(PathA.transform.position, PathC.transform.position) * speed1;

        firstSpeedA3 = Vector3.Distance(PathB.transform.position, PathD.transform.position) * speed2;
        firstSpeedB3 = Vector3.Distance(PathB.transform.position, PathD.transform.position) * speed2;
        firstSpeedC3 = Vector3.Distance(PathB.transform.position, PathD.transform.position) * speed2;
        firstSpeedA4 = Vector3.Distance(PathC.transform.position, PathD.transform.position) * speed3;
        firstSpeedB4 = Vector3.Distance(PathC.transform.position, PathD.transform.position) * speed3;
        firstSpeedC4 = Vector3.Distance(PathC.transform.position, PathD.transform.position) * speed3;

    }

    // Update is called once per frame
    void Update()
    {
        //更換圖片
        if (feeling1.GetComponent<Image>().sprite == feelG) { p1.GetComponent<SpriteRenderer>().sprite = no1; p2.GetComponent<SpriteRenderer>().sprite = no2; p3.GetComponent<SpriteRenderer>().sprite = no3; }
        else if (feeling1.GetComponent<Image>().sprite == feelR) { p1.GetComponent<SpriteRenderer>().sprite = an1; p2.GetComponent<SpriteRenderer>().sprite = an2; p3.GetComponent<SpriteRenderer>().sprite = an3; }
        //更換圖片
        if (feeling2.GetComponent<Image>().sprite == feelG) { p12.GetComponent<SpriteRenderer>().sprite = no1; p22.GetComponent<SpriteRenderer>().sprite = no2; p32.GetComponent<SpriteRenderer>().sprite = no3; }
        else if (feeling2.GetComponent<Image>().sprite == feelR) { p12.GetComponent<SpriteRenderer>().sprite = an1; p22.GetComponent<SpriteRenderer>().sprite = an2; p32.GetComponent<SpriteRenderer>().sprite = an3; }

        if (txts1.activeSelf) { leave1.SetActive(false); }
        if (txts2.activeSelf) { leave2.SetActive(false); }

        if (rngP == 1 && S == 1)
        {
            //改變A位置到最左
             p1.transform.position = Vector3.Lerp(p1.transform.position, PathB.transform.position, speed * Time.deltaTime);
            //位移剩餘距離
            speed = calculateNewSpeedA1();
            if (speed == 0)
            {   //顯示對話框
                txts1.SetActive(true);
                feel1.SetActive(true);
                //開啟第二次隨機
                if (doone == 0)
                {
                    dotwo = 1;
                }
                //第二次隨機
                if (dotwo == 1)
                {
                    //隨機第二位角色
                    rngP2 = Random.Range(1, 4);
                    Debug.Log(rngP2);
                    if (rngP2 == 1)
                    {  //設定位置在中間
                        S1 = 2;
                        S = 2;
                        //關閉第二位角色隨機
                        dotwo = 0;
                    }//如果隨機到A
                    else if (rngP2 == 2)
                    {  //開啟第二分身
                        p22.SetActive(true);
                        //設定位置在中間
                        S1 = 2;
                        S = 2;
                        //關閉第二位角色隨機
                        dotwo = 0;
                    }//如果隨機到B
                    else if (rngP2 == 3)
                    {  //開啟第二分身
                        p32.SetActive(true);
                        //設定位置在中間
                        S1 = 2;
                        S = 2;
                        //關閉第二位角色隨機
                        dotwo = 0;
                    }//如果隨機到C
                }
                else { S = 3; leave1.SetActive(false); }
            }//第一位停下
        }  //A人物到最左
        else if (rngP == 2 && S == 1)
        {
            //改變B位置到最左
            p2.transform.position = Vector3.Lerp(p2.transform.position, PathB.transform.position, speed * Time.deltaTime);
            //位移剩餘距離
            speed = calculateNewSpeedB1();
            if (speed == 0)
            {   //顯示對話框
                txts1.SetActive(true);
                feel1.SetActive(true);
                //開啟第二次隨機
                if (doone == 0)
                {
                    dotwo = 1;
                }
                //第二次隨機
                if (dotwo == 1)
                {
                    //隨機第二位角色
                    rngP2 = Random.Range(1, 4);
                    Debug.Log(rngP);
                    if (rngP2 == 1)
                    {   //開啟第二分身
                        p12.SetActive(false);
                        //設定位置在中間
                        S1 = 2;
                        S = 2;
                        //關閉第二位角色隨機
                        dotwo = 0;
                    }//如果隨機到A
                    else if (rngP2 == 2)
                    {  //開啟第二分身
                        p22.SetActive(false);
                        //設定位置在中間
                        S1 = 2;
                        S = 2;
                        //關閉第二位角色隨機
                        dotwo = 0;
                    }//如果隨機到B
                    else if (rngP2 == 3)
                    {  //開啟第二分身
                        p32.SetActive(false);
                        //設定位置在中間
                        S1 = 2;
                        S = 2;
                        //關閉第二位角色隨機
                        dotwo = 0;
                    }//如果隨機到C
                }
                else { S = 3; leave1.SetActive(false); }
            }//第一位停下
        }  //B人物到最左
        else if (rngP == 3 && S == 1)
        {
            //改變C位置到最左
            p3.transform.position = Vector3.Lerp(p3.transform.position, PathB.transform.position, speed * Time.deltaTime);
            //位移剩餘距離
            speed = calculateNewSpeedC1();
            if (speed == 0)
            {   //顯示對話框
                txts1.SetActive(true);
                feel1.SetActive(true);
                //開啟第二次隨機
                if (doone == 0)
                {
                    dotwo = 1;
                }
                //第二次隨機
                if (dotwo == 1)
                {
                    //隨機第二位角色
                    rngP2 = Random.Range(1, 4);
                    Debug.Log(rngP);
                    if (rngP2 == 1)
                    {   //開啟第二分身
                        p12.SetActive(false);
                        //設定位置在中間
                        S = 2;
                        S1 = 2;
                        //關閉第二位角色隨機
                        dotwo = 0;
                    }//如果隨機到A
                    else if (rngP2 == 2)
                    {  //開啟第二分身
                        p22.SetActive(false);
                        //設定位置在中間
                        S = 2;
                        S1 = 2;
                        //關閉第二位角色隨機
                        dotwo = 0;
                    }//如果隨機到B
                    else if (rngP2 == 3)
                    {  //開啟第二分身
                        p32.SetActive(false);
                        //設定位置在中間
                        S = 2;
                        S1 = 2;
                        //關閉第二位角色隨機
                        dotwo = 0;
                    }//如果隨機到C
                }
                else { S = 3; leave1.SetActive(false); }
            }//第一位停下
        }  //C人物到最左
        
        if (rngP2 == 1 && S1 == 2)
        {
            //開啟第二分身
            p12.SetActive(true);
            //改變A分身位置到最左
            p12.transform.position = Vector3.Lerp(p12.transform.position, PathC.transform.position, speed1 * Time.deltaTime);
            //位移剩餘距離
            speed1 = calculateNewSpeedA2();
            //顯示中間對話框
            if (speed1 == 0 && oncetxt == 0)
            {
                txts2.SetActive(true);
                feel2.SetActive(true);
                oncetxt = 1;
                S1 = 3;
            }
            if (doone == 0)
            {
                S = 3;
                doone = 1;
            }
        }  //A人物到中間
        else if (rngP2 == 2 && S1 == 2)
        {
            //開啟第二分身
            p22.SetActive(true);
            //改變A分身位置到最左
            p22.transform.position = Vector3.Lerp(p22.transform.position, PathC.transform.position, speed1 * Time.deltaTime);
            //位移剩餘距離
            speed1 = calculateNewSpeedB2();
            //顯示中間對話框
            if (speed1 == 0 && oncetxt == 0)
            {
                txts2.SetActive(true);
                feel2.SetActive(true);
                oncetxt = 1;
                S1 = 3;
            }
            if (doone == 0)
            {
                S = 3;
                doone = 1;
            }
        }  //B人物到中間
        else if (rngP2 == 3 && S1 == 2)
        {
            //開啟第二分身
            p32.SetActive(true);
            //改變A分身位置到最左
            p32.transform.position = Vector3.Lerp(p32.transform.position, PathC.transform.position, speed1 * Time.deltaTime);
            //位移剩餘距離
            speed1 = calculateNewSpeedC2();
            //顯示中間對話框
            if (speed1 == 0 && oncetxt == 0)
            {
                txts2.SetActive(true);
                feel2.SetActive(true);
                oncetxt = 1;
                S1 = 3;
            }
            if (doone == 0)
            {
                S = 3;
                doone = 1;
            }
        }  //C人物到中間
 
        if (leave1.activeSelf && S == 4)
        {
            if (p1.transform.position.Equals(PathD.transform.position))
            {
                p1.transform.position = PathA.transform.position;
                p1.SetActive(false);
            }
            else if (p2.transform.position.Equals(PathD.transform.position))
            {
                p2.transform.position = PathA.transform.position;
                p2.SetActive(false);
            }
            else if (p3.transform.position.Equals(PathD.transform.position))
            {
                p3.transform.position = PathA.transform.position;
                p3.SetActive(false);
            }
            doone = 1;
            //隨機人物
            rngP = Random.Range(1, 4);
            //開啟人物移動
            rngC = 0;
            //判斷隨機到誰
            if (rngP == 1 && rngC == 0)
            {
                p1.SetActive(true);
                rngC = 1;
                S = 1;
            }//如果隨機到A>顯示A 關閉隨機判斷 設定位置在最左
            else if (rngP == 2 && rngC == 0)
            {
                p2.SetActive(true);
                rngC = 1;
                S = 1;
            }//如果隨機到B>顯示B 關閉隨機判斷 設定位置在最左
            else if (rngP == 3 && rngC == 0)
            {
                p3.SetActive(true);
                rngC = 1;
                S = 1;
            }//如果隨機到C>顯示C 關閉隨機判斷 設定位置在最左
        }
        else if (leave1.activeSelf && S == 3)
        {
            firstgo();
        }

        if (leave2.activeSelf && S1 == 4)
        {
            S1 = 3;
            if (p12.transform.position.Equals(PathD.transform.position)) { p12.transform.position = PathA.transform.position; p12.SetActive(false); }
            else if (p22.transform.position.Equals(PathD.transform.position)) { p22.transform.position = PathA.transform.position; p22.SetActive(false); }
            else if (p32.transform.position.Equals(PathD.transform.position)) { p32.transform.position = PathA.transform.position; p32.SetActive(false); }
            //隨機第二位角色
            rngP2 = Random.Range(1, 4);
            Debug.Log(rngP2);
            S1 = 2;
            oncetxt = 0;
        }
        else if (leave2.activeSelf && S1 == 3)
        {
            secgo();
        }

    }

    //副程式到最左
    private float calculateNewSpeedA1()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp = Vector3.Distance(p1.transform.position, PathB.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp == 0)
            return tmp;
        else
            return (firstSpeedA1 / tmp);
    }
    private float calculateNewSpeedB1()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp = Vector3.Distance(p2.transform.position, PathB.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp == 0)
            return tmp;
        else
            return (firstSpeedB1 / tmp);
    }
    private float calculateNewSpeedC1()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp = Vector3.Distance(p3.transform.position, PathB.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp == 0)
            return tmp;
        else
            return (firstSpeedC1 / tmp);
    }

    //副程式到中間
    private float calculateNewSpeedA2()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp = Vector3.Distance(p12.transform.position, PathC.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp == 0)
            return tmp;
        else
            return (firstSpeedA2 / tmp);
    }
    private float calculateNewSpeedB2()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp = Vector3.Distance(p22.transform.position, PathC.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp == 0)
            return tmp;
        else
            return (firstSpeedB2 / tmp);
    }
    private float calculateNewSpeedC2()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp = Vector3.Distance(p32.transform.position, PathC.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp == 0)
            return tmp;
        else
            return (firstSpeedC2 / tmp);
    }

    //副程式到中間
    private float calculateNewSpeedA3()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp = Vector3.Distance(p1.transform.position, PathD.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp == 0)
            return tmp;
        else
            return (firstSpeedA3 / tmp);
    }
    private float calculateNewSpeedB3()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp = Vector3.Distance(p2.transform.position, PathD.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp == 0)
            return tmp;
        else
            return (firstSpeedB3 / tmp);
    }
    private float calculateNewSpeedC3()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp = Vector3.Distance(p3.transform.position, PathD.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp == 0)
            return tmp;
        else
            return (firstSpeedC3 / tmp);
    }

    //副程式到中間
    private float calculateNewSpeedA4()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp1 = Vector3.Distance(p12.transform.position, PathD.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp1 == 0)
            return tmp1;
        else
            return (firstSpeedA4 / tmp1);
    }
    private float calculateNewSpeedB4()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp1 = Vector3.Distance(p22.transform.position, PathD.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp1 == 0)
            return tmp1;
        else
            return (firstSpeedB4 / tmp1);
    }
    private float calculateNewSpeedC4()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp1 = Vector3.Distance(p32.transform.position, PathD.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp1 == 0)
            return tmp1;
        else
            return (firstSpeedC4 / tmp1);
    }

    void firstgo()
    {
        if (p1.transform.position.Equals(PathB.transform.position) || G1 == 3)
        {
            G1 = 3;
            if (angry1.activeSelf) { p1.GetComponent<SpriteRenderer>().sprite = an1;  }
            else { p1.GetComponent<SpriteRenderer>().sprite = ha1; }
            p1.transform.position = Vector3.Lerp(p1.transform.position, PathD.transform.position, speed2 * Time.deltaTime);
            speed2 = calculateNewSpeedA3();
            if (speed2 == 0) { S = 4; G1 = 4; angry1.SetActive(false); }
        }
        else if (p2.transform.position.Equals(PathB.transform.position) || G2 == 3)
        {
            G2 = 3;
            if (angry1.activeSelf) { p2.GetComponent<SpriteRenderer>().sprite = an2; }
            else { p2.GetComponent<SpriteRenderer>().sprite = ha2; }
            p2.transform.position = Vector3.Lerp(p2.transform.position, PathD.transform.position, speed2 * Time.deltaTime);
            speed2 = calculateNewSpeedB3();
            if (speed2 == 0) { S = 4; G2 = 4; angry1.SetActive(false); }
        }
        else if (p3.transform.position.Equals(PathB.transform.position) || G3 == 3)
        {
            G3 = 3;
            if (angry1.activeSelf) { p3.GetComponent<SpriteRenderer>().sprite = an3; }
            else { p3.GetComponent<SpriteRenderer>().sprite = ha3; }
            p3.transform.position = Vector3.Lerp(p3.transform.position, PathD.transform.position, speed2 * Time.deltaTime);
            speed2 = calculateNewSpeedC3();
            if (speed2 == 0) { S = 4; G3 = 4; angry1.SetActive(false); }
        }
    }

    void secgo()
    {
        if (p12.transform.position.Equals(PathC.transform.position) || G4 == 3)
        {
            G4 = 3;
            if (angry2.activeSelf) { p12.GetComponent<SpriteRenderer>().sprite = an1; }
            else { p12.GetComponent<SpriteRenderer>().sprite = ha1; }
            p12.transform.position = Vector3.Lerp(p12.transform.position, PathD.transform.position, speed3 * Time.deltaTime);
            speed3 = calculateNewSpeedA4();
            if (speed3 == 0) { S1 = 4; G4 = 4; angry2.SetActive(false); }
        }
        else if (p22.transform.position.Equals(PathC.transform.position) || G5 == 3)
        {
            G5 = 3;
            if (angry2.activeSelf) { p22.GetComponent<SpriteRenderer>().sprite = an2; }
            else { p22.GetComponent<SpriteRenderer>().sprite = ha2; }
            p22.transform.position = Vector3.Lerp(p22.transform.position, PathD.transform.position, speed3 * Time.deltaTime);
            speed3 = calculateNewSpeedB4();
            if (speed3 == 0) { S1 = 4; G5 = 4; angry2.SetActive(false); }
        }
        else if (p32.transform.position.Equals(PathC.transform.position) || G6 == 3)
        {
            G6 = 3;
            if (angry2.activeSelf) { p32.GetComponent<SpriteRenderer>().sprite = an3; }
            else { p32.GetComponent<SpriteRenderer>().sprite = ha3; }
            p32.transform.position = Vector3.Lerp(p32.transform.position, PathD.transform.position, speed3 * Time.deltaTime);
            speed3 = calculateNewSpeedC4();
            if (speed3 == 0) { S1 = 4; G6 = 4; angry2.SetActive(false); }
        }

    }
}
