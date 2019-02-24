using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutsceneManager : MonoBehaviour
{
    [SerializeField]
    private Image nextCutScene;
    
    void Start()
    {
        
    }

    public void AnimationComplete()
    {
        if(nextCutScene != null)
        {
            nextCutScene.gameObject.SetActive(true);
        }
        else
        {
            // Go to gameplay scene
            SceneManager.LoadScene(1);
        }

    }


}
