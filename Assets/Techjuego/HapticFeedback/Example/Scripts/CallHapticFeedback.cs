using UnityEngine;
namespace TechJuego.HapticFeedback
{
    public class CallHapticFeedback : MonoBehaviour
    {
        public void HeavyHaptic()
        {
            HapticCall.HeavyHaptic();
        }
        public void MediumHaptic()
        {
            HapticCall.MediumHaptic();
        }
        public void LightHaptic()
        {
            HapticCall.LightHaptic();
        }
        public void RigidHaptic()
        {
            HapticCall.RigidHaptic();

        }
        public void SoftHaptic()
        {
            HapticCall.SoftHaptic();
        }
        public void PerformSuccessFeedback()
        {
            HapticCall.PerformSuccessFeedback();
        }
        public void PerformErrorFeedback()
        {
            HapticCall.PerformErrorFeedback();
        }
        public void PerformWarningFeedback()
        {
            HapticCall.PerformWarningFeedback();
        }
    }

}