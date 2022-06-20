using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Networking;

public class AdsManager : MonoBehaviour,IUnityAdsListener
{
 string  googlePlayID        = "4802357";
 string  applePlayID         = "4802356";
 string  myVideoId           = "video";
 string  myRewardVideoId     = "Rewarded_Android";
 string  myInterstatialId    = "Interstitial_Android";
 string  myBannerId          = "Banner_Android";
 bool    isTestGameMode  = false;
 // Start is called before the first frame update
 void Start()
 {
     Advertisement.AddListener (this);
     Advertisement.Initialize(googlePlayID, isTestGameMode);
     
 }
 public void DisplayInterstitialAds() {
     if (Advertisement.IsReady(myInterstatialId)) {
         Advertisement.Show(myInterstatialId);
         }
 }
 public void DisplayVideoAds() {
     Advertisement.Show(myRewardVideoId);
 }
 // Implement IUnityAdsListener interface methods:
 public void OnUnityAdsDidFinish (string surfacingId, ShowResult showResult) {
     // Define conditional logic for each ad completion status:
     if (showResult == ShowResult.Finished) {
         // Reward the user for watching the ad to completion.
         Debug.Log ("You get a reward.");
		//Get the email data when you doing login and hold the email value till end
		StartCoroutine(getRequest("https://paytmgatewayholo.herokuapp.com/coins/addCoins/50/karthiksatish159@gmail.com"));
		
     } else if (showResult == ShowResult.Skipped) {
         // Do not reward the user for skipping the ad.
         Debug.Log ("You don't get a reward.");
     } else if (showResult == ShowResult.Failed) {
         Debug.Log ("The ad did not finish due to an error.");
     }
 }
 public void OnUnityAdsReady (string surfacingId) {
     // If the ready Ad Unit or legacy Placement is rewarded, show the ad:
     if (surfacingId == myRewardVideoId) {
         // Optional actions to take when theAd Unit or legacy Placement becomes ready (for example, enable the rewarded ads button)
     }
 }
 public void OnUnityAdsDidError (string message) {
     // Log the error.
 }
 public void OnUnityAdsDidStart (string surfacingId) {
     // Optional actions to take when the end-users triggers an ad.
 } 
 // When the object that subscribes to ad events is destroyed, remove the listener:
 public void OnDestroy() {
     Advertisement.RemoveListener(this);
 }
 IEnumerator getRequest(string uri)
{
    UnityWebRequest uwr = UnityWebRequest.Get(uri);
    yield return uwr.SendWebRequest();

    if (uwr.isNetworkError)
    {
        Debug.Log("Error While Sending: " + uwr.error);
    }
    else
    {
        Debug.Log("Received: " + uwr.downloadHandler.text);
    }
}
    
}
