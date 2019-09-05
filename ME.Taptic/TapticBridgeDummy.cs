namespace ME.Taptic {

    public class TapticBridgeDummy : ITapticBridge {

        void ITapticBridge.Play(TapticType type, float duration, float strength) {
            
            #if UNITY_EDITOR
            UnityEngine.Debug.Log("Play Vibration " + type + " with duration " + duration + ", amplitude: " + strength);
            #endif
            
        }

    }

}