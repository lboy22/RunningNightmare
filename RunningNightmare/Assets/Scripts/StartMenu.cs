using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private AudioSource startGameSound;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //startGameSound.Play();
        //StartCoroutine(loadSceneDelayed());
    }

    private IEnumerator loadSceneDelayed()
    {
        yield return new WaitForSeconds(8F);
        
    }
}
