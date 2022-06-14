## AkBoneDynamics
[![Unity](https://img.shields.io/badge/-Unity-333333.svg?logo=unity&style=plastic)](https://unity3d.com)  

Simple bone dynamics for easy setup.  
This project is for learning and experimental purposes. Please note that it is not designed to be implemented as-is in games, etc. 

![motion_sample.gif](.images/motion_sample.gif)  

## .Assets/AkBoneDynamics/
|Script|Category|Description|
|---|---|---|
|**AkBoneDynamics.cs**|Core|One is required per bone group.<br>Can be attached to any GameObject.|
|**AkBoneDynamicsLight.cs**|Core|Constraint and Angle Limit removed from `AkBoneDynamics.cs`|
|**AkBDSphereCollider.cs**|Collider|Sphere Collider.<br>Attach to GameObject want to collider.|
|**AkBDCapsuleCollider.cs**|Collider|Capsule Collider.<br>Attach to GameObject want to collider.|
|**AkBDPlaneCollider.cs**|Collider|Infinite Plane Collider.<br>Attach to GameObject want to collider.|
|**AkBDCollider.cs**|Base class|Base class for all colliders.|

### Inspector
![Inspector.jpg](.images/Inspector.jpg)  

### Gizmos / Debug
![edit.jpg](.images/edit.jpg)  

### Supported colliders
![colliders.jpg](.images/colliders.jpg)  

## References
* [Advanced Character Physics by Thomas Jakobsen](http://www.cs.cmu.edu/afs/cs/academic/class/15462-s13/www/lec_slides/Jakobsen.pdf)  
* [Position Based Dynamics by Matthias Müller, Bruno Heidelberger, Marcus Hennix, John Ratcliff](https://matthias-research.github.io/pages/publications/posBasedDyn.pdf)  
* [Position Based Dynamics Combo 物理シミュレーション関連の最新論文実装](https://github.com/nobuo-nakagawa/cedec2017)  
