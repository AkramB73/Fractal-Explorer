using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public void sliders(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void close(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void mainmenu(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void hidewhenclick(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void Fracslec(GameObject obj)
    {
        obj.SetActive(true);
    }


}
