using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    // 記得加這行

public class timer : MonoBehaviour
{
    public int Txttime = 90;
    public Text timer_time;
    public Text timeend;
    // Start is called before the first frame update
    void Start()
    {     //一開始就執行倒數計時。

        timeend.color = new Color(0, 0, 0, 0);
        InvokeRepeating("timers", 0, 1);
        //一秒後，每秒重複呼叫timer函式。(開始倒數計時)。
        //InokeRepeating 重複呼叫(“函式名”，第一次間隔幾秒呼叫，每幾秒呼叫一次)。

    }
    void timers()
    {

        Txttime -= 1;
        //每次呼叫倒數的時間就扣1。
        timer_time.text = Txttime + "";
        //將倒數的時間顯示在倒數時間的文字上。
        if (Txttime == 0)
        {
           timeend.color = new Color(255, 255, 255, 255);
           CancelInvoke("timers");
        }
    }

}
