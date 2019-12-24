using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadLevel1() {
        SceneManager.LoadScene("Level01");
    }

    public void aboutUs()
    {
        SceneManager.LoadScene("AboutUs");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("StartGame");
    }
}
