---
title: Check array length once in a for-loop
difficulty: 0
---
<!--section-->
Checking a collections length inside the for-loop.
<!--section-->
Cache the collections length and use the cached int in the for-loop.
<!--section-->
The compiler doesn't know if you've edited the array, so it politely asks the collection every for-loop what it's length is. This isn't a hurculean task, but it takes a little time. And this adds up across your entire code-base!