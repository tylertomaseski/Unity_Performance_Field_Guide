---
title: Check array length once in a for-loop
difficulty: 1 #1-3
code: 1
art: 0
engine: 0
---
<!--instead-of-->
Checking a collections length inside the for-loop.
<!--try-->
Cache the collections length and use the cached int in the for-loop.
<!--because-->
The compiler doesn't know if you've edited the array, so it politely asks the collection every for-loop what it's length is. This isn't a herculean task, but it takes a little time. And this adds up across your entire code-base!