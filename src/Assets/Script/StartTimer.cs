using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartTimer : MonoBehaviour
{
    public float CountDownTime = 3;
    public TextMeshProUGUI CountDownTimer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CountDownTime > 0)
        {
            CountDownTimer.text = string.Format("{0:0}", CountDownTime);
        }
        if (CountDownTime < 0) 
        {
            CountDownTimer.text = string.Format("GO!");
        }
        CountDownTime -= Time.deltaTime;
    }
}
