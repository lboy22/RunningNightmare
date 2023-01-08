using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] private AudioSource dieSoundEffect;
    // Start is called before the first frame update

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Retry(int sceneID)
    {
        dieSoundEffect.Play();
        Time.timeScale = 1f;
        StartCoroutine(playRetryMusic(sceneID));
        
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    private IEnumerator playRetryMusic(int sceneID)
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(sceneID);  

    }
}
