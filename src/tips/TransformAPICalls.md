---
title: Transform.position and other extern APIs
difficulty: 2 #1-3
code: 1
art: 0
engine: 0
---
<!--instead-of-->
Using Transform.position, Transform.rotation, etc. multiple times per-frame
<!--try-->
Access any Transform data you need twice per simulation step in an IJobParallelForTransform job: once for reading from Transforms, once for writing to them.
<!--because-->
Transform access is slow. It involves expensive managed/native interop and struct copying.