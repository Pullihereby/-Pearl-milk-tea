using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tipcontro : MonoBehaviour
{

    public GameObject bg;
    public GameObject X;

    public GameObject lef;
    public GameObject rig;
    public GameObject tip1;
    public GameObject tip2;


    public GameObject contonext;
    // Start is called before the first frame update
    void Start()
    {
        bg.SetActive(true);
        tip1.SetActive(true);
        X.SetActive(true);
        rig.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (bg.activeSelf) { Time.timeScale = 0f; }
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
        Time.timeScale = 1f;
        tip1.SetActive(false);
        tip2.SetActive(false);
        lef.SetActive(false);
        rig.SetActive(false);
        bg.SetActive(false);
        X.SetActive(false);
        contonext.SetActive(false);
       
    }
    public void connext() 
    {
        Time.timeScale = 0f;
        bg.SetActive(true);
        contonext.SetActive(true);
        X.SetActive(true);
    }
}
