# TapticEngine
Taptic Engine with full source code for iOS and Android (AnimationCurve supported)

<div style="float:left">
<img src="/GitHubImages/img1.png?raw=true" alt="drawing" width="200" height="100"/>
<img src="/GitHubImages/img2.png?raw=true" alt="drawing" width="200" height="100"/>
<img src="/GitHubImages/img3.png?raw=true" alt="drawing" width="200" height="100"/>
<img src="/GitHubImages/img4.png?raw=true" alt="drawing" width="200" height="100"/>
  </div>

# Code usage sample

```C#
public AnimationCurve curve;
private ME.Taptic.ITapticEngine taptic;

void Start() {
  
  this.taptic = new ME.Taptic.TapticEngine();
  this.taptic.SetActiveModule(new ME.Taptic.TapticAnimationCurveImpl());  // You can implement your own behaviour to solve taptic curves
  this.taptic.SetMaxChannels(3);  // Here you can set max channels count
  
}

void Update() {
  
  this.taptic.Update(); // we need to get updates every frame
  
}

void Play() {
  
  this.taptic.PlayCurve(this.curve, randomize: true); // randomize parameter will play random variant adjusted to amlitude & duration
  
  this.taptic.PlaySingle(ME.Taptic.TapticType.Selection); // play single vibration effect
  
}
```
