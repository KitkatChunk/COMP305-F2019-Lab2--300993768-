using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SceneSetting", menuName ="Scene/Settings")]
[System.Serializable]
public class SceneSetting : ScriptableObject
{
           activeSoundClip = SoundClip.NONE;
           scoreLabel.enabled = false;
           livesLabel.enabled = false;
           highScoreLabel.enabled = false;
           endLabel.SetActive(false);
           startButton.SetActive(false);
       
           restartButton.SetActive(false);
            startLabel.SetActive(false);
                startButton.SetActive(false);





  
}
