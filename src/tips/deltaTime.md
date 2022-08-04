---
title: Time.deltaTime and other static accessors
difficulty: 1 #1-3
code: 1
art: 0
engine: 0
---
<!--instead-of-->
Accessing static variables like Time.deltaTime whenever you need them
<!--try-->
Cache them once per frame in your own static variables before any logic runs for the frame.
<!--because-->
Many static accessors go through the same managed/native interop as Transform does. Many that don’t still involve expensive interactions with the operating system. Many do both.