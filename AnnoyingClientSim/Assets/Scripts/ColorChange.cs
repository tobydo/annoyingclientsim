using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public LineDrawer line;
   
    Color black = new Color(0, 0, 0, 1);
    Color darkBlue = new Color(0.03529412f, 0.03921569f, 0.4313726f, 1);
    Color blue = new Color(0.09803922f, 0.09803922f, 0.8392158f, 1);
    Color purple = new Color(0.4588236f, 0.145098f, 0.9019608f, 1);
    Color brown = new Color(0.4784314f, 0.227451f, 0.4078432f, 1);

    Color darkGray = new Color(0.3215686f, 0.3803922f, 0.6666667f, 1);
    Color teal = new Color(0.01176471f, 0.482353f, 0.9058824f, 1);
    Color green = new Color(0.01176471f, 0.6509804f, 0.7058824f, 1);
    Color pink = new Color(0.8235295f, 0.3529412f, 0.9960785f, 1);
    Color red = new Color(0.9843138f, 0.2588235f, 0.5490196f, 1);

    Color gray = new Color(0.764706f, 0.8078432f, 0.9137256f, 1);
    Color skyBlue = new Color(0, 0.7529413f, 1, 1);
    Color lightGreen = new Color(0.427451f, 0.9254903f, 0.6784314f, 1);
    Color yellow = new Color(0.9960785f, 0.8588236f, 0.4980392f, 1);
    Color peach = new Color(1, 0.6431373f, 0.8039216f, 1);

    Color white = new Color(1, 1, 1, 1);
    Color lightBlue = new Color(0.6352941f, 0.9058824f, 1, 1);
    Color veryLightGreen = new Color(0.7686275f, 1, 0.6588235f, 1);
    Color lightYellow = new Color(0.9921569f, 0.937255f, 0.6941177f, 1);
    Color beige = new Color(0.9960785f, 0.909804f, 0.8901961f, 1);

    Color eraser = new Color(1, 1, 1, 1);

    Color lastColor;

    public void Start()
    {
        lastColor = black;
    }


    public void ColorBlack()
    {
        Debug.Log("buttonworks");

        line.lineRenderer.startColor = black;
        line.lineRenderer.endColor = black;

        lastColor = black;
    }

    public void ColordarkBlue()
    {
        Debug.Log("run this right");

        line.lineRenderer.startColor = darkBlue;
        line.lineRenderer.endColor = darkBlue;

        lastColor = darkBlue;
    }

    public void ColorBlue()
    {
        line.lineRenderer.startColor = blue;
        line.lineRenderer.endColor = blue;

        lastColor = blue;
    }

    public void ColorPurple()
    {
        line.lineRenderer.startColor = purple;
        line.lineRenderer.endColor = purple;

        lastColor = purple;
    }

    public void ColorBrown()
    {
        line.lineRenderer.startColor = brown;
        line.lineRenderer.endColor = brown;

        lastColor = brown;
    }

    public void ColorDarkGray()
    {
        line.lineRenderer.startColor = darkGray;
        line.lineRenderer.endColor = darkGray;

        lastColor = darkGray;
    }

    public void ColorTeal()
    {
        line.lineRenderer.startColor = teal; ;
        line.lineRenderer.endColor = teal;

        lastColor = teal;
    }

    public void ColorGreen()
    {
        line.lineRenderer.startColor = green; ;
        line.lineRenderer.endColor = green;

        lastColor = green;
    }

    public void ColorPink()
    {
        line.lineRenderer.startColor = pink; ;
        line.lineRenderer.endColor = pink;

        lastColor = pink;
    }

    public void ColorRed()
    {
        line.lineRenderer.startColor = red;
        line.lineRenderer.endColor = red;

        lastColor = red;
    }

    public void ColorGray()
    {
        line.lineRenderer.startColor = gray;
        line.lineRenderer.endColor = gray;

        lastColor = gray;
    }

    public void ColorSkyBlue()
    {
        line.lineRenderer.startColor = skyBlue;
        line.lineRenderer.endColor = skyBlue;

        lastColor = skyBlue;
    }

    public void ColorLightGreen()
    {
        line.lineRenderer.startColor = lightGreen;
        line.lineRenderer.endColor = lightGreen;

        lastColor = lightGreen;
    }

    public void ColorYellow()
    {
        line.lineRenderer.startColor = yellow;
        line.lineRenderer.endColor = yellow;

        lastColor = yellow;
    }

    public void ColorPeach()
    {
        line.lineRenderer.startColor = peach;
        line.lineRenderer.endColor = peach;

        lastColor = peach;
    }

    public void ColorWhite()
    {
        line.lineRenderer.startColor = white;
        line.lineRenderer.endColor = white;

        lastColor = white;
    }

    public void ColorLightBlue()
    {
        line.lineRenderer.startColor = lightBlue;
        line.lineRenderer.endColor = lightBlue;

        lastColor = lightBlue;
    }

    public void ColorVeryLightGreen()
    {
        line.lineRenderer.startColor = veryLightGreen;
        line.lineRenderer.endColor = veryLightGreen;

        lastColor = veryLightGreen;
    }

    public void ColorLightYellow()
    {
        line.lineRenderer.startColor = lightYellow;
        line.lineRenderer.endColor = lightYellow;

        lastColor = lightYellow;
    }

    public void ColorBeige()
    {
        line.lineRenderer.startColor = beige;
        line.lineRenderer.endColor = beige;

        lastColor = beige;
    }

    public void ColorEraser()
    {
        line.lineRenderer.startColor = eraser;
        line.lineRenderer.endColor = eraser;
    }

    public void ColorLastColor()
    {
        line.lineRenderer.startColor = lastColor;
        line.lineRenderer.endColor = lastColor;
    }
}
