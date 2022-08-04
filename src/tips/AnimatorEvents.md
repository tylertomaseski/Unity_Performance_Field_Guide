---
title: Animator events & animator state behaviours
difficulty: 3 #1-3
code: 1
art: 1
engine: 0
animation: 1
---
<!--instead-of-->
Using animator <a href="https://docs.unity3d.com/ScriptReference/StateMachineBehaviour.html">StateMachineBehaviour</a> or <a href ="https://docs.unity3d.com/Manual/script-AnimationWindowEvent.html">Animation Events</a>.
<!--try-->
Avoid reading from animators at all if possible. If necessary, read animation data explicitly after animations finish for that frame.
<!--because-->
StateMachineBehaviour callbacks and Animation Events lock animation work to the main thread, severely limiting multithreading and creating a bottleneck.
<br/><br/>
This requires a good amount of architecture and tools for authoring animation events & behaviours.