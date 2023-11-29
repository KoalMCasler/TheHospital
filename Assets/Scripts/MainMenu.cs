using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneBuildIndex = 1;
    public float waitTime;
    public Animator crossFadeAnim;
    public GameObject crossFade;
    void Start()
    {
        crossFade.SetActive(true);
    }
    public void PlayGame()
    {
        StartCoroutine(StartGameWithEffect());
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    private IEnumerator StartGameWithEffect()
    {
        crossFadeAnim.SetBool("Leave",true);
        yield return new WaitForSeconds(waitTime);
        crossFadeAnim.SetBool("Leave",false);
        SceneManager.LoadScene(sceneBuildIndex);
    }
}
