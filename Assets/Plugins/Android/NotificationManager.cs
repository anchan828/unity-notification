using UnityEngine;

public class NotificationManager
{
    private static NotificationManager notificationManager;
    private AndroidJavaObject androidJavaObject;

    static AndroidJavaObject currentActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
    public static NotificationManager GetNotificationManager()
    {
        if (notificationManager == null)
        {
            notificationManager = new NotificationManager();
            notificationManager.androidJavaObject = currentActivity.Call<AndroidJavaObject>("getSystemService", "notification");
        }
        return notificationManager;
    }

    public void Notify(int id, AndroidJavaObject androidJavaObject)
    {
        // TODO AndroidJavaRunnableを使うべき？
//        currentActivity.Call("runOnUiThread",new AndroidJavaRunnable(() =>{
//            notificationManager.androidJavaObject.Call("notify", id, androidJavaObject);
//		}));
        notificationManager.androidJavaObject.Call("notify", id, androidJavaObject);
    }
}
