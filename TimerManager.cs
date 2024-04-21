using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{

    public Text minutesText;
    public Text secondsText;
    private int milliseconds;
    // Start is called before the first frame update
    void Start()
    {
        minutesText.text = "1";
        secondsText.text = "15";
        milliseconds = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (minutesText.text == "0" && secondsText.text == "00")
        {
            // Game Over
            Debug.Log("Game Over");
        }
        else
        {
            milliseconds--;
            if (milliseconds == 0)
            {
                milliseconds = 30;
                if (secondsText.text == "00")
                {
                    secondsText.text = "59";
                    minutesText.text = (int.Parse(minutesText.text) - 1).ToString();
                }
                else
                {
                    secondsText.text = (int.Parse(secondsText.text) - 1).ToString();
                    if (int.Parse(secondsText.text) < 10)
                    {
                        secondsText.text = "0" + secondsText.text;
                    }
                }
            }
        }
    }
}
