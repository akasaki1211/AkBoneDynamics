## AkBoneDynamics
[![Unity](https://img.shields.io/badge/-Unity-333333.svg?logo=unity&style=plastic)](https://unity3d.com)  

Simple bone dynamics for easy setup.  
This project is for learning purposes.  
Please note that it is not designed to be implemented as-is in games, etc. 

## .Assets/AkBoneDynamics/
|Script|Category|Description|
|---|---|---|
|**AkBoneDynamics.cs**|Core|One is required per bone group.<br>Can be attached to any GameObject.|
|**AkBoneDynamicsLight.cs**|Core|Constraint and Angle Limit removed from `AkBoneDynamics.cs`|
|**AkBDSphereCollider.cs**|Collider|Sphere Collider.<br>Attach to GameObject want to collider.|
|**AkBDCapsuleCollider.cs**|Collider|Capsule Collider.<br>Attach to GameObject want to collider.|
|**AkBDPlaneCollider.cs**|Collider|Infinite Plane Collider.<br>Attach to GameObject want to collider.|
|**AkBDCollider.cs**|Base class|Base class for all colliders.|
