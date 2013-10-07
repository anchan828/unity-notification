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

        public Builder SetContentIntent(AndroidJavaObject intent = null)
        {
            if (intent == null)
            {
                intent = new AndroidJavaObject("android.content.Intent", "android.intent.action.MAIN");
                AndroidJavaObject component = currentActivity.Call<AndroidJavaObject>("getComponentName");
                intent.Call<AndroidJavaObject>("setComponent", component);
            }


            AndroidJavaClass pendingIntentClass = new AndroidJavaClass("android.app.PendingIntent");
            AndroidJavaObject pendingIntent = pendingIntentClass.CallStatic<AndroidJavaObject>("getActivity", currentActivity, 0, intent, 134217728);
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setContentIntent", pendingIntent);
            return this;
        }

        public Builder SetContentInfo(string info)
        {
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setContentInfo", info);
            return this;
        }

        public Builder SetContentTitle(string title)
        {
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setContentTitle", title);
            return this;
        }
        public Builder SetContentText(string text)
        {
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setContentText", text);
            return this;
        }

        public Builder SetNumber(int number)
        {
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setNumber", number);
            return this;
        }

        public Builder SetProgress(int max, int progress, bool indeterminate)
        {
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setProgress", max, progress, indeterminate);
            return this;
        }

        public Builder SetOnlyAlertOnce(bool onlyAlertOnce)
        {
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setOnlyAlertOnce", onlyAlertOnce);
            return this;
        }

        public Builder SetSound(string uriString)
        {
            AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
            AndroidJavaObject uri = uriClass.CallStatic<AndroidJavaObject>("parse", uriString);
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setSound", uri);
            return this;
        }

        public Builder SetDefaults(Notification.Default defaults)
        {
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setDefaults", (int)defaults);
            return this;
        }

        public Builder SetSubText(string text)
        {
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setSubText", text);
            return this;
        }

        public Builder SetTicker(string tickerText)
        {
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setTicker", tickerText);
            return this;
        }
        public Builder SetSmallIcon(Notification.Icon icon = Notification.Icon.App)
        {
            int num = 0;

            switch (icon)
            {
                case Notification.Icon.App:
                    var applicationInfo = currentActivity.Call<AndroidJavaObject>("getApplicationInfo");
                    num = applicationInfo.Get<int>("icon");
                    break;
                default:
                    throw new ArgumentOutOfRangeException("icon");
            }
            androidJavaObject = androidJavaObject.Call<AndroidJavaObject>("setSmallIcon", num);
            return this;
        }

    }
}