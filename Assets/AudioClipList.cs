using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="AudioClipList", menuName = "RandomAudioClip/AudioClipList", order = 1)]
public class AudioClipList : ScriptableObject
{
    public new string name = "";
    public List<AudioClip> clips;
}
