using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Img Scene", menuName = "Img/Scene")]
public class ImgClass : ScriptableObject
{
    public int id;
    public Sprite img;
    public string text, who;
    public ImgType type;
    public string[] choises;
    public int idToLoad;
}

public enum ImgType
{
    normal, choise, input
}
