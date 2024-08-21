using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MothNameList", menuName = "MothList/NameList", order = 1)]
public class MothNames : ScriptableObject
{
    public new string name = "";
    public List<AudioClip> clips;
}
