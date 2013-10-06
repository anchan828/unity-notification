using System.Runtime.CompilerServices;
using UnityEngine;
using System.Collections;
/// <summary>
/// ここからiOS / Android 両方のNotificationを呼び出せるようにする予定
/// </summary>
public class Notification : MonoBehaviour {
//
//    public static int localNotificationCount {
//        get
//        {
//
//#if UNITY_ANDROID
//            return 0;
//#endif
//            return NotificationServices.localNotificationCount;
//        }
//    }
//
//    public static LocalNotification[] localNotifications
//    {
//        get
//        {
//#if UNITY_ANDROID
//            return null;
//#endif
//            return NotificationServices.localNotifications;
//        }
//    }
//
//    public static LocalNotification[] scheduledLocalNotifications {
//        get
//        {
//#if UNITY_ANDROID
//            return null;
//#endif
//            return NotificationServices.scheduledLocalNotifications;
//        }
//    }
//
//    public static int remoteNotificationCount {
//        get
//        {
//#if UNITY_ANDROID
//           
//#endif
//            return NotificationServices.remoteNotificationCount;
//        }
//    }
//
//    public static RemoteNotification[] remoteNotifications
//    {
//        get
//        {
//#if UNITY_ANDROID
//            return null;
//#endif
//            return NotificationServices.remoteNotifications;
//        }
//    }
//
//    public static RemoteNotificationType enabledRemoteNotificationTypes {
//        get
//        {
//#if UNITY_ANDROID
//            return RemoteNotificationType.Alert;
//#endif
//            return NotificationServices.enabledRemoteNotificationTypes;
//        }
//    }
//
//    public static byte[] deviceToken {
//        get
//        {
//#if UNITY_ANDROID
//            return null;
//#endif
//            return NotificationServices.deviceToken;
//        }
//    }
//
//    public static string registrationError {
//        get
//        {
//#if UNITY_ANDROID
//            return null;
//#endif
//            return NotificationServices.registrationError;
//        }
//    }
//
//    public static LocalNotification GetLocalNotification(int index)
//    {
//#if UNITY_ANDROID
//            return null;
//#endif
//        return NotificationServices.GetLocalNotification(index);
//    }
//
//    public static void ScheduleLocalNotification(LocalNotification notification)
//    {
//#if UNITY_ANDROID
//           
//#elif
//        NotificationServices.ScheduleLocalNotification(notification);
//#endif
//        
//    }
//
//    public static void PresentLocalNotificationNow(LocalNotification notification)
//    {
//#if UNITY_ANDROID
//           
//#elif
//        NotificationServices.PresentLocalNotificationNow(notification);
//#endif
//        
//    }
//
//    public static void CancelLocalNotification(LocalNotification notification)
//    {
//#if UNITY_ANDROID
//           
//#elif
//        NotificationServices.CancelLocalNotification(notification);
//#endif
//        
//    }
//
//    public static void CancelAllLocalNotifications()
//    {
//        #if UNITY_ANDROID
//           
//#elif
//        NotificationServices.CancelAllLocalNotifications();
//#endif
//        
//    }
//
//    public static RemoteNotification GetRemoteNotification(int index)
//    {
//#if UNITY_ANDROID
//      return  null;
//      
//#endif
//      return  NotificationServices.GetRemoteNotification(index);
//    }
//
//    public static void ClearLocalNotifications()
//    {
//        #if UNITY_ANDROID
//           
//#elif
//        NotificationServices.ClearLocalNotifications();
//#endif
//        
//    }
//
//    public static void ClearRemoteNotifications()
//    {
//        #if UNITY_ANDROID
//           
//#elif
//        NotificationServices.ClearRemoteNotifications();
//#endif
//        
//    }
//
//    public static void RegisterForRemoteNotificationTypes(RemoteNotificationType notificationTypes)
//    {
//        #if UNITY_ANDROID
//           
//#elif
//        NotificationServices.RegisterForRemoteNotificationTypes(notificationTypes);
//#endif
//        
//    }
//
//    public static void UnregisterForRemoteNotifications()
//    {
//        #if UNITY_ANDROID
//           
//#elif
//        NotificationServices.UnregisterForRemoteNotifications();
//#endif
//        
//    }
}
