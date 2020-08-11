using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TIMER : MonoBehaviour
{
    public Text timer;
    public int m;
    public int s;

    private void Start()
    {
        m = 4;
        s = 59;
        Update();
        StartCoroutine(timerRoutine());
    }

    private void Update()
    {
        if(s<10)
            timer.text = "0" + m + ":" + "0" + s;
        else
            timer.text = "0" + m + ":" + s; 
    }

    IEnumerator timerRoutine()
    {
        while (m >= 0)
        {
            yield return new WaitForSeconds(1);
            s = s - 1;
            if (s < 0)
            {
                m = m - 1;
                s = 59;
            }
        }
        yield return null;
    }
}
