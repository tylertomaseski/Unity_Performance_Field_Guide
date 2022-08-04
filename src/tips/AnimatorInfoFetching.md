---
title: Animator Key Hashing
difficulty: 1 #1-3
code: 1
art: 1
engine: 0
---
<!--instead-of-->
Setting and getting values from animators with strings.
<!--try-->
Generating string hashes once and then using generated ints.
<!--because-->
Every time you pass a string to an animator, it will "hash" the string. Which is slow. You can instead do this once on your end, and reuse the generated integer id.