---
title: Game Initialization
difficulty: 1 #1-3
code: 1
art: 0
engine: 0
---
<!--instead-of-->
Static initializers or static constructors for static variables. Multiple [InitializeOnLoad].
<!--try-->
Create one specific unified initialization routine to run for each of Unity’s initialization callbacks and attributes (like [InitializeOnLoad]).
<!--because-->
Static initializers make editor performance slower during startup, compiling, play mode entry/exit, and a few other places. They also inject a small amount of overhead for any code that accesses the class with the static initializer or constructor, which adds up.
