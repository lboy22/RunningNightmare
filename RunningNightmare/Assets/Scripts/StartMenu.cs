using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    private int mainMenuValue;
    [SerializeField] private AudioSource startGameSound;
    public void StartGame()
    {
        mainMenuValue = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //startGameSound.Play();
        //StartCoroutine(loadSceneDelayed());
    }

    public void CreditsScreen()
    {
        SceneManager.LoadScene(mainMenuValue);
    }

    private IEnumerator loadSceneDelayed()
    {
        yield return new WaitForSeconds(8F);
        
    }
}
