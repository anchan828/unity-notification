unity-notification
==================

iOSとAndroidの通知に関するプラグイン


android-support-v4.jarが必要です。

``` 
<sdk_path>/extras/android/support/v4
```
![](http://gyazo.com/688483785aeca798ef52d97b5d99142c.png)

`Android` 通知　（プログレスバー表示）

[Android Developers](http://developer.android.com/guide/topics/ui/notifiers/notifications.html#Progress)に書かれているサンプルと同じように実装できます

```
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
```

![](http://gyazo.com/c5c8f87e2205dfd5ac52d79b06962297.png)

![](http://gyazo.com/51918fc1d8e07e6c70a3f337579817e6.png)