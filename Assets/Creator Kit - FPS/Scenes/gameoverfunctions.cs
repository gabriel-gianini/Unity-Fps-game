using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverfunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMenu", 4f);
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene("menu1");
    }
}
