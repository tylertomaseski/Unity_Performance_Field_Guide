---
title: Deep transform hierarchies
difficulty: 1 #1-3
code: 1
art: 0
engine: 0
---
<!--instead-of-->
Maintaining large Transform hierarchies (for UI or temporary shared motion or scene organization)
<!--try-->
Keep Transform hierarchies as flat as possible
<!--because-->
They make internal per-frame Transform operations slower. Transform hierarchies reduce the multithreading ability of the animation system and IJobParallelForTransform jobs. They make most UI operations slower.

If you NEED to maintain deep transform parenting, consider unparenting objects at runtime.