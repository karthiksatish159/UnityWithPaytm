using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Text.RegularExpressions;
//This script is not attached to any component or any object and for expermential use i was created 
public class Backend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
   public void PaytmGatway()
    {
        //Application.OpenURL("http://127.0.0.1:4000/");
		 Application.ExternalEval("window.open(\"http://www.unity3d.com\")");
    }
    // IEnumerator GetRequest(string url)
    // {
    //     UnityWebRequest uwr = UnityWebRequest.Get(uri);
    //     yield return uwr.SendWebRequest();

    //     if (uwr.isNetworkError)
    //     {
    //      Debug.Log("Error While Sending: " + uwr.error);
    //     }
    //     else
    //     {
    //          Debug.Log("Received: " + uwr.downloadHandler.text);
    //     }
    // }
    // Update is called once per frame
    void Update()
    {
        
    }
}
