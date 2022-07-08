using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapbutton : MonoBehaviour
{
    public GameObject LV1;
    public GameObject LV1but;
    public GameObject gotoLV1but;
    public GameObject CencelLV1but;

    public GameObject LV2;
    public GameObject LV2but;
    public GameObject gotoLV2but;
    public GameObject CencelLV2but;

    public GameObject LV3;
    public GameObject LV3but;
    public GameObject gotoLV3but;
    public GameObject CencelLV3but;

    public GameObject LV4;
    public GameObject LV4but;
    public GameObject gotoLV4but;
    public GameObject CencelLV4but;

    public GameObject LV5;
    public GameObject LV5but;
    public GameObject gotoLV5but;
    public GameObject CencelLV5but;

    public GameObject map;

    public GameObject bg;
    public GameObject X;
    public GameObject lef;
    public GameObject rig;
    public GameObject tip1;
    public GameObject tip2;
    public GameObject dowmb;
    public GameObject up;
    // Start is called before the first frame update
    void Start()
    {
        LV4but.SetActive(false);
        LV5but.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //LV1
    public void clickLV1()
    {
        LV1.SetActive(true);
        gotoLV1but.SetActive(true);
        CencelLV1but.SetActive(true);
        LV1but.SetActive(false);
        LV2but.SetActive(false);
        LV3but.SetActive(false);

    }

    public void clickgotoLV1()
    {
        Application.LoadLevel("Level1");
    }

    public void cencelLV1()
    {
        LV1.SetActive(false);
        gotoLV1but.SetActive(false);
        CencelLV1but.SetActive(false);
        LV1but.SetActive(true);
        LV2but.SetActive(true);
        LV3but.SetActive(true);
    }
    
    //LV2
    public void clickLV2()
    {
        LV2.SetActive(true);
        gotoLV2but.SetActive(true);
        CencelLV2but.SetActive(true);
        LV1but.SetActive(false);
        LV2but.SetActive(false);
        LV3but.SetActive(false);

    }

    public void clickgotoLV2()
    {
        Application.LoadLevel("Level2");
    }

    public void cencelLV2()
    {
        LV2.SetActive(false);
        gotoLV2but.SetActive(false);
        CencelLV2but.SetActive(false);
        LV1but.SetActive(true);
        LV2but.SetActive(true);
        LV3but.SetActive(true);
    }

    //LV3
    public void clickLV3()
    {
        LV3.SetActive(true);
        gotoLV3but.SetActive(true);
        CencelLV3but.SetActive(true);
        LV1but.SetActive(false);
        LV2but.SetActive(false);
        LV3but.SetActive(false);

    }

    public void clickgotoLV3()
    {
        Application.LoadLevel("Level3");
    }

    public void cencelLV3()
    {
        LV3.SetActive(false);
        gotoLV3but.SetActive(false);
        CencelLV3but.SetActive(false);
        LV1but.SetActive(true);
        LV2but.SetActive(true);
        LV3but.SetActive(true);
    }


    //LV4
    public void clickLV4()
    {
        LV4.SetActive(true);
        gotoLV4but.SetActive(true);
        CencelLV4but.SetActive(true);
        LV4but.SetActive(false);
        LV5but.SetActive(false);

    }

    public void clickgotoLV4()
    {
        Application.LoadLevel("Level4");
    }

    public void cencelLV4()
    {
        LV4.SetActive(false);
        gotoLV4but.SetActive(false);
        CencelLV4but.SetActive(false);
        LV4but.SetActive(true);
        LV5but.SetActive(true);
    }

    //LV5
    public void clickLV5()
    {
        LV5.SetActive(true);
        gotoLV5but.SetActive(true);
        CencelLV5but.SetActive(true);
        LV4but.SetActive(false);
        LV5but.SetActive(false);

    }

    public void clickgotoLV5()
    {
        Application.LoadLevel("Level5");
    }

    public void cencelLV5()
    {
        LV5.SetActive(false);
        gotoLV5but.SetActive(false);
        CencelLV5but.SetActive(false);
        LV4but.SetActive(true);
        LV5but.SetActive(true);
    }

    //
    public void clicktip()
    {
        bg.SetActive(true);
        tip1.SetActive(true);
        X.SetActive(true);
        rig.SetActive(true);
    }
    public void clickleft()
    {
        tip1.SetActive(true);
        tip2.SetActive(false);
        lef.SetActive(false);
        rig.SetActive(true);
    }
    public void clickright()
    {
        tip1.SetActive(false);
        tip2.SetActive(true);
        lef.SetActive(true);
        rig.SetActive(false);
    }
    public void clickX()
    {
        tip1.SetActive(false);
        tip2.SetActive(false);
        lef.SetActive(false);
        rig.SetActive(false);
        bg.SetActive(false);
        X.SetActive(false);


    }

    public void clickdown()
    {//411.9031 -145.883
        //410.7989 234.1505
        map.transform.position = new Vector3(410, 234, 100);
        LV4but.SetActive(true);
        LV5but.SetActive(true);
        LV1but.SetActive(false);
        LV2but.SetActive(false);
        LV3but.SetActive(false);
        dowmb.SetActive(false);
        up.SetActive(true);
    }

    public void clickup()
    {//411.9031 -145.883
        //410.7989 234.1505
        map.transform.position = new Vector3(411, -145, 100);
        LV1but.SetActive(true);
        LV2but.SetActive(true);
        LV3but.SetActive(true);
        LV4but.SetActive(false);
        LV5but.SetActive(false);
        up.SetActive(false);
        dowmb.SetActive(true);
    }
}
