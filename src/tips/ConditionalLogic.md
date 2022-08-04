---
title: Update ticketing/queuing
difficulty: 2 #1-3
code: 1
art: 0
engine: 0
---
<!--instead-of-->
Doing everything every frame no matter the framerate.
<!--try-->
Take turns running certain logic. So some things only update every X frames.
<!--because-->
Some logic, like AI, may not need to "think" every frame. Your slime enemies need to move every frame, but probably only need to "think" every X frames.
<br /> <br />
A simple ticketing system can allow non-frame dependent logic to run less frequently. This will help distribute your logic across multiple frames.
