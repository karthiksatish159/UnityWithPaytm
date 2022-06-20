using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Switch()
    {
            SceneManager.LoadScene(1);
        
    }
    public void SwitchToBack()
    {
        SceneManager.LoadScene(0);
    }
    public void SwitchToBalance()
    {
        SceneManager.LoadScene(2);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
