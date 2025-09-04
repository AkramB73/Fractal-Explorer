using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshots : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            string screenshotname;

            int randomNumber = Random.Range(0, 10000);

            screenshotname = "ScreenShot" + randomNumber + ".png";

            ScreenCapture.CaptureScreenshot(screenshotname);
        }
    }
}
