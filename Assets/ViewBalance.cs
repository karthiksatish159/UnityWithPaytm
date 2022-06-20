using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ViewBalance : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI _text;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    public void  Get_Data()
    {
        StartCoroutine(GetData_Coroutine());
      
    }
    IEnumerator GetData_Coroutine()
    {
        //outputArea.text = "Loading ...";
        string url = "https://paytmgatewayholo.herokuapp.com/viewBalance/karthiksatish159@gmail.com";
        using(UnityWebRequest request=UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();
            if(request.isNetworkError||request.isHttpError)
            {
                _text.text = request.error;
            }
            else
            {
                _text.text =request.downloadHandler.text;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
