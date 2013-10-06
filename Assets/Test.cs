using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    private WWW www;
    
    void Start()
    {
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        NotificationManager manager = NotificationManager.GetNotificationManager();
        NotificationCompat.Builder builder = new NotificationCompat.Builder();
        
        builder.SetContentTitle("必要なデータのダウンロード");
        builder.SetContentText("ダウンロード中です");
        builder.SetSmallIcon();
        builder.SetProgress(100, 0, false);
        manager.Notify(0, builder.Build());

        www = new WWW("https://dl.dropboxusercontent.com/u/153254465/Unity%E7%B3%BB/test.unity3d");

        while (!www.isDone)
        {
            builder.SetProgress(100, (int)(www.progress * 100), false);
            manager.Notify(0, builder.Build());
            yield return new WaitForEndOfFrame();
        }

        builder.SetContentText("ダウンロードが完了しました");
        manager.Notify(0, builder.Build());
    }

    void OnGUI()
    {
        if (www != null)
            GUILayout.Label(www.progress.ToString());
        if (GUILayout.Button("Retry"))
        {
            StartCoroutine(Load());
        }
    }
}
