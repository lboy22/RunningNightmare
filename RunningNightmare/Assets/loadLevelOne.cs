using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadLevelOne : MonoBehaviour
{
    [SerializeField] private AudioSource levelOneSound;
    // Start is called before the first frame update
    void Start()
    {
        levelOneSound.Play();
        StartCoroutine(loadSceneDelayed());
    }

    private IEnumerator loadSceneDelayed()
    {
        yield return new WaitForSeconds(8F);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
