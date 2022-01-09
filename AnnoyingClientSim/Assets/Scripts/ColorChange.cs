using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public DrawLine line;

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


    public void ColorBlack()
    {
        Debug.Log("buttonworks");
        line._renderer.startColor = black;
        line._renderer.endColor = black;
    }

    public void ColordarkBlue()
    {
        line._renderer.startColor = darkBlue;
        line._renderer.endColor = darkBlue;
    }

    public void ColorBlue()
    {
        line._renderer.startColor = blue;
        line._renderer.endColor = blue;
    }

    public void ColorPurple()
    {
        line._renderer.startColor = purple;
        line._renderer.endColor = purple;
    }

    public void ColorBrown()
    {
        line._renderer.startColor = brown;
        line._renderer.endColor = brown;
    }

    public void ColorDarkGray()
    {
        line._renderer.startColor = darkGray;
        line._renderer.endColor = darkGray;
    }

    public void ColorTeal()
    {
        line._renderer.startColor = teal; ;
        line._renderer.endColor = teal;
    }

    public void ColorGreen()
    {
        line._renderer.startColor = green; ;
        line._renderer.endColor = green;
    }

    public void ColorPink()
    {
        line._renderer.startColor = pink; ;
        line._renderer.endColor = pink;
    }

    public void ColorRed()
    {
        line._renderer.startColor = red;
        line._renderer.endColor = red;
    }

    public void ColorGray()
    {
        line._renderer.startColor = gray;
        line._renderer.endColor = gray;
    }

    public void ColorSkyBlue()
    {
        line._renderer.startColor = skyBlue;
        line._renderer.endColor = skyBlue;
    }

    public void ColorLightGreen()
    {
        line._renderer.startColor = lightGreen;
        line._renderer.endColor = lightGreen;
    }

    public void ColorYellow()
    {
        line._renderer.startColor = yellow;
        line._renderer.endColor = yellow;
    }

    public void ColorPeach()
    {
        line._renderer.startColor = peach;
        line._renderer.endColor = peach;
    }

    public void ColorWhite()
    {
        line._renderer.startColor = white;
        line._renderer.endColor = white;
    }

    public void ColorLightBlue()
    {
        line._renderer.startColor = lightBlue;
        line._renderer.endColor = lightBlue;
    }

    public void ColorVeryLightGreen()
    {
        line._renderer.startColor = veryLightGreen;
        line._renderer.endColor = veryLightGreen;
    }

    public void ColorLightYellow()
    {
        line._renderer.startColor = lightYellow;
        line._renderer.endColor = lightYellow;
    }

    public void ColorBeige()
    {
        line._renderer.startColor = beige;
        line._renderer.endColor = beige;
    }

}
