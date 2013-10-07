unity-notification
==================

iOSとAndroidの通知に関するプラグイン

**まだAndroidのProgress通知だけです**

android-support-v4.jarが必要です。

``` 
<sdk_path>/extras/android/support/v4
```
![](http://gyazo.com/688483785aeca798ef52d97b5d99142c.png)

`Android` 通知　（プログレスバー表示）

[Android Developers](http://developer.android.com/guide/topics/ui/notifiers/notifications.html#Progress)に書かれているサンプルと同じように実装できます

```cs
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
        builder.SetTicker("ダウンロード中です");
        builder.SetSmallIcon();
        builder.SetProgress(100, 0, true);

        manager.Notify(0, builder.Build());

        www = new WWW("https://dl.dropboxusercontent.com/u/153254465/Unity%E7%B3%BB/test.unity3d");

        while (!www.isDone && www.error == null)
        {
            builder.SetProgress(100, (int)(www.progress * 100), true);
            builder.SetNumber((int)(www.progress * 100));
            manager.Notify(0, builder.Build());
            yield return new WaitForEndOfFrame();
        }
        builder.SetProgress(0, 0, false);
        Notification.Default defauls = Notification.Default.Sound | Notification.Default.Vibrate;
        builder.SetDefaults(defauls);
        builder.SetTicker("ダウンロードが完了しました");
        builder.SetContentText("ダウンロードが完了しました");
        builder.SetContentIntent();
        manager.Notify(0, builder.Build());
    }

    void OnGUI()
    {
        if (www != null)
            GUILayout.Label(www.progress.ToString());
        if (GUILayout.Button("Retry", GUILayout.Width(256), GUILayout.Height(256)))
        {
            StartCoroutine(Load());
        }
        GUILayout.Label(Time.time.ToString());
    }
}
```

![](http://gyazo.com/c5c8f87e2205dfd5ac52d79b06962297.png)

![](http://gyazo.com/51918fc1d8e07e6c70a3f337579817e6.png)
