using System;
using UnityEngine;

public class NotificationCompat
{
    static AndroidJavaObject currentActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");

    public AndroidJavaObject androidJavaObject;

    public class Builder
    {
        public AndroidJavaObject androidJavaObject;
        public Builder()
        {
            androidJavaObject = new AndroidJavaObject("android.support.v4.app.NotificationCompat$Builder", currentActivity);
        }

        public AndroidJavaObject Build()
        {
            return androidJavaObject.Call<AndroidJavaObject>("build");
        }

        public Builder SetContentTitle(string title)
        {
            AndroidJavaObject _title = new AndroidJavaObject("java.lang.String", title);
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setContentTitle", _title);
            return this;
        }
        public Builder SetContentText(string text)
        {
            AndroidJavaObject _text = new AndroidJavaObject("java.lang.String", text);
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setContentText", _text);
            return this;
        }

        public Builder SetProgress(int max, int progress, bool indeterminate)
        {
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setProgress", max, progress, indeterminate);
            return this;
        }

        public Builder SetSmallIcon(Icon icon = Icon.App)
        {
            int num = 0;

            switch (icon)
            {
                case Icon.App:
                    var applicationInfo = currentActivity.Call<AndroidJavaObject>("getApplicationInfo");
                    num = applicationInfo.Get<int>("icon");
                    break;
                default:
                    throw new ArgumentOutOfRangeException("icon");
            }
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setSmallIcon", num);
            return this;
        }


        public enum Icon
        {
            App
        }
    }
}