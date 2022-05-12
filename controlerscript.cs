using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlerscript : MonoBehaviour
{
    // Start is called before the first frame update
   public void loadsScene()
    {
        SceneManager.LoadScene(1);
    }
}
