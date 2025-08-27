namespace TechJuego.HapticFeedback
{
    public class HapticCall
    {
        public static void HeavyHaptic()
        {
#if UNITY_IOS
        iOSPlugins.PerformUIImpactFeedbackStyleHeavy();
#endif

#if UNITY_ANDROID
        AndroidPlugins.PerformUIImpactFeedbackStyleHeavy();
#endif
        }
        public static void MediumHaptic()
        {
#if UNITY_IOS
        iOSPlugins.PerformUIImpactFeedbackStyleMedium();
#endif

#if UNITY_ANDROID
        AndroidPlugins.PerformUIImpactFeedbackStyleMedium();
#endif
        }
        public static void LightHaptic()
        {
#if UNITY_IOS
        iOSPlugins.PerformUIImpactFeedbackStyleLight();
#endif
#if UNITY_ANDROID
        AndroidPlugins.PerformUIImpactFeedbackStyleLight();
#endif
        }
        public static void RigidHaptic()
        {
#if UNITY_IOS
        iOSPlugins.PerformUIImpactFeedbackStyleRigid();
#endif
#if UNITY_ANDROID
        AndroidPlugins.PerformUIImpactFeedbackStyleRigid();
#endif
        }
        public static void SoftHaptic()
        {
#if UNITY_IOS
        iOSPlugins.PerformUIImpactFeedbackStyleSoft();
#endif
#if UNITY_ANDROID
        AndroidPlugins.PerformUIImpactFeedbackStyleSoft();
#endif
        }
        public static void PerformSuccessFeedback()
        {
#if UNITY_IOS
        iOSPlugins.PerformUINotificationFeedbackTypeSuccess();
#endif
#if UNITY_ANDROID
        AndroidPlugins.PerformUINotificationFeedbackTypeSuccess();
#endif
        }
        public static void PerformErrorFeedback()
        {
#if UNITY_IOS
        iOSPlugins.PerformUINotificationFeedbackTypeError();
#endif
#if UNITY_ANDROID
        AndroidPlugins.PerformUINotificationFeedbackTypeError();
#endif
        }
        public static void PerformWarningFeedback()
        {
#if UNITY_IOS
        iOSPlugins.PerformUINotificationFeedbackTypeWarning();
#endif
#if UNITY_ANDROID
        AndroidPlugins.PerformUINotificationFeedbackTypeWarning();
#endif
        }
    }
}