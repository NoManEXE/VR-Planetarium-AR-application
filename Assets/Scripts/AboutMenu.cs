using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutMenu : MonoBehaviour
{
    // Start is called before the first frame update
  public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
