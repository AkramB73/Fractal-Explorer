using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Explorer : MonoBehaviour
{
    public Material mat;
    public Vector2 pos;
    public float scale, angle, iterations, colour, colgrad, cycle, xcord, ycord;
    public float a, b;

    private Vector2 smoothPos;
    private float smoothScale, smoothAngle;

    // slider options
    
    public void AdjustIter(float newIter)
    {
        iterations = newIter;
    }

    public void AdjustColGrad(float newColGrad)
    {
        colgrad = newColGrad;
    }

    public void Adjustcolour(float newColour)
    {
        colour = newColour;
    }

    public void Adjustscale(float newscale)
    {
        a = newscale;
    }

    public void Adjustangle(float newangle)
    {
        b = newangle;
    }

    public void Adjustcycle(float newcycle)
    {
        cycle = newcycle;
    }

    public void Adjustxcord(float newxcord)
    {
        xcord = newxcord;
    }

    public void Adjustycord(float newycord)
    {
        ycord = newycord;
    }



    private void UpdateShader()
    {

        smoothPos = Vector2.Lerp(smoothPos, pos, .1f);
        smoothScale = Mathf.Lerp(smoothScale, scale, .1f);
        smoothAngle = Mathf.Lerp(smoothAngle, angle, .1f);


        float aspect = (float)Screen.width / (float)Screen.height;

        float scaleX = smoothScale;
        float scaleY = scale;

        if (aspect > 1)
        {
            scaleY /= aspect;
        }
        else
        {
            scaleX *= aspect;
        }

        mat.SetVector("_Area", new Vector4(smoothPos.x, smoothPos.y, scaleX, scaleY));
        mat.SetFloat("_Angle", smoothAngle);
        mat.SetFloat("_MaxIter", iterations);
        mat.SetFloat("_Colour", colour);
        mat.SetFloat("_repeat", colgrad);
        mat.SetFloat("_Cycle", cycle);
        mat.SetFloat("_a", xcord);
        mat.SetFloat("_b", ycord);

    }
    public void HandleInputs()
    {
        if (Input.GetKey(KeyCode.KeypadPlus))
            scale *= a;
        if (Input.GetKey(KeyCode.KeypadMinus))
            scale *= (1+(1-a));

        if (Input.GetKey(KeyCode.Q))
            angle -= b;
        if (Input.GetKey(KeyCode.E))
            angle += b;

        Vector2 res = new Vector2(.01f * scale, 0);
        float s = Mathf.Sin(angle);
        float c = Mathf.Cos(angle);
        res = new Vector2(res.x * c - res.y * s, res.x * s + res.y * c);


        pos += Input.GetAxisRaw("Horizontal") * res;

        res = new Vector2(-res.y, res.x);

        pos += Input.GetAxisRaw("Vertical") * res;

    }


  
    void Update()
    {
        HandleInputs();
        UpdateShader();
    }


}




        

    










