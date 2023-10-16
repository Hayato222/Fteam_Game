using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountUpTimer : MonoBehaviour
{
    private StartTimer timer;
    public float CountUpTime = 0f;
    public TextMeshProUGUI time;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.CountDownTime < 0)
        {
            time.text = string.Format("{0:0}", CountUpTime);
            CountUpTime += Time.deltaTime;
        }
        
    }
}
