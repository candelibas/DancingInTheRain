using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public int index;
    public string sceneName;

    public Image black;
    public Animator anim;

    public void ChangeScene()
    {
        StartCoroutine(Fading());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(index);
    }
}
